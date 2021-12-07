using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class BattleStage2_2 : MonoBehaviour
{

    //���� vs ��Ƽ

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
    private int _enemyDamage;        //���� �Ʊ����� �ִ� ���ط�
    private int playerDamage;       //�Ʊ��� ������ �ִ� ���ط�
    private int _playerDamage;       //�Ʊ��� ������ �ִ� ���ط�
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
    public ParticleSystem Skilleffect_1;
    public ParticleSystem Skilleffect_2;
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

        if (player.GetComponent<MobydickScript>().Agility > enemy.GetComponent<Enemy_Silme>().Agility)
            OrderAttack = true;
        else
            OrderAttack = false;


        MoveCloud.transform.DOLocalMoveX(2000, 100.0f);                      //�����̵�
        Skuilleffect.Stop();
        Skilleffect_1.Stop();                                                  //��ų����Ʈ ����
        Skilleffect_2.Stop();
        //EnemyReset();                                                       //�� ��ġ �� 
        enemyDamage = enemy.GetComponent<Enemy_Silme>().Power - player.GetComponent<MobydickScript>().Defense;            //��  ���ݴ����
        _enemyDamage = Boss.GetComponent<MantiScript>().Power - player.GetComponent<MobydickScript>().Defense;
        playerDamage = player.GetComponent<MobydickScript>().Power - enemy.GetComponent<Enemy_Silme>().Defense;           //�÷��̾� ���ݴ����
        _playerDamage = player.GetComponent<MobydickScript>().Power - Boss.GetComponent<MantiScript>().Defense;
        Player_HPMax = player.GetComponent<MobydickScript>().HP;
        Debug.Log(Player_HPMax);
        Enemy_HPMax = enemy.GetComponent<Enemy_Silme>().HP;
        Boss_HPMax = Boss.GetComponent<MantiScript>().HP;
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
        player.GetComponent<MobydickScript>().walk();
        player.transform.DOLocalMoveX(-330, 1);             //#001
    }
    void MovePlayer_Boss()  //���� �������� ���۽� �÷��̾� �̵���� �� �̵�
    {
        player.GetComponent<MobydickScript>().walk();
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
        player.GetComponent<MobydickScript>().walk_3();
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
        //enemy.GetComponent<Renderer>().sharedMaterials[1].DOColor(color, "_Color", 0.2f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }


    void Update()
    {
        if (MobClear == false && _GameOver == false)  //��� ����
        {

            Player_Hpbar.fillAmount = player.GetComponent<MobydickScript>().HP / Player_HPMax;
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
                    ForBattle_FMod.instance.SkillReady();
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
                        Invoke("_Battle_Cut_Emblem", 3.2f);

                        Invoke("SkiilAttack_Mob", 4.0f);
                        Invoke("ResetDamageText", 5.5f);
                        SkillAttack = false;
                    }
                    else
                    {
                        Invoke("PlayerAttack_Mob", 0.3f);
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
            if (BossUI == true)  //���� ü�¹� �̸� ǥ��
            {
                Player_Hpbar.fillAmount = player.GetComponent<MobydickScript>().HP / Player_HPMax;
                Enemy_HPbar.fillAmount = Boss.GetComponent<MantiScript>().HP / Boss_HPMax;
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
            ForBattle_FMod.instance.BattleCutScene();  //��ų ���� ������ �ƽ�
            Debug.Log("���� ���� ��ų ����Ʈ ");
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


            Invoke("EnemyReset", 0.6f);
            Invoke("skeletonMark", 0.6f);
            Invoke("FadeInMoveBoss", 2.0f);
            Invoke("FadeOutMoveBoss", 5.0f);
            Invoke("BossStageResetPosition", 5.0f);
            Invoke("MoveBackGround_Boss", 7.0f);
            Invoke("MovePlayer_Mob", 7.5f);
            Invoke("BossFadeIn", 8.0f);

            time = -8.0f; //�� �������� �� �ҿ�ð� -5�� ~ 2�� = 7�ʰ� ������ 
        }




        if (player.GetComponent<MobydickScript>().HP <= 0) //�Ʊ� ĳ���� ���Characterstartmove_Boss
        {
            Invoke("OverSound", 2.0f);
            Invoke("GameOver", 2.0f);
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
        player.transform.DOLocalMoveX(-1266, 0.5f);
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
        player.transform.DOLocalMoveX(-750, 0.5f);
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
        player.transform.DOLocalMoveX(-620, 0.8f);
        MainCamera.transform.DOLocalMoveX(-75, 0.8f); //#003
        MainCamera.transform.DOLocalMoveZ(15, 0.8f);
        player.GetComponent<MobydickScript>().wait_2();
        ForBattle_FMod.instance.BattleEndGood();  //�̼� Ŭ���� ����
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
        SaveData.GetComponent<SaveDataManager>()._Gene_Between2 = false; //�̳༮�� ���丮 ��� �� ����â���� �̾��ִ� �����̶� ����� �������.
        SaveData.GetComponent<SaveDataManager>()._Stage2_2= true;
        SaveData.GetComponent<SaveDataManager>().Save();
        SceneManager.LoadScene("2_2_After");
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
        //player.transform.DOLocalMoveX(310, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3    //�÷��̾� �����̵�  ##002
       //player.transform.DOLocalMoveY(105, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3   //�÷��̾� �����̵�  
        player.GetComponent<MobydickScript>().attack();
        enemy.GetComponent<Enemy_Silme>().damage(); //�ǰݸ��

        enemy_blood_1.SetActive(true);
        player_blood_1.SetActive(false);
        Skilleffect_2.Play();

        ForBattle_FMod.instance.Normal_Attack_modibic();        //��Ϻ�콺 ���� ����

        Invoke("Mob_Blood_1_Fadein", 0.1f);
        Invoke("Mob_Blood_2_Fadein", 0.2f);
        Invoke("Mob_Blood_1_FadeOut", 0.6f);
        Invoke("Mob_Blood_2_FadeOut", 0.8f);
        Invoke("_camera", 0.2f);
        Invoke("BloodReset", 1f);
        enemy.transform.DOLocalMoveX(705, 0.8f);    //�� �ǰ� ��ġ�� �̵� #7
        enemy.GetComponent<Enemy_Silme>().HP = enemy.GetComponent<Enemy_Silme>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);
    }

    void BloodReset()   //�� ��ġ ���� #8
    {
        enemy_blood_1.transform.localPosition = new Vector3(1f, 4.3f, 0.1f);  //�� ���� ��ġ
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
        Color color = new Color(0f, 0f, 0f, 0f);
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
        player.GetComponent<MobydickScript>().attack();
        //player.transform.DOLocalMoveX(310, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3    #002
        //player.transform.DOLocalMoveY(105, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3   #9
        Boss.GetComponent<MantiScript>().damage(); //�ǰݸ��
        Boss.GetComponent<MantiScript>().HP = Boss.GetComponent<MantiScript>().HP - _playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);

        ForBattle_FMod.instance.Normal_Attack_modibic();        //��Ϻ�콺 ���� ����

        Skilleffect_2.Play();
        Invoke("Boss_Blood_1_Fadein", 0.1f);
        Invoke("Boss_Blood_1_FadeOut", 0.6f);
        Invoke("_camera", 0.2f);
        Invoke("BloodReset", 1f);
        Boss.transform.DOLocalMoveX(1030, 0.8f);                 //#10
        //enemy.transform.DOLocalMoveX(705, 0.8f);                //#11
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);

        if (Boss.GetComponent<MantiScript>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<MantiScript>().HP / Boss_HPMax;
            Invoke("EnemyReset", 0.6f);
            Invoke("skeletonMark", 0.6f);
            Invoke("StageClear", 2.0f);
            _GameOver = true;
        }
    }

    void resetposition() //#12 ��ü ��ġ�� �ʱ�ȭ��
    {
        player.transform.DOLocalMoveX(-330, 0.5f).SetEase(Ease.OutQuad);    //#001
        player.transform.DOLocalMoveY(105, 0.5f).SetEase(Ease.OutQuad);
        enemy.transform.DOLocalMoveX(630, 0.5f).SetEase(Ease.OutQuad);
        Boss.transform.DOLocalMoveX(900, 0.5f).SetEase(Ease.OutQuad);       //#004
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
        Battle_Cut_Face.transform.DOLocalMoveX(-47f, 1f);
        Battle_Cut_Emblem.transform.DOLocalMoveX(92.0f, 1f);
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
        player.GetComponent<MobydickScript>().skill();
        Skilleffect_1.Play();
        //player.transform.DOLocalMoveX(-170, 0.6f); //��ų���� ���X
     
        //player.transform.DOLocalMoveY(90, 0.6f); //��ų���� ���Y
        Boss.GetComponent<MantiScript>().HP = Boss.GetComponent<MantiScript>().HP - (_playerDamage * 2); //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���

        ForBattle_FMod.instance.SA_Modibic();        //��Ϻ�콺 ��ų ���� ����


        //Invoke("SkillSecondMove", 0.6f);
        //Invoke("SkillSecondMotion", 1.0f);
        //Invoke("SkillSecondEffect", 1.2f);
        Invoke("Boss_Blood_1_Fadein", 1.2f);
        Invoke("Boss_Blood_1_FadeOut", 1.7f);
        Invoke("_camera", 1.2f);
        Invoke("damegeBossSkill", 1.2f);
        Invoke("CameraReset", 1f);
        Invoke("SkilleffectOut", 2.0f);
        Boss.transform.DOLocalMoveX(1030, 0.8f);
        _SkillAttack = false;
        if (Boss.GetComponent<MantiScript>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<MantiScript>().HP / Boss_HPMax;
            Invoke("EnemyReset", 3.6f);
            Invoke("skeletonMark", 3.6f);
            Invoke("CameraReset_Boss", 3.6f);
            Invoke("StageClear", 5.0f);
            _GameOver = true;
        }
    }

    void SkillSecondMove()
    {
        player.transform.DOLocalMoveX(60, 0.3f); //��ų���� ���X
        player.transform.DOLocalMoveY(105, 0.3f); //��ų���� ���Y
    }
    void SkillSecondMotion()
    {
        Debug.Log("��ų2�� ���");
        player.GetComponent<MobydickScript>().skill();
    }
    void SkillSecondEffect()
    {
        Skilleffect_2.Play();
    }

    void damegeBossSkill() //���� ��ų����
    {
        MainCamera.transform.DOLocalMoveX(24, 0.8f);
        MainCamera.transform.DOLocalMoveZ(11, 0.8f);
        Boss.transform.DOLocalMoveX(1100, 0.8f);
        enemy.transform.DOLocalMoveX(705, 0.8f);
        Boss.GetComponent<MantiScript>().damage();
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���
        ForBattle_FMod.instance.normalHitEffect();  // ��ų�� ���� �� ����
        Invoke("CameraReset_Boss", 1f);
    }
    void CameraReset_Boss() //���� �������� ī�޶� ����
    {
        Boss.transform.DOLocalMoveX(900, 0.8f);  //##004
        MainCamera.transform.DOLocalMoveX(-0.8f, 0.8f);
        MainCamera.transform.DOLocalMoveZ(-13.3f, 0.8f);
    }
    void SkilleffectOut() //��ų����Ʈ ����
    {
        Skilleffect_1.Stop();
        Skilleffect_2.Stop();
        resetposition();
        player.GetComponent<MobydickScript>().ResetWait_1();
    }
    void EnemyAttack_Mob()  //#14
    {
        enemy_blood_1.SetActive(false);
        player_blood_1.SetActive(true);

        enemy.GetComponent<Enemy_Silme>().attack();
        enemy.transform.DOLocalMoveX(-250, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3  
        Invoke("_camera", 0.2f);
        player.GetComponent<MobydickScript>().damage();
        player.GetComponent<MobydickScript>().HP = player.GetComponent<MobydickScript>().HP - enemyDamage; //�ǰݽ� ����� ����� �Ʊ� ĳ���� HP ����
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

        Skilleffect_1.Stop();
        Skilleffect_2.Stop();

        Boss.GetComponent<MantiScript>().attack();
        Boss.transform.DOLocalMoveX(90, 0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
        Invoke("_camera", 0.2f);
        player.GetComponent<MobydickScript>().damage();
        player.GetComponent<MobydickScript>().HP = player.GetComponent<MobydickScript>().HP - _enemyDamage; //�ǰݽ� ����� ����� �Ʊ� ĳ���� HP ����
        player.transform.DOLocalMoveX(-735, 0.8f);


        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 1);

        ForBattle_FMod.instance.Nattack_Lev_2();  //���� ��Ƽ�ھ� ���� 2 ���� ����

        Invoke("Player_Blood_1_Fadein", 0.1f);
        Invoke("Player_Blood_2_Fadein", 0.2f);
        Invoke("Player_Blood_1_FadeOut", 0.6f);
        Invoke("Player_Blood_2_FadeOut", 0.8f);
        Invoke("damegetest", 1.1f);
        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);

        if (Boss.GetComponent<MantiScript>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<MantiScript>().HP / Boss_HPMax;
            Invoke("EnemyReset", 0.6f);
            Invoke("skeletonMark", 0.6f);
            Invoke("StageClear", 2.0f);
        }
    }
    public void skeletonMark()
    {
        Debug.Log("�ذ�����Ʈ �÷���");
        Skuilleffect.Play();
    }

    public void _camera()
    {
        MainCamera.GetComponent<CameraShake>().AttackCameraShake(0.5f, 3);
    }
    public void usedSkill()
    {
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
        Skilleffect_1.gameObject.SetActive(false);
        Skilleffect_2.gameObject.SetActive(false);
    }


}
