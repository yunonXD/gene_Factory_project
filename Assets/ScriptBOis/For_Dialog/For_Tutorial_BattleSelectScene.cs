using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_BattleSelectScene : MonoBehaviour
{

    private int Clicker_Check = 0;      // ��ư Ŭ�� Ƚ���� �Ǵ� ��. �ð� ��� �̷��� ��������.
    public Text dialog;

    public GameObject BlockScreen_1;      //0-1 �������� ������
    public GameObject Checker;            //ȭ�� ������ �ִ� üĿ
    public GameObject For_Story;          //���丮â
    public GameObject SelectVictim;       //��������â
    public GameObject Arrow_1;              //ȭ��ǥ(ĳ���͸� ���Ͽ�)
    public GameObject Arrow_2;              //ȭ��ǥ(���� ��ư�� ���Ͽ�)
    public Toggle Mush;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (Clicker_Check)
        {
            case 1:
                {
                    dialog.text = "�̹� �Ʒ��� ������ ����� �����Ʒ����� �����ڴ���" +
                        " �������� ��� ��ó�ϴ��� �ľ��ϱ� ���� �Ʒ��Դϴ� ";
                }
                break;

            case 2:
                {
                    Checker.gameObject.SetActive(false);
                    BlockScreen_1.gameObject.SetActive(true);
                    dialog.text = "�������� 0-1�� �����Ͻð�, ���� �� �ر��ϱ� ����ü�� ������ �ּ���.";
                    if(SelectVictim.gameObject.activeSelf == true)
                    {
                        Clicker_Check = 3;
                        Debug.Log("Ŭ��Ŀ �۵��ϴ��� Ȯ���� : " + Clicker_Check);
                    }
                }
                break;

            case 3:
                {
                    For_Story.gameObject.SetActive(false);
                    Arrow_1.gameObject.SetActive(true);
                    if (Mush.isOn)
                    {
                        Arrow_1.gameObject.SetActive(false);
                        Arrow_2.gameObject.SetActive(true);
                    }

                }
                break;



        }
    }


    public void Clicker_Count_Num()
    {
        Clicker_Check += 1;
        Debug.Log("Ŭ��Ŀ �۵��ϴ��� Ȯ���� : " + Clicker_Check);
    }
}
