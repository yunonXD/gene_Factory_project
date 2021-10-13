using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1_1 : MonoBehaviour
{

    public GameObject player;       //�÷��̾� ĳ����
    public GameObject enemy;        //�� ĳ���� ���� �ӽ�
    private int enemyDamage;        //���� �Ʊ����� �ִ� ���ط�
    private int playerDamage;       //�Ʊ��� ������ �ִ� ���ط�
    public Image Player_Hpbar;      //�Ʊ�ĳ���� HP�� ����ȭ
    public Image Enemy_HPbar;       //����ĳ���� Hp�� ����ȭ
    private float Player_HPMax;     //�Ʊ�ĳ���� Hp�� ����� ó���� ����
    private float Enemy_HPMax;      //����ĳ���� Hp�� ����� ó���� ����
    float time = 0;                 //�����Ӻ� �����̿� time ����
    private bool OrderAttack;      //true : �Ʊ���������, false : �� ��������   
    public GameObject MissionFail;      
    public GameObject MissionClear;
    public GameObject SaveData;

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


    }


    // Update is called once per frame
    void Update()
    {

        if (time < 2.0f)
        {
            time += Time.deltaTime;

        }
        else
        {
            if(OrderAttack == true)
            {
                PlayerAttack();
                OrderAttack = false;
            }

            else if(OrderAttack == false)
            {
                EnemyAttack();
                OrderAttack = true;
            }
            time = 0;
        }


        Player_Hpbar.fillAmount = player.GetComponent<MushScript>().HP / Player_HPMax;
        Enemy_HPbar.fillAmount = enemy.GetComponent<EnemyMush>().HP / Enemy_HPMax;

        if (enemy.GetComponent<EnemyMush>().HP <= 0)  //�� ���
        {
            StageClear();
        }


        if (player.GetComponent<MushScript>().HP <= 0) //�Ʊ� ĳ���� ���
        {
            GameOver();
        }

    }


    void StageClear()
    {
        if (time < 1.0f)
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0;
            enemy.SetActive(false);
            Invoke("Clearsave", 5f);
        }
        time += Time.deltaTime;

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

        }
        time += Time.deltaTime;
        MissionFail.SetActive(true);
    }

    void PlayerAttack()
    {
        player.GetComponent<MushScript>().attack();
        enemy.GetComponent<EnemyMush>().damage();
        enemy.GetComponent<EnemyMush>().HP = enemy.GetComponent<EnemyMush>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
    }

    void EnemyAttack()
    {
        player.GetComponent<MushScript>().damage();
        enemy.GetComponent<EnemyMush>().attack();
        player.GetComponent<MushScript>().HP = player.GetComponent<MushScript>().HP - enemyDamage; //�ǰݽ� ����� ����� �Ʊ� ĳ���� HP ����
    }

}
