using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;



public class BattleStage0_1 : MonoBehaviour
{

    public GameObject player;       //�÷��̾� ĳ����
    public GameObject enemy;        //Mob
    public GameObject Boss;         //Boss
    public GameObject enemy_blood_1;      //�ǰ� ������Ʈ1
    public GameObject enemy_blood_2;      //�ǰ� ������Ʈ2
    public GameObject player_blood_1;
    public GameObject player_blood_2;
    public GameObject Mob_Name_Bar;
    public GameObject Boss_Name_Bar;
    public Image MoveCloud;
    private MeshRenderer renderer;
    private MaterialPropertyBlock _block;
    private int enemyDamage;        //���� �Ʊ����� �ִ� ���ط�
    private int playerDamage;       //�Ʊ��� ������ �ִ� ���ط�
    public Image Player_Hpbar;      //�Ʊ�ĳ���� HP�� ����ȭBoss_HPMax
    public Image Enemy_HPbar;       //����ĳ���� Hp�� ����ȭ
    public Image Skiil_Bar;         //��ų������ ����ȭ
    private float Player_HPMax;     //�Ʊ�ĳ���� Hp�� ����� ó���� ����
    private float Enemy_HPMax;      //����ĳ���� Hp�� ����� ó���� ����
    private float Boss_HPMax;
    float time = -3.0f;                 //�����Ӻ� �����̿� time ����
    private bool OrderAttack = true;      //true : �Ʊ���������, false : �� ��������   
    private float skill;
    public GameObject SkillIcon;
    private bool SkillAttack = false;       //��ų���ݿ���
    public Camera MainCamera;
    public Image BlackPanel;
    public Image Warning_Image;
    public Image MissionStartImage;
    public Image BackGround;
    public GameObject EnemyDamageText;
    public GameObject PlayerDamageText;
    public ParticleSystem Skilleffect;
    public GameObject MissionFail;
    public GameObject MissionClear;
    public GameObject SaveData;
    private bool CameraRoundR = false;
    private bool CameraRoundL = false;
    private bool MobClear = false;
    public Image Battle_Cut_Back;
    public Image Battle_Cut_Face;
    public Image Battle_Cut_Front;
    public Text Battle_Cut_Text;
    public bool _SkillAttack = false;
    private bool BossUI = false;
    private bool _GameOver = false;


    // public GameObject boss;

    void Start()
    {
        MoveCloud.transform.DOLocalMoveX(2000, 100.0f);
        Skilleffect.Stop();
        //MainCamera.GetComponent<CameraShake>().AttackCameraShake(1.5f, 5);
        //�⺻����
        EnemyReset();
        enemyDamage = enemy.GetComponent<Enemy_Silme>().Power - player.GetComponent<RabbitScript>().Defense;
        playerDamage = player.GetComponent<RabbitScript>().Power - enemy.GetComponent<Enemy_Silme>().Defense;
        Player_HPMax = player.GetComponent<RabbitScript>().HP;
        Enemy_HPMax = enemy.GetComponent<Enemy_Silme>().HP;
        Boss_HPMax = Boss.GetComponent<EnemyMush>().HP;
        renderer = enemy.GetComponent<MeshRenderer>();
        _block = new MaterialPropertyBlock();
        renderer.SetPropertyBlock(_block);
        
        int id = Shader.PropertyToID("_Block");
        _block.SetColor(id, new Color(100, 100, 100, 0));

        

        
        BlackPanel.DOFade(0, 2.0f);  //������ �г� 2�ʵ��� ���̵� �ƿ�
        MissionStartImage.DOFade(0, 2.0f);  //������ �г� 2�ʵ��� ���̵� �ƿ�
        //Warning_Image.DOFade(1, 1.0f);

        Invoke("MoveBackGround_Mob", 3.0f);
        Invoke("MovePlayer_Mob", 2.8f);
        Invoke("EnemyFadeIn", 4.0f); //�׸��� 1�ʵڿ� �� ��� ���̵� ��
        Invoke("Characterstartmove", 4.5f);
    }

