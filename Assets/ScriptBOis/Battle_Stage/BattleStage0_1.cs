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
    public GameObject player_blood_1;
    public GameObject Boss_blood_1;
    public GameObject Mob_Name_Bar;
    public GameObject Boss_Name_Bar;
    public GameObject UICanvas;
    public Image MoveCloud;
    private new MeshRenderer renderer;
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
    public ParticleSystem Skuilleffect;
    public GameObject MissionFail;
    public GameObject MissionClear;
    public GameObject SaveData;
    private bool CameraRoundR = false;
    private bool CameraRoundL = false;
    private bool MobClear = false;
    public Image Battle_Cut_Back;
    public Image Battle_Cut_Face;
    public Image Battle_Cut_Front_1;
    public Image Battle_Cut_Front_2;
    public Image Battle_Cut_Emblem;
    public Image Battle_Cut_TextCase;
    public Text Battle_Cut_Text;
    public bool _SkillAttack = false;
    private bool BossUI = false;
    private bool _GameOver = false;
    private bool GameOverTrigger = true;

    // public GameObject boss;

    void Start()
    {
        ForBattle_FMod.instance.BattleReady();       //���� ���� ����
        time = -4;


        Color color = new Color(1f, 1f, 1f, 1f);
        player.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        color = new Color(0f, 0f, 0f, 0f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        color = new Color(0f, 0f, 0f, 0f);
        enemy.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        enemy.GetComponent<Renderer>().sharedMaterials[1].DOColor(color, "_Color", 1);

        OrderAttack = true;
      

        MoveCloud.transform.DOLocalMoveX(2000, 100.0f);                      //�����̵� 
        Skilleffect.Stop();
        Skuilleffect.Stop();
        //EnemyReset();                                                       //�� ��ġ �� 
        enemyDamage = enemy.GetComponent<Enemy_Silme>().Power - player.GetComponent<RabbitScript>().Defense;            //��  ���ݴ����
        playerDamage = player.GetComponent<RabbitScript>().Power - enemy.GetComponent<Enemy_Silme>().Defense;           //�÷��̾� ���ݴ����
        Player_HPMax = player.GetComponent<RabbitScript>().HP;
        Enemy_HPMax = enemy.GetComponent<Enemy_Silme>().HP;
        Boss_HPMax = Boss.GetComponent<EnemyMush>().HP;
        renderer = enemy.GetComponent<MeshRenderer>();
        _block = new MaterialPropertyBlock();
        renderer.SetPropertyBlock(_block);
        int id = Shader.PropertyToID("_Block");
        _block.SetColor(id, new Color(100, 100, 100, 0));
        

        Invoke("PanelFade", 2.5f);
        Invoke("MoveBackGround_Mob", 3.0f);
        Invoke("MovePlayer_Mob", 3.8f);
        Invoke("EnemyFadeIn", 5.0f); //�׸��� 1�ʵڿ� �� ��� ���̵� ��
        Invoke("Characterstartmove", 6.0f);
    }

    void PanelFade()
    {
        Debug.Log("�ǳ� ���̵�");
        BlackPanel.DOFade(0, 2.0f);  //������ �г� 2�ʵ��� ���̵� �ƿ�
        MissionStartImage.DOFade(0, 2.0f);  //������ �г� 2�ʵ��� ���̵� �ƿ�
    }

    void MovePlayer_Mob()     //��� �������� ���۽� �÷��̾� Ȱ��ȭ,�̵���� �� �̵�
    {
        player.SetActive(true);
        player.GetComponent<RabbitScript>().walk_2();
        player.transform.DOLocalMoveX(-660, 1);
    }
    void MovePlayer_Boss()  //���� �������� ���۽� �÷��̾� �̵���� �� �̵�
    {
        player.GetComponent<RabbitScript>().walk_2();
    }
    void MoveBackGround_Mob() //��� �������� ���۽� �޹�� �̵�
    {
        BackGround.transform.DOLocalMoveX(1270, 1);
    }
    void MoveBackGround_Boss() //���� �������� ���۽� �޹�� �̵�
    {
        BackGround.transform.DOLocalMoveX(-940, 1);
    }
    void Characterstartmove_Boss()  //üũ 1��
    {
        Debug.Log("��뿩�� üũ 1��");
      player.GetComponent<RabbitScript>().walk_3();
    }
    void EnemyFadeIn() //�� ĳ���� ���̵��� 
    {   
        Color color = new Color(1f, 1f, 1f, 1f);
        enemy.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        enemy.GetComponent<Renderer>().sharedMaterials[1].DOColor(color, "_Color", 1);
    }
    void EnemyReset()  //�� ĳ����(���, ���� ���̵� �ƿ�)
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        enemy.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
        enemy.GetComponent<Renderer>().sharedMaterials[1].DOColor(color, "_Color", 0.2f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }


    void Update()
    {
        Debug.Log(time);
        if (MobClear == false && _GameOver == false)  //��� ����
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
                    ForBattle_FMod.instance.SkillReady();       //��ų �غ� �Ϸ� ����
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
                        
                        time = -7.0f;
                        Debug.Log("���̵���");
                        Battle_Cut_Back.DOFade(0.7f, 2.0f);

                        ForBattle_FMod.instance.BattleCutScene();  //��ų ���� ������ �ƽ�

                        Invoke("_Battle_Cut_Front", 3.0f);
                        Invoke("_Battle_Cut_Face", 3.0f);
                        Invoke("_Battle_Cut_Text", 3.0f);
                        Invoke("_Battle_Cut_Emblem",3.2f);
                        
                        Invoke("SkiilAttack_Mob",4.0f);
                        Invoke("ResetDamageText", 5.5f);
                        SkillAttack = false;
                    }
                    else
                    {
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

        else if (MobClear == true && _GameOver == false)        //���� ����
        {
            if(BossUI == true)  //���� ü�¹� �̸� ǥ��
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
                    ForBattle_FMod.instance.SkillReady();       //��ų �غ� �Ϸ� ����
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
            ForBattle_FMod.instance.BattleCutScene();  //��ų ���� ������ �ƽ�
            Boss.SetActive(false);
            player.SetActive(false);
            Battle_Cut_Back.DOFade(0.7f, 1.0f);
            Invoke("_Battle_Cut_Front", 1.0f);
            Invoke("_Battle_Cut_Face", 2.0f);
            Invoke("_Battle_Cut_Text", 2.5f);
            Invoke("_Battle_Cut_Emblem", 2.3f);
            Invoke("_Battle_Cut_Reset", 3.5f);
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
            OrderAttack = true;
          

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




        if (player.GetComponent<RabbitScript>().HP <= 0) //�Ʊ� ĳ���� ���Characterstartmove_Boss
        {

            Invoke("OverSound", 2.0f);
            Invoke("GameOver",2.0f);

        }

    }
    void OverSound()
    {
        if (GameOverTrigger == true)
        {
            ForBattle_FMod.instance.BattleFailed();  //���� ����
            GameOverTrigger = false;
        }
    }


    void CharactorFadeOut()
    {
        Debug.Log("��뿩�� üũ 2");
        BossFadeIn();
    }
    void CameraR()  //ī�޶� ȸ��R
    {
        Debug.Log("��뿩�� üũ 3");
        CameraRoundR = true;
    }
    void CameraL() //ī�޶� ȸ��L
    {
        Debug.Log("��뿩�� üũ 3");
        CameraRoundL = true;
    }
    void BossFadeIn() //���� ���̵��� UI ����
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        BossUI = true;
        Mob_Name_Bar.SetActive(false);
        Boss_Name_Bar.SetActive(true);
    }

    void BossStageResetPosition() //������������ ��ġ�� ����   ��ġ�� ������ġ#1
    {
        BackGround.transform.DOLocalMoveX(-700, 0.5f);
        player.transform.DOLocalMoveX(-1248,0.5f);
    }
    void FadeInMoveBoss()    //������������ ��� ȭ�� ���� 
    {
        Debug.Log("���� ���̵� ����ȭ��");
        BlackPanel.DOFade(1, 1.0f); //����ȭ��ȭ
        player.SetActive(false);
        Invoke("WarningFadeIn", 0);
        Invoke("WarningFadeOut", 0.75f);
        Invoke("WarningFadeIn", 1.5f);
        Invoke("WarningFadeOut", 2.25f);
    }
    void WarningFadeIn()  //���� ���̵���
    {
        Warning_Image.DOFade(1, 0.75f);
    }
    void WarningFadeOut() //���� ���̵� �ƿ�
    {
        Warning_Image.DOFade(0, 0.75f);
    }

    void FadeOutMoveBoss()   //���� ���̵� �ƿ�
    { 
        BlackPanel.DOFade(0, 3.0f);   //����ȭ
        //Warning_Image.DOFade(0, 2.0f);
    }

    void StageClear()  //�������� �¸� ����
    {
        ResetDamageText();
        time = 0;
        enemy.SetActive(false);
        Invoke("Clearsave", 5f);
        Invoke("ClearMotion", 1); 
    }

    void ClearMotion() //�������� Ŭ���� ��ǿ���      ��ġ�� ���� ��ġ#2
    {
        Debug.Log("Ŭ������");
        UICanvas.SetActive(false);
        player.transform.DOLocalMoveX(-680, 0.8f);
        MainCamera.transform.DOLocalMoveX(-65, 0.8f);
        MainCamera.transform.DOLocalMoveZ(15, 0.8f);
        player.GetComponent<RabbitScript>().wait_2();
        Invoke("_MissionClear", 2);
    }
    void _MissionClear()   //�̼� Ŭ���� ȭ�� Ȱ��ȭ
    {
        Debug.Log("�̼�Ŭ����");
        MissionClear.SetActive(true);
    }

    void Clearsave()   //Ŭ������ ���̺� ������ �Է� �������� Ŭ���� üũ ���� #3
    {
        SaveData.GetComponent<SaveDataManager>()._ResearchPoint = SaveData.GetComponent<SaveDataManager>()._ResearchPoint + 3; //Ŭ���� ���� +3
        SaveData.GetComponent<SaveDataManager>()._Stage1_4 = true;
        SaveData.GetComponent<SaveDataManager>().Save();
        SceneManager.LoadScene("inGameScene");
    }

    void failsave()     //�̼� ���� �ΰ������� �̵�
    {
        SceneManager.LoadScene("inGameScene");
    }

    void GameOver()  //���� �й� ����
    {
        if (time < 1.0f)
        {

            time += Time.deltaTime;
        }
        else
        {
            Color color = new Color(0f, 0f, 0f, 0f);
            player.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
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
        player.transform.DOLocalMoveX(100, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3    //�÷��̾� �����̵� #5 x��ġ��
        player.transform.DOLocalMoveY(-150, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3   //�÷��̾� �����̵� #6 y��ġ��
        player.GetComponent<RabbitScript>().attack();
        enemy.GetComponent<Enemy_Silme>().damage(); //�ǰݸ��

        enemy_blood_1.SetActive(true);
        player_blood_1.SetActive(false);

        ForBattle_FMod.instance.Nattack_Lev_1();  //����1����

        Invoke("Mob_Blood_1_Fadein", 0.1f);
        Invoke("Mob_Blood_2_Fadein", 0.2f);
        Invoke("Mob_Blood_1_FadeOut", 0.6f);
        Invoke("Mob_Blood_2_FadeOut", 0.8f);
        Invoke("_camera", 0.2f);
        Invoke("BloodReset",1f);
        enemy.transform.DOLocalMoveX(705, 0.8f);    //�� �ǰ� ��ġ�� �̵� #7
        enemy.GetComponent<Enemy_Silme>().HP = enemy.GetComponent<Enemy_Silme>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);
        Invoke("resetposition",1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset",1f);
    }

    void BloodReset()   //�� ��ġ ���� #8
    {
        enemy_blood_1.transform.localPosition = new Vector3(0f, 3.6f, 0.1f);  //�� ���� ��ġ
    }
    void Mob_Blood_1_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        enemy_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);

    }
    void Boss_Blood_1_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        Boss_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Boss_Blood_1_FadeOut()
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        Boss_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Mob_Blood_1_FadeOut()
    {
        Debug.Log("�� �� ���̵�ƿ�");
        Color color = new Color(0f,0f, 0f, 0f);
        enemy_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
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

    void PlayerAttack_Boss()
    {

        Boss_blood_1.SetActive(true);
        player_blood_1.SetActive(false);
        enemy_blood_1.SetActive(false);
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        player.GetComponent<RabbitScript>().attack();
        player.transform.DOLocalMoveX(100, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3    #8
        player.transform.DOLocalMoveY(-150, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3   #9
        Boss.GetComponent<EnemyMush>().damage(); //�ǰݸ��
        Boss.GetComponent<EnemyMush>().HP = Boss.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);

        ForBattle_FMod.instance.Nattack_Lev_1();  //����1����

        Invoke("Boss_Blood_1_Fadein", 0.1f);
        Invoke("Boss_Blood_1_FadeOut", 0.6f);
        Invoke("_camera", 0.2f);
        Invoke("BloodReset", 1f);
        Boss.transform.DOLocalMoveX(725, 0.8f);                 //#10
        //enemy.transform.DOLocalMoveX(705, 0.8f);                //#11
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);



        if (Boss.GetComponent<EnemyMush>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<EnemyMush>().HP / Boss_HPMax;
            Invoke("EnemyReset", 0.6f);
            Invoke("skeletonMark", 0.6f);
            Invoke("StageClear", 2.0f);
            _GameOver = true;
        }
    }

    void resetposition() //#12 ��ü ��ġ�� �ʱ�ȭ��
    {

        player.transform.DOLocalMoveX(-660, 0.5f).SetEase(Ease.OutQuad);
        player.transform.DOLocalMoveY(-250, 0.5f).SetEase(Ease.OutQuad);
        enemy.transform.DOLocalMoveX(630, 0.5f).SetEase(Ease.OutQuad);
        Boss.transform.DOLocalMoveX(600, 0.5f).SetEase(Ease.OutQuad);
    }
    public void skeletonMark()
    {
        Debug.Log("�ذ�����Ʈ �÷���");
        Skuilleffect.Play();
    }
    void _Battle_Cut_Front()
    {
        Debug.Log("�չ��");
        Battle_Cut_Front_1.transform.DOLocalMoveX(40.4f, 1f);
        Battle_Cut_Front_2.transform.DOLocalMoveX(40.4f, 1f);
    }
    void _Battle_Cut_Face()
    {
        Debug.Log("���̽�");
        Battle_Cut_Face.transform.DOLocalMoveX(-11.8f , 1f);
        Battle_Cut_Emblem.transform.DOLocalMoveX(90f, 1f);
    }
    void _Battle_Cut_Reset()
    {
        Battle_Cut_Back.DOFade(0, 1.0f);
        Battle_Cut_Face.DOFade(0, 1.0f);
        Battle_Cut_Front_1.DOFade(0, 1.0f);
        Battle_Cut_Front_2.DOFade(0, 1.0f);
        Battle_Cut_Front_2.transform.DOLocalMoveX(40.3f, 1f);
        Battle_Cut_Emblem.DOFade(0, 1.0f);
        Battle_Cut_Text.DOFade(0, 1.0f);
        Battle_Cut_TextCase.DOFade(0, 1.0f);
    }
    void _Battle_Cut_Text()
    {
        Debug.Log("�ؽ�Ʈ");
        Battle_Cut_Text.DOFade(1, 1f);
        Battle_Cut_TextCase.DOFade(1, 1.0f);
        //Battle_Cut_Emblem.DOFade(1, 0.7f);
    }
    void _Battle_Cut_Emblem()
    {
        Battle_Cut_Emblem.DOFade(1, 1.0f);
    }

    void SkiilAttack_Boss()
    {
        Boss_blood_1.SetActive(true);
        player_blood_1.SetActive(false);
        Boss.SetActive(true);
        player.SetActive(true);
        player.GetComponent<RabbitScript>().skill();
        Skilleffect.Play();
        Boss.GetComponent<EnemyMush>().HP = Boss.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���

        ForBattle_FMod.instance.SA_ConRabbit();  //�ܷ��� ��ų ���� ����

        Invoke("Boss_Blood_1_Fadein", 1.2f);
        Invoke("Boss_Blood_1_FadeOut", 1.7f);
        Invoke("_camera", 1.2f);                        
        Invoke("damegeBossSkill", 1.2f);
        Invoke("CameraReset", 1f);
        Invoke("SkilleffectOut",2.0f);
        _SkillAttack = false;
        if (Boss.GetComponent<EnemyMush>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<EnemyMush>().HP / Boss_HPMax;
            Invoke("EnemyReset", 3.6f);
            Invoke("CameraReset_Boss", 3.6f);
            Invoke("StageClear", 5.0f);
            _GameOver = true;
        }
    }
    void damegeBossSkill() //���� ��ų����
    {
        MainCamera.transform.DOLocalMoveX(24, 0.8f);
        MainCamera.transform.DOLocalMoveZ(11,0.8f);
        Boss.transform.DOLocalMoveX(725, 0.8f);
        enemy.transform.DOLocalMoveX(705, 0.8f);
        Boss.GetComponent<EnemyMush>().damage();
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���
        ForBattle_FMod.instance.normalHitEffect();  // ��ų�� ���� �� ����
        Invoke("CameraReset_Boss", 1f);
    }
    void CameraReset_Boss() //���� �������� ī�޶� ����
    {
        Boss.transform.DOLocalMoveX(600, 0.8f);
        MainCamera.transform.DOLocalMoveX(-0.8f, 0.8f);
        MainCamera.transform.DOLocalMoveZ(-13.3f, 0.8f);
    }
    void SkilleffectOut() //��ų����Ʈ ����
    {
        Skilleffect.Stop();
        player.GetComponent<RabbitScript>().ResetWait_1();
    }
    void EnemyAttack_Mob()  //#14
    {
        enemy_blood_1.SetActive(false);
        player_blood_1.SetActive(true);
       
        enemy.GetComponent<Enemy_Silme>().attack();
        enemy.transform.DOLocalMoveX(-250, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3  
        Invoke("_camera", 0.2f);
        player.GetComponent<RabbitScript>().damage();
        player.GetComponent<RabbitScript>().HP = player.GetComponent<RabbitScript>().HP - enemyDamage; //�ǰݽ� ����� ����� �Ʊ� ĳ���� HP ����
        player.transform.DOLocalMoveX(-735, 0.8f);

        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 1);

        ForBattle_FMod.instance.normalHitEffect();  //����1����

        Debug.Log("Mob���� ");
        Invoke("Player_Blood_1_Fadein", 0.1f);
        Invoke("Player_Blood_2_Fadein", 0.2f);
        Invoke("Player_Blood_1_FadeOut", 0.6f);
        Invoke("Player_Blood_2_FadeOut", 0.8f);
        Invoke("damegetest", 1.1f);
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);
    }
    void EnemyAttack_Boss()
    {
        Boss_blood_1.SetActive(false);
        player_blood_1.SetActive(true);
        enemy_blood_1.SetActive(false);

        Skilleffect.Stop();
        Boss.GetComponent<EnemyMush>().attack_1();
        Boss.transform.DOLocalMoveX(-340, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
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
        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 1);

        ForBattle_FMod.instance.normalHitEffect();  //���� �ӽ� ����1 ���� ����

        Invoke("Player_Blood_1_Fadein", 0.1f);
        Invoke("Player_Blood_2_Fadein", 0.2f);
        Invoke("Player_Blood_1_FadeOut", 0.6f);
        Invoke("Player_Blood_2_FadeOut", 0.8f);
        Invoke("damegetest", 1.1f);
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);

        if (Boss.GetComponent<EnemyMush>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<EnemyMush>().HP / Boss_HPMax;
            Invoke("EnemyReset", 0.6f);
            Invoke("skeletonMark", 0.6f);
            Invoke("StageClear", 2.0f);
        }
    }
    public void _camera()
    {
        MainCamera.GetComponent<CameraShake>().AttackCameraShake(0.5f, 3);
    }
    public void usedSkill()
    {
        Time.timeScale = 1.0f;
        ForBattle_FMod.instance.SkillTurnON();      //��ų ������ Ŭ��
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
