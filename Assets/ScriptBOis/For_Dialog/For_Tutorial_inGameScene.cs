using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_inGameScene : MonoBehaviour
{

    private int Clicker_Check = 0;      // ��ư Ŭ�� Ƚ���� �Ǵ� ��. �ð� ��� �̷��� ��������.


    public Text Name;
    public Text dialog;

    public GameObject BlockScrean_1;      //���� �ڿ� �ִ� Ŭ�� ���� �ý���
    public GameObject BlockScrean_2;      //������ ������ ���� ����ũ

    public GameObject ArrowForGene;         //������ ���� ����Ű�� ȭ��ǥ

    public GameObject Checker;





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
                    Name.text = "???";
                    dialog.text = "���� ��ħ�Դϴ�. �����ڴ�.";

                }
                break;


            case 2:
                {
                    dialog.text = "ETI ���� ���� �繫�ǿ� ó�� ���� �ǵ�, ����� ��ʴϱ�?";
                }
                break;

            case 3:
                {
                    dialog.text = "�����ڴԲ��� ETI ���� ���ܿ� �����Ͻ� ���� ���� ���ϵ帳�ϴ�.";
                }
                break;

            case 4:
                {
                    Name.text = "������";
                    dialog.text = "�켱 �� �Ұ��� �帮�ڸ�, �� �̸��� �����ƶ�� �մϴ�." +
                        " �����ڴ��� ���� ���Դϴ�.;";
                }
                break;
            case 5:
                {
                    dialog.text = "������ �����ƶ�� �θ��ø� �˴ϴ�. �׷��� ������ �����ڴ����� �θ��ڽ��ϴ�.";

                }
                break;

            case 6:
                {
                    dialog.text = "���ú��� �����ڴ��� ETI ���� ������ ������ �����ϴ� �������Դϴ�.";

                }
                break;

            case 7:
                {
                    dialog.text = "�����ڴԲ��� �� ���� �� �س� �� ������ ������ �ǽŴٰ��?";

                }
                break;

            case 8:
                {
                    dialog.text = "�Ƚ��ϼ���, ETI ���� ������ ������ ������ ���� ������ ���� �����ڸ� �����մϴ�.";

                }
                break;

            case 9:
                {
                    dialog.text = "�׷� ������ ������ ���� ����ϼ�����, �����ڴ��� �и� ���������� �̴ϴ�.";

                }
                break;

            case 10:
                {
                    dialog.text = "�׸��� ���� �Ʒÿ����� �����ڴ��� �Ͽ� �ͼ����� �� �ֵ��� ���� ������ �帱 �����Դϴ�.";

                }
                break;

            case 11:
                {
                    Checker.gameObject.SetActive(false);
                    dialog.text = "��, �ϴ� ������ ������ ��ȯ�غ����� ����.";
                    BlockScrean_1.gameObject.SetActive(false);
                    BlockScrean_2.gameObject.SetActive(true);
                    ArrowForGene.gameObject.SetActive(true);
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