    void MovePlayer_Mob()
    {
        player.SetActive(true);
        player.GetComponent<RabbitScript>().walk_2();
        player.transform.DOLocalMoveX(-660, 1);
    }
    void MovePlayer_Boss()
    {
        player.GetComponent<RabbitScript>().walk_2();
    }
    void MoveBackGround_Mob()
    {
        BackGround.transform.DOLocalMoveX(1270, 1);
    }

    void MoveBackGround_Boss()
    {
        BackGround.transform.DOLocalMoveX(-940, 1);
    }
    void Characterstartmove()
    {
        //player.GetComponent<RabbitScript>().walk_2();
    }
    void Characterstartmove_Boss()
    {
        player.GetComponent<RabbitScript>().walk_3();
    }
    void EnemyFadeIn()
    {
        Debug.Log("�� ���̵���");
        Color color = new Color(1f, 1f, 1f, 1f);
        enemy.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        enemy.GetComponent<Renderer>().sharedMaterials[1].DOColor(color, "_Color", 1);
    }
    void EnemyReset()
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        enemy.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
        enemy.GetComponent<Renderer>().sharedMaterials[1].DOColor(color, "_Color", 0.2f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }


    void Update()
    {
        Debug.Log(time);
        if (MobClear == false && _GameOver == false)
        {
            Player_Hpbar.fillAmount = player.GetComponent<RabbitScript>().HP / Player_HPMax;
            Enemy_HPbar.fillAmount = enemy.GetComponent<Enemy_Silme>().HP / Enemy_HPMax;
            Skiil_Bar.fillAmount = skill;

            if (CameraRoundR == true)
            {
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 10), 0.5f);
                MainCamera.transform.DOLocalMoveZ(60, 0.5f);
                MainCamera.transform.DOLocalMoveZ(-13.3f, 0.5f);
                MainCamera.transform.DOLocalMoveX(70, 0.5f);
                MainCamera.transform.DOLocalMoveX(-0.8f, 0.5f);
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            }

