using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1_0 : MonoBehaviour
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
    float time = 0;                 //�����Ӻ� �����̿� time ����
    private bool OrderAttack;      //true : �Ʊ���������, false : �� ��������   
    private float skill;
    public GameObject SkillIcon;
    private bool SkillAttack = false;       //��ų���ݿ���
    private bool isdead = false;
    public Camera MainCamera;
    public GameObject EnemyDamageText;
    public GameObject PlayerDamageText;
    public GameObject Skilleffect;
    public GameObject MissionFail;
    public GameObject MissionClear;
    public GameObject SaveData;
    public GameObject BattleBackGround;
    private bool CameraRoundR = false;
    private bool CameraRoundL = false;

    public float ShakeAmount;
    float ShakeTime;
    Vector3 initialPosition;

    public void VibrateForTime(float time)
    {
        ShakeTime = time;
    }



    // public GameObject boss;

    void Start()
    {
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

        initialPosition = new Vector3(-0.8f, 1f, -13f);
    }


    // Update is called once per frame
    void Update()
    {

        if (CameraRoundR == true)
        {
            MainCamera.transform.eulerAngles = MainCamera.transform.eulerAngles + Vector3.forward * 0.01f;
            //MainCamera.GetComponent<CameraShake>().AttackCameraShake(0.005f, 0.3f);
            //Debug.Log("ī�޶� ���� 0.08f, 0.3f");
        }

        if (CameraRoundL == true)
        {
            MainCamera.transform.eulerAngles = MainCamera.transform.eulerAngles + Vector3.forward * -0.01f;
            //MainCamera.GetComponent<CameraShake>().AttackCameraShake(0.005f, 0.3f);
            //Debug.Log("ī�޶� ���� 0.08f, 0.3f");
        }


        if (time < 2.0f || isdead == true)
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
                    SkiilAttack();
                    MainCamera.GetComponent<CameraShake>().AttackCameraShake(0.6f, 0.4f);
                    Debug.Log("ī�޶� ���� 0.05f, 0.3f");
                    Invoke("ResetDamageText", 1.5f);
                }
                else
                {
                    PlayerAttack();
                    CameraRoundR = true;
                    Invoke("ResetDamageText", 0.7f);

                }
                OrderAttack = false;
                skill = skill + 0.25f; //��ų�������߰�
            }

            else if (OrderAttack == false)
            {
                EnemyAttack();
                MainCamera.GetComponent<CameraShake>().AttackCameraShake(0.5f, 0.4f);
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
        if (skill >= 1)
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
        SceneManager.LoadScene("inGameScene_For_Memory");
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
        BattleBackGround.SetActive(true);
        MainCamera.transform.position = new Vector3(0.5f, 1, 0);
        //MainCamera.transform.eulerAngles = Vector3.forward * 10f;
        player.GetComponent<MushScript>().attack();
        enemy.GetComponent<EnemyMush>().damage();
        enemy.GetComponent<EnemyMush>().HP = enemy.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);

        Invoke("CameraReset", 1f);
    }

    void SkiilAttack()
    {
        // PlayerDamageText.GetComponent<DamageScript>().Reset();
        MainCamera.transform.position = new Vector3(0.5f, 1, 0);
        //MainCamera.transform.eulerAngles = Vector3.forward * 10f;
        BattleBackGround.SetActive(true);
        player.GetComponent<MushScript>().skill();
        enemy.GetComponent<EnemyMush>().damage();
        Skilleffect.SetActive(true);
        enemy.GetComponent<EnemyMush>().HP = enemy.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // ��ų���
        isdead = true;

        Invoke("SkilleffectOff", 1f);
        Invoke("CameraReset", 1f);
        Invoke("StageClear", 1.0f);
        

    }

    void EnemyAttack()
    {
        //EnemyDamageText.GetComponent<DamageScript>().Reset();
        BattleBackGround.SetActive(true);
        MainCamera.transform.position = new Vector3(0.5f, 1, 0);
        //MainCamera.transform.eulerAngles = Vector3.forward * -5f;
        Skilleffect.SetActive(false);
        player.GetComponent<MushScript>().damage();
        enemy.GetComponent<EnemyMush>().attack();
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
        MainCamera.transform.position = new Vector3(0.5f, 1, -13);
        MainCamera.transform.eulerAngles = Vector3.forward * 0f;
        BattleBackGround.SetActive(false);
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
