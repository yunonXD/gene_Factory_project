using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_system : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    private int enemyDamage;
    private int playerDamage;
    public Image Player_Hpbar;
    public Image Enemy_HPbar;
    private float Player_HPMax;
    private float Enemy_HPMax;
    float time = 0;
    public float _fadeTime = 3f;

    // public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
        enemyDamage = enemy.GetComponent<EnemyCactus>().Power - player.GetComponent<MushScript>().Defense;
        playerDamage = player.GetComponent<MushScript>().Power - enemy.GetComponent<EnemyCactus>().Defense;
        Player_HPMax = player.GetComponent<MushScript>().HP;
        Enemy_HPMax = enemy.GetComponent<EnemyCactus>().HP;
    }


    // Update is called once per frame
    void Update()
    {                               
        if(Input.GetKeyDown(KeyCode.A))     //적군 공격시나리오 애니메이션 확인용 키입력
        {
            PlayerAttack();
        }

        if (Input.GetKeyDown(KeyCode.D))    //아군 공격 시나리오 애니메이션 확인용 키입력
        {
            EnemyAttack();
        }

        Player_Hpbar.fillAmount = player.GetComponent<MushScript>().HP / Player_HPMax;
        Enemy_HPbar.fillAmount = enemy.GetComponent<EnemyCactus>().HP / Enemy_HPMax;

        if(enemy.GetComponent<EnemyCactus>().HP <= 0)
        {
            if (time < 5.0f)
            {
                Debug.Log("페이드아웃중");
                //enemy.GetComponent<MeshRenderer>().color = new Color(0, 0, 0, 1 - time / _fadeTime);
                enemy.GetComponent<MeshRenderer>().material.color = Color.black;
                Debug.Log("time : "+ time);
                time += Time.deltaTime;

            }
            else
            {
                time = 0;
                enemy.SetActive(false);

            }
            //time += Time.deltaTime;
        }

       // if(boss.GetComponent<BossMush)().HP <= 0)
       // {
            //보스 클리어
       // }

        if(player.GetComponent<MushScript>().HP <= 0)
        {
            GameOver();
        }

    }

    void StageClear()
    {
        
            if (time < _fadeTime)
            {
                //enemy.GetComponent<MeshRenderer>().color = new Color(0, 0, 0, 1 - time / _fadeTime);
                enemy.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0, 1 - time / _fadeTime);
            }
            else
            {
                time = 0;
                enemy.SetActive(false);
          
            }
            time += Time.deltaTime;

        

    }
    void GameOver()
    {

        player.SetActive(false);
    }

    void PlayerAttack()
    {
        player.GetComponent<MushScript>().attack();
        enemy.GetComponent<EnemyCactus>().damage();
        enemy.GetComponent<EnemyCactus>().HP = enemy.GetComponent<EnemyCactus>().HP - playerDamage; //공격시 대미지 계산 후 적군 캐릭터 HP 감소
    }

    void EnemyAttack()
    {
        player.GetComponent<MushScript>().damage();
        enemy.GetComponent<EnemyCactus>().attack();
        player.GetComponent<MushScript>().HP = player.GetComponent<MushScript>().HP - enemyDamage; //피격시 대미지 계산후 아군 캐릭터 HP 감소
    }

}
