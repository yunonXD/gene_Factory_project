using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1_1 : MonoBehaviour
{

    public GameObject player;       //플레이어 캐릭터
    public GameObject enemy;        //적 캐릭터 붉은 머시
    private int enemyDamage;        //적이 아군에게 주는 피해량
    private int playerDamage;       //아군이 적에게 주는 피해량
    public Image Player_Hpbar;      //아군캐릭터 HP바 동기화
    public Image Enemy_HPbar;       //적군캐릭터 Hp바 동기화
    private float Player_HPMax;     //아군캐릭터 Hp바 백분율 처리용 변수
    private float Enemy_HPMax;      //적군캐릭터 Hp바 백분율 처리용 변수
    float time = 0;                 //프레임별 딜레이용 time 변수
    private bool OrderAttack;      //true : 아군공격차례, false : 적 공격차례   
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

        if (player.GetComponent<MushScript>().Agility > enemy.GetComponent<EnemyMush>().Agility) //적의 민첩이 아군민첩보다 높을경우 적 공격시전
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

        if (enemy.GetComponent<EnemyMush>().HP <= 0)  //적 사망
        {
            StageClear();
        }


        if (player.GetComponent<MushScript>().HP <= 0) //아군 캐릭터 사망
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
        SaveData.GetComponent<SaveDataManager>()._ResearchPoint = SaveData.GetComponent<SaveDataManager>()._ResearchPoint + 3; //클리어 보상 +3
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
        enemy.GetComponent<EnemyMush>().HP = enemy.GetComponent<EnemyMush>().HP - playerDamage; //공격시 대미지 계산 후 적군 캐릭터 HP 감소
    }

    void EnemyAttack()
    {
        player.GetComponent<MushScript>().damage();
        enemy.GetComponent<EnemyMush>().attack();
        player.GetComponent<MushScript>().HP = player.GetComponent<MushScript>().HP - enemyDamage; //피격시 대미지 계산후 아군 캐릭터 HP 감소
    }

}
