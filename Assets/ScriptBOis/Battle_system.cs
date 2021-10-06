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
        if(Input.GetKeyDown(KeyCode.A))     //���� ���ݽó����� �ִϸ��̼� Ȯ�ο� Ű�Է�
        {
            PlayerAttack();
        }

        if (Input.GetKeyDown(KeyCode.D))    //�Ʊ� ���� �ó����� �ִϸ��̼� Ȯ�ο� Ű�Է�
        {
            EnemyAttack();
        }
    }

    void PlayerAttack()
    {
        player.GetComponent<MushScript>().attack();
        enemy.GetComponent<EnemyCactus>().damage();
        enemy.GetComponent<EnemyCactus>().HP = enemy.GetComponent<EnemyCactus>().HP - playerDamage; //���ݽ� ����� ��� �� ���� ĳ���� HP ����
    }

    void EnemyAttack()
    {
        player.GetComponent<MushScript>().damage();
        enemy.GetComponent<EnemyCactus>().attack();
        player.GetComponent<MushScript>().HP = player.GetComponent<MushScript>().HP - enemyDamage; //�ǰݽ� ����� ����� �Ʊ� ĳ���� HP ����
    }

}
