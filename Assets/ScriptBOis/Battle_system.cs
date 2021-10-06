using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_system : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    private int enemyDamage;
    private int playerDamage;

    // public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
        enemyDamage = enemy.GetComponent<EnemyCactus>().Power - player.GetComponent<MushScript>().Defense;
        playerDamage = player.GetComponent<MushScript>().Power - enemy.GetComponent<EnemyCactus>().Defense;
        
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
