using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class Stage1_1 : MonoBehaviour
{

    public GameObject player;       //�÷��̾� ĳ����
    public GameObject enemy;        //�� ĳ���� ���� �ӽ�
    private int enemyDamage;        //���� �Ʊ����� �ִ� ���ط�
    private int playerDamage;       //�Ʊ��� ������ �ִ� ���ط�
    public Image Player_Hpbar;      //�Ʊ�ĳ���� HP�� ����ȭ
    public Image Enemy_HPbar;       //����ĳ���� Hp�� ����ȭ
    public Image Skiil_Bar;         //��ų������ ����ȭ
    private float Player_HPMax;     //�Ʊ�ĳ���� Hp�� ����� ó���� ����
    private float Enemy_HPMax;      //����ĳ���� Hp�� ����� ó���� ����
    float time = -3.0f;                 //�����Ӻ� �����̿� time ����
    private bool OrderAttack;      //true : �Ʊ���������, false : �� ��������   
    private float skill;
    public GameObject SkillIcon;
    private bool SkillAttack = false;       //��ų���ݿ���
    private bool isdead = false;
    public Camera MainCamera;
    public Image BlackPanel;
    public GameObject EnemyDamageText;
    public GameObject PlayerDamageText;
    public GameObject Skilleffect;
    public GameObject MissionFail;      
    public GameObject MissionClear;
    public GameObject SaveData;
    private bool CameraRoundR = false;
    private bool CameraRoundL = false;


    // public GameObject boss;

    void Start()
    {
        //MainCamera.GetComponent<CameraShake>().AttackCameraShake(1.5f, 5);
        //�⺻����
        enemyDamage = enemy.GetComponent<EnemyMush>().Power - player.GetComponent<MushScript>().Defense;
        playerDamage = player.GetComponent<MushScript>().Power - enemy.GetComponent<EnemyMush>().Defense;
        Player_HPMax = player.GetComponent<MushScript>().HP;
        Enemy_HPMax = enemy.GetComponent<EnemyMush>().HP;

        if (player.GetComponent<MushScript>().Agility > enemy.GetComponent<EnemyMush>().Agility) //���� ��ø�� �Ʊ���ø���� ������� �� ���ݽ���
        {
            OrderAttack = true;
        }
         else
        {
            OrderAttack = false;
        }
        //����ȿ�� ������ �г� ���̵� �ƿ�
        BlackPanel.DOFade(0, 2.0f);
        //���� �����ʿ�
        //�̵� ������ ������û�ʿ�.
        Invoke("characterstartmove", 3.0f);
    }
    void characterstartmove()
    {
        player.GetComponent<MushScript>().wait_2();
    }

    // Update is called once per frame
    void Update()
    {

        if(CameraRoundR == true)
        {
            MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 10), 0.5f);
            MainCamera.transform.DOLocalMoveZ(100, 0.5f);
            MainCamera.transform.DOLocalMoveZ(-12.5f, 0.5f);
            MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
 
        }

        if(CameraRoundL == true)
        {
            MainCamera.transform.DOLocalRotate(new Vector3(0, 0, -10), 0.5f);
            MainCamera.transform.DOLocalMoveZ(100, 0.5f);
            MainCamera.transform.DOLocalMoveZ(-12.5f, 0.5f);
            MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
        }


        if (time < 2.0f || isdead == true) 
        {
            time += Time.deltaTime;
        }
        else
        {
            if(skill == 1.0f) //��ų������ üũ 1.0 == ��ų�����Ϸ�
            {
                SkillIcon.SetActive(true);      //��ų �����Ϸ�� Ȱ��ȭ
            }
            else
            {
                SkillIcon.SetActive(false);     //�������� ��Ȱ��ȭ
            }

            if(OrderAttack == true)
            {

                if(SkillAttack == true)
                {
                    SkiilAttack();
                    Invoke("ResetDamageText", 1.5f);
                }
                else
                {
                    //player.transform.DOLocalMoveX(660, 0.1f);
                    enemy.transform.DOLocalMoveX(560, 0.1f);
                    PlayerAttack();
                    CameraRoundR = true;

                    Invoke("ResetDamageText", 0.7f);

                }
                OrderAttack = false;
                skill = skill + 0.25f; //��ų�������߰�
            }

            else if(OrderAttack == false)
            {
                EnemyAttack();
                CameraRoundL = true;
                Invoke("ResetDamageText", 1.0f);
                OrderAttack = true;
                skill = skill + 0.25f; //��ų�������߰�
            }
            time = 0;
        }


        Player_Hpbar.fillAmount = player.GetComponent<MushScript>().HP / Player_HPMax;
        Enemy_HPbar.fillAmount = enemy.GetComponent<EnemyMush>().HP / Enemy_HPMax;
        Skiil_Bar.fillAmount = skill;
        if(skill >= 1)
        {
            SkillIcon.SetActive(true);
        }


        if (enemy.GetComponent<EnemyMush>().HP <= 0)  //�� ���
        {
            //Invoke("StageClear", 2.0f);

        }


        if (player.GetComponent<MushScript>().HP <= 0) //�Ʊ� ĳ���� ���
        {
            isdead = true;
            GameOver();
        }

    }


    void StageClear()
    {
        ResetDamageText();
        time = 0;
        enemy.SetActive(false);
        isdead = true;
        Invoke("Clearsave", 5f);
        MissionClear.SetActive(true);
    }

    void Clearsave()
    {
        SaveData.GetComponent<SaveDataManager>()._ResearchPoint = SaveData.GetComponent<SaveDataManager>()._ResearchPoint + 3; //Ŭ���� ���� +3
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

    void PlayerAttack()
    {
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        player.GetComponent<MushScript>().attack();
        player.transform.DOLocalMoveX(200,0.3f).SetEase(Ease.OutBack); //�̵� �ӵ� ���� //�����̵� 0.3
        enemy.GetComponent<EnemyMush>().damage(); //�ǰݸ��
        enemy.GetComponent<EnemyMush>().HP = enemy.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(0,4);               

        Invoke("resetposition", 1.0f); // 1.0�� �ڿ� ����ġ ����    
        Invoke("CameraReset", 1f);
    }
    void resetposition()
    {
        player.transform.DOLocalMoveX(-660, 0.5f).SetEase(Ease.OutQuad);
        enemy.transform.DOLocalMoveX(860, 0.5f).SetEase(Ease.OutQuad);
    }

    void SkiilAttack()
    {
        //��ų ����Ʈ�ð� �ο��� ��ų ���� �Լ� �ۼ��ʿ�
        player.GetComponent<MushScript>().skill();
        enemy.GetComponent<EnemyMush>().damage();
        Skilleffect.SetActive(true);
        enemy.GetComponent<EnemyMush>().HP = enemy.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���
        isdead = true;

        Invoke("CameraReset", 1f);
    }

    void EnemyAttack()
    {
        Skilleffect.SetActive(false);
        player.GetComponent<MushScript>().damage();
        enemy.GetComponent<EnemyMush>().attack_1();
        player.GetComponent<MushScript>().HP = player.GetComponent<MushScript>().HP - enemyDamage; //�ǰݽ� ����� ����� �Ʊ� ĳ���� HP ����
        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        Invoke("CameraReset", 1f);
    }

    public void usedSkill()
    {
        skill = 0f;
        SkillAttack = true;
        SkillIcon.SetActive(false);
    }

    void CameraReset()
    {
       // MainCamera.transform.position = new Vector3(0.5f, 1, -13);
        //MainCamera.transform.eulerAngles = Vector3.forward * 0f;
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