            if (CameraRoundL == true)
            {
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, -10), 0.5f);
                MainCamera.transform.DOLocalMoveZ(60, 0.5f);
                MainCamera.transform.DOLocalMoveZ(-13.3f, 0.5f);
                MainCamera.transform.DOLocalMoveX(-70, 0.5f);
                MainCamera.transform.DOLocalMoveX(-0.8f, 0.5f);
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            }

            if (time < 2.0f)
            {
                time += Time.deltaTime;
            }
            else
            {
                if (skill == 1.0f) //��ų������ üũ 1.0 == ��ų�����Ϸ�
                {
                    SkillIcon.SetActive(true);      //��ų �����Ϸ�� Ȱ��ȭ
                }
                else
                {
                    SkillIcon.SetActive(false);     //�������� ��Ȱ��ȭ
                }

                if (OrderAttack == true)
                {

                    if (SkillAttack == true)
                    {
                        
                        //Time.timeScale = 0.0f;
                        time = -8.0f;
                        Debug.Log("���̵���");
                        Battle_Cut_Back.DOFade(1, 2.0f);

                        Invoke("_Battle_Cut_Front", 3.0f);
                        Invoke("_Battle_Cut_Face", 3.0f);
                        Invoke("_Battle_Cut_Text", 3.0f);
                        Invoke("SkiilAttack_Mob",4.0f);
                        Invoke("ResetDamageText", 5.5f);
                        SkillAttack = false;
                    }
                    else
                    {
                        //player.transform.DOLocalMoveX(-950, 0.1f).SetEase(Ease.Linear);
                        Invoke("PlayerAttack_Mob",0.3f);
                        Invoke("CameraR", 0.1f);
                        Invoke("ResetDamageText", 0.7f);

                    }
                    OrderAttack = false;
                    skill = skill + 0.25f; //��ų�������߰�
                }

                else if (OrderAttack == false)
                {
                    EnemyAttack_Mob();
                    Invoke("CameraL", 0.3f);
                    Invoke("ResetDamageText", 1.0f);
                    OrderAttack = true;
                    skill = skill + 0.25f; //��ų�������߰�
                }
                time = 0;
            }


        }

        else if (MobClear == true && _GameOver == false)
        {
            if(BossUI == true)
            {
                Player_Hpbar.fillAmount = player.GetComponent<RabbitScript>().HP / Player_HPMax;
                Enemy_HPbar.fillAmount = Boss.GetComponent<EnemyMush>().HP / Boss_HPMax;
                Skiil_Bar.fillAmount = skill;
            }
            

            if (CameraRoundR == true)
            {
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 10), 0.5f);
                MainCamera.transform.DOLocalMoveZ(60, 0.5f);
                MainCamera.transform.DOLocalMoveZ(-13.3f, 0.5f);
                MainCamera.transform.DOLocalMoveX(70, 0.5f);
                MainCamera.transform.DOLocalMoveX(-0.8f, 0.5f);
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            }

            if (CameraRoundL == true)
            {
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, -10), 0.5f);
                MainCamera.transform.DOLocalMoveZ(60, 0.5f);
                MainCamera.transform.DOLocalMoveZ(-13.3f, 0.5f);
                MainCamera.transform.DOLocalMoveX(-70, 0.5f);
                MainCamera.transform.DOLocalMoveX(-0.8f, 0.5f);
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            }

            if (time < 2.0f)
            {
                time += Time.deltaTime;
            }
            else
            {
                if (skill == 1.0f) //��ų������ üũ 1.0 == ��ų�����Ϸ�
                {
                    SkillIcon.SetActive(true);      //��ų �����Ϸ�� Ȱ��ȭ
                }
                else
                {
                    SkillIcon.SetActive(false);     //�������� ��Ȱ��ȭ
                }

                if (OrderAttack == true)
                {

                    if (SkillAttack == true)
                    {
                        _SkillAttack = true;
                        SkillAttack = false;


                    }
                    else
                    {
                        PlayerAttack_Boss();
                        CameraRoundR = true;
                        Invoke("ResetDamageText", 0.7f);

                    }
                    OrderAttack = false;
                    skill = skill + 0.25f; //��ų�������߰�
                }

                else if (OrderAttack == false)
                {
                    EnemyAttack_Boss();
                    CameraRoundL = true;
                    Invoke("ResetDamageText", 1.0f);
                    OrderAttack = true;
                    skill = skill + 0.25f; //��ų�������߰�
                }
                time = 0;
            }
        }

        if (_SkillAttack == true)
        {
            time = -6.5f;
            Debug.Log("���� ���� ��ų ����Ʈ ");
            Boss.SetActive(false);
            player.SetActive(false);
            Battle_Cut_Back.DOFade(1, 1.0f);
            Invoke("_Battle_Cut_Front", 1.0f);
            Invoke("_Battle_Cut_Face", 2.0f);
            Invoke("_Battle_Cut_Text", 2.0f);
            Invoke("_Battle_Cut_Reset", 3.0f);
            Invoke("SkiilAttack_Boss", 4.0f);
            Invoke("ResetDamageText", 5.5f);
            _SkillAttack = false;
            
        }


        if (skill >= 1)
        {
            SkillIcon.SetActive(true);
        }


        if (enemy.GetComponent<Enemy_Silme>().HP <= 0 && MobClear == false)  //�� ���
        {
            MobClear = true;
            Invoke("EnemyReset", 0.6f);
            Invoke("FadeInMoveBoss", 2.0f);
            Invoke("FadeOutMoveBoss", 5.0f);
            Invoke("BossStageResetPosition",5.0f);
            Invoke("MoveBackGround_Boss", 7.0f);
            Invoke("MovePlayer_Mob", 7.5f);
            Invoke("BossFadeIn", 8.0f);

            time = -8.0f; //�� �������� �� �ҿ�ð� -5�� ~ 2�� = 7�ʰ� ������ 
        }




        if (player.GetComponent<RabbitScript>().HP <= 0) //�Ʊ� ĳ���� ���
        {
            GameOver();
        }

    }
    void CharactorFadeOut()
    {
        BossFadeIn();

    }
    void CameraR()
    {
        CameraRoundR = true;
    }
    void CameraL()
    {
        CameraRoundL = true;
    }
    void BossFadeIn()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        BossUI = true;
        Mob_Name_Bar.SetActive(false);
        Boss_Name_Bar.SetActive(true);


    }

    void BossStageResetPosition()
    {
        BackGround.transform.DOLocalMoveX(-700, 0.5f);
        player.transform.DOLocalMoveX(-1248,0.5f);
        
    }
    void FadeInMoveBoss()
    {
        Debug.Log("���� ���̵� ����ȭ��");
        BlackPanel.DOFade(1, 1.0f); //����ȭ��ȭ
        player.SetActive(false);
        Invoke("WarningFadeIn", 0);
        Invoke("WarningFadeOut", 0.75f);
        Invoke("WarningFadeIn", 1.5f);
        Invoke("WarningFadeOut", 2.25f);
    }
    void WarningFadeIn()
    {
        Warning_Image.DOFade(1, 0.75f);
    }
    void WarningFadeOut()
    {
        Warning_Image.DOFade(0, 0.75f);
    }

    void FadeOutMoveBoss()
    { 
        BlackPanel.DOFade(0, 3.0f);   //����ȭ
        //Warning_Image.DOFade(0, 2.0f);
    }

    void StageClear()
    {
        ResetDamageText();
        time = 0;
        enemy.SetActive(false);
        Invoke("Clearsave", 5f);
        MissionClear.SetActive(true);
    }

    void Clearsave()
    {
        SaveData.GetComponent<SaveDataManager>()._ResearchPoint = SaveData.GetComponent<SaveDataManager>()._ResearchPoint + 3; //Ŭ���� ���� +3
        SaveData.GetComponent<SaveDataManager>()._Stage1_1 = true;
        SaveData.GetComponent<SaveDataManager>().Save();
        SceneManager.LoadScene("inGameScene");
    }

    void failsave()
    {
        SceneManager.LoadScene("inGameScene");
    }

    void GameOver()
    {
        if (time < 1.0f)
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0;
            player.SetActive(false);
            Invoke("failsave", 5f);
            ResetDamageText();

        }
        time += Time.deltaTime;
        MissionFail.SetActive(true);
    }
    
    void PlayerAttack_Mob()
    {
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        player.transform.DOLocalMoveX(100, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
        player.transform.DOLocalMoveY(-150, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
        player.GetComponent<RabbitScript>().attack();
        enemy.GetComponent<Enemy_Silme>().damage(); //�ǰݸ��
        float randomdataX = Random.Range(0, 10);
        float randomdataY= Random.Range(0, 10);
        float randomdataX_2 = Random.Range(0, 10);
        float randomdataY_2 = Random.Range(0, 10);
        randomdataX = randomdataX / 10;
        randomdataY = randomdataY / 10;
        randomdataX_2 = randomdataX_2 / 10;
        randomdataY_2 = randomdataY_2 / 10;

        Debug.Log(randomdataX);
        Debug.Log(randomdataY);
        Debug.Log(randomdataX_2);
        Debug.Log(randomdataY_2);

#pragma warning disable format
        enemy_blood_1.transform.localPosition = new Vector3(enemy_blood_1.transform.localPosition.x + randomdataX,
#pragma warning restore format
            enemy_blood_1.transform.localPosition.y+ randomdataX, enemy_blood_1.transform.localPosition.z);
        enemy_blood_2.transform.localPosition = new Vector3(enemy_blood_2.transform.localPosition.x + randomdataX_2,
            enemy_blood_2.transform.localPosition.y - randomdataY_2, enemy_blood_2.transform.localPosition.z);

        enemy_blood_1.SetActive(true);
        enemy_blood_2.SetActive(true);
        player_blood_1.SetActive(false);
        player_blood_2.SetActive(false);

        Invoke("Mob_Blood_1_Fadein", 0.1f);
        Invoke("Mob_Blood_2_Fadein", 0.2f);
        Invoke("Mob_Blood_1_FadeOut", 0.6f);
        Invoke("Mob_Blood_2_FadeOut", 0.8f);
        Invoke("_camera", 0.2f);
        Invoke("BloodReset",1f);
        enemy.transform.DOLocalMoveX(435, 0.8f);
        enemy.GetComponent<Enemy_Silme>().HP = enemy.GetComponent<Enemy_Silme>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);
        Invoke("resetposition",1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset",1f);
    }

    void BloodReset()
    {
        enemy_blood_1.transform.localPosition = new Vector3(6.5f, -3.64f, 0.1f);
        enemy_blood_2.transform.localPosition = new Vector3(2.7f, -1.4f, 0.1f);

    }
    void Mob_Blood_1_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        enemy_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Mob_Blood_1_FadeOut()
    {
        Color color = new Color(0f,0f, 0f, 0f);
        enemy_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Mob_Blood_2_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        enemy_blood_2.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Mob_Blood_2_FadeOut()
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        enemy_blood_2.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Player_Blood_1_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        player_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Player_Blood_1_FadeOut()
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        player_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Player_Blood_2_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        player_blood_2.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Player_Blood_2_FadeOut()
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        player_blood_2.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void PlayerAttack_Boss()
    {
        enemy_blood_1.SetActive(true);
        enemy_blood_2.SetActive(true);
        player_blood_1.SetActive(false);
        player_blood_2.SetActive(false);
        
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        player.GetComponent<RabbitScript>().attack();
        player.transform.DOLocalMoveX(100, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
        player.transform.DOLocalMoveY(-150, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
        Boss.GetComponent<EnemyMush>().damage(); //�ǰݸ��
        //����
        //Boss.transform.DOLocalMoveX(575, 0.8f);
        Boss.GetComponent<EnemyMush>().HP = Boss.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);
        Invoke("Mob_Blood_1_Fadein", 0.1f);
        Invoke("Mob_Blood_2_Fadein", 0.2f);
        Invoke("Mob_Blood_1_FadeOut", 0.6f);
        Invoke("Mob_Blood_2_FadeOut", 0.8f);
        Invoke("_camera", 0.2f);
        Invoke("BloodReset", 1f);
        Boss.transform.DOLocalMoveX(915, 0.8f);
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);

        if (Boss.GetComponent<EnemyMush>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<EnemyMush>().HP / Boss_HPMax;
            //Invoke("EnemyReset", 0.6f);
            Invoke("StageClear", 2.0f);
            _GameOver = true;
        }
    }

    void resetposition()
    {
        player.transform.DOLocalMoveX(-660, 0.5f).SetEase(Ease.OutQuad);
        player.transform.DOLocalMoveY(-250, 0.5f).SetEase(Ease.OutQuad);
        enemy.transform.DOLocalMoveX(360, 0.5f).SetEase(Ease.OutQuad);
        Boss.transform.DOLocalMoveX(840, 0.5f).SetEase(Ease.OutQuad);
    }

    void SkiilAttack_Mob()
    {
        //��ų ����Ʈ�ð� �ο��� ��ų ���� �Լ� �ۼ��ʿ�
        player.GetComponent<RabbitScript>().skill();
        enemy.GetComponent<Enemy_Silme>().damage();
        Skilleffect.Play();
        enemy.GetComponent<Enemy_Silme>().HP = enemy.GetComponent<Enemy_Silme>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���
        Invoke("damegetest", 1.1f);
        Invoke("CameraReset", 1f);
    }

    void _Battle_Cut_Front()
    {
        Debug.Log("�չ��");
        Battle_Cut_Front.transform.DOLocalMoveX(40.3f, 1f);
    }
    void _Battle_Cut_Face()
    {
        Debug.Log("���̽�");
        Battle_Cut_Face.transform.DOLocalMoveX(-11.8f , 1f);
    }
    void _Battle_Cut_Reset()
    {
        Battle_Cut_Back.DOFade(0, 1.0f);
        Battle_Cut_Face.DOFade(0, 1.0f);
        Battle_Cut_Front.DOFade(0, 1.0f);
        Battle_Cut_Text.DOFade(0, 1.0f);
    }

    void _Battle_Cut_Text()
    {
        Debug.Log("�ؽ�Ʈ");
        Battle_Cut_Text.DOFade(1, 1f);
    }

    void SkiilAttack_Boss()
    {
        enemy_blood_1.SetActive(true);
        enemy_blood_2.SetActive(true);
        player_blood_1.SetActive(false);
        player_blood_2.SetActive(false);
        //��ų ����Ʈ�ð� �ο��� ��ų ���� �Լ� �ۼ��ʿ�
        Boss.SetActive(true);
        player.SetActive(true);
        player.GetComponent<RabbitScript>().skill();
        //Boss.GetComponent<EnemyMush>().damage();
        Skilleffect.Play();
        Boss.GetComponent<EnemyMush>().HP = Boss.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���

        Invoke("Mob_Blood_1_Fadein", 1.2f);
        Invoke("Mob_Blood_2_Fadein", 1.3f);
        Invoke("Mob_Blood_1_FadeOut", 1.7f);
        Invoke("Mob_Blood_2_FadeOut", 1.8f);
        Invoke("_camera", 1.2f);
        Invoke("damegeBossSkill", 1.2f);
        Invoke("CameraReset", 1f);
        Invoke("SkilleffectOut",2.0f);
        _SkillAttack = false;

        if (Boss.GetComponent<EnemyMush>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<EnemyMush>().HP / Boss_HPMax;
            Invoke("EnemyReset", 3.6f);
            Invoke("StageClear", 5.0f);
            _GameOver = true;
        }
    }
    void damegeBossSkill()
    {
        MainCamera.transform.DOLocalMoveX(24, 0.8f);
        MainCamera.transform.DOLocalMoveZ(11,0.8f);
        Boss.transform.DOLocalMoveX(915, 0.8f);
        Boss.GetComponent<EnemyMush>().damage();
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���
        Invoke("CameraReset_Boss", 1f);
    }
    void CameraReset_Boss()
    {
        Boss.transform.DOLocalMoveX(840, 0.8f);
        MainCamera.transform.DOLocalMoveX(-0.8f, 0.8f);
        MainCamera.transform.DOLocalMoveZ(-13.3f, 0.8f);
    }
    void SkilleffectOut()
    {
        Skilleffect.Stop();
        player.GetComponent<RabbitScript>().ResetWait_1();
    }
    void EnemyAttack_Mob()
    {
        enemy_blood_1.SetActive(false);
        enemy_blood_2.SetActive(false);
        player_blood_1.SetActive(true);
        player_blood_2.SetActive(true);
        Skilleffect.Stop();
        enemy.GetComponent<Enemy_Silme>().attack();
        enemy.transform.DOLocalMoveX(-400, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
        Invoke("_camera", 0.2f);
        player.GetComponent<RabbitScript>().damage();
        player.GetComponent<RabbitScript>().HP = player.GetComponent<RabbitScript>().HP - enemyDamage; //�ǰݽ� ����� ����� �Ʊ� ĳ���� HP ����
        player.transform.DOLocalMoveX(-735, 0.8f);
        float randomdataX = Random.Range(0, 10);
        float randomdataY = Random.Range(0, 10);
        float randomdataX_2 = Random.Range(0, 10);
        float randomdataY_2 = Random.Range(0, 10);
        randomdataX = randomdataX / 10;
        randomdataY = randomdataY / 10;
        randomdataX_2 = randomdataX_2 / 10;
        randomdataY_2 = randomdataY_2 / 10;

        player_blood_1.transform.localPosition = new Vector3(player_blood_1.transform.localPosition.x - randomdataX,
            player_blood_1.transform.localPosition.y - randomdataX, player_blood_1.transform.localPosition.z);
        player_blood_2.transform.localPosition = new Vector3(player_blood_2.transform.localPosition.x - randomdataX_2,
            player_blood_2.transform.localPosition.y + randomdataY_2, player_blood_2.transform.localPosition.z);
        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 1);
        Invoke("Mob_Blood_1_Fadein", 0.1f);
        Invoke("Mob_Blood_2_Fadein", 0.2f);
        Invoke("Mob_Blood_1_FadeOut", 0.6f);
        Invoke("Mob_Blood_2_FadeOut", 0.8f);
        Invoke("damegetest", 1.1f);
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);
    }
    void EnemyAttack_Boss()
    {
        enemy_blood_1.SetActive(false);
        enemy_blood_2.SetActive(false);
        player_blood_1.SetActive(true);
        player_blood_2.SetActive(true);
        Skilleffect.Stop();
        Boss.GetComponent<EnemyMush>().attack_1();
        Boss.transform.DOLocalMoveX(0, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
        Invoke("_camera", 0.2f);
        player.GetComponent<RabbitScript>().damage();
        player.GetComponent<RabbitScript>().HP = player.GetComponent<RabbitScript>().HP - enemyDamage; //�ǰݽ� ����� ����� �Ʊ� ĳ���� HP ����
        player.transform.DOLocalMoveX(-735, 0.8f);
        float randomdataX = Random.Range(0, 10);
        float randomdataY = Random.Range(0, 10);
        float randomdataX_2 = Random.Range(0, 10);
        float randomdataY_2 = Random.Range(0, 10);
        randomdataX = randomdataX / 10;
        randomdataY = randomdataY / 10;
        randomdataX_2 = randomdataX_2 / 10;
        randomdataY_2 = randomdataY_2 / 10;

        player_blood_1.transform.localPosition = new Vector3(player_blood_1.transform.localPosition.x - randomdataX,
            player_blood_1.transform.localPosition.y - randomdataX, player_blood_1.transform.localPosition.z);
        player_blood_2.transform.localPosition = new Vector3(player_blood_2.transform.localPosition.x - randomdataX_2,
            player_blood_2.transform.localPosition.y + randomdataY_2, player_blood_2.transform.localPosition.z);
        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 1);


        Invoke("Mob_Blood_1_Fadein", 0.1f);
        Invoke("Mob_Blood_2_Fadein", 0.2f);
        Invoke("Mob_Blood_1_FadeOut", 0.6f);
        Invoke("Mob_Blood_2_FadeOut", 0.8f);
        Invoke("damegetest", 1.1f);
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);

        if (Boss.GetComponent<EnemyMush>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<EnemyMush>().HP / Boss_HPMax;
            Invoke("EnemyReset", 0.6f);
            Invoke("StageClear", 2.0f);
        }
    }
    public void _camera()
    {
        MainCamera.GetComponent<CameraShake>().AttackCameraShake(0.5f, 3);
    }
    public void usedSkill()
    {
        Debug.Log("usedSkill");
        skill = 0f;
        SkillAttack = true;
        SkillIcon.SetActive(false);
    }
    void CameraReset()
    {
        CameraRoundL = false;
        CameraRoundR = false;
    }

    void ResetDamageText()
    {
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        EnemyDamageText.GetComponent<DamageScript>().Reset();
    }

    void SkilleffectOff()
    {
        Skilleffect.gameObject.SetActive(false);
    }


}
