using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class For_Tutorial_Final : MonoBehaviour
{
    private int Clicker_Check = 0;      // ��ư Ŭ�� Ƚ���� �Ǵ� ��. �ð� ��� �̷��� ��������.
    public GameObject Checker;
    public Text dialog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (Clicker_Check)
        {
            case 0:
                {
                    dialog.text = "�̹� �Ʒ����� �������� �� ���� �������� �������̳���?";
                }
                break;

            case 1:
                {
                    dialog.text = "ETI ���� ������ ������ ������ ��ã�� ���� ������� ���� ȸ���Դϴ�.";
                }
                break;

            case 2:
                {
                    dialog.text = "���� ETI ���� ���ܿ��� ���� ū ������ �ٷ� ������ �����ϴ� �������Դϴ�.";
                }
                break;
            case 3:
                {
                    dialog.text = "�׷��� ������ �����ڴ��� �ϼž� �Ǵ� ������ ����ü�� �����ϰ�" +
                        " �����ϴ� ������� �¼� �ο��� �մϴ�.";
                }
                break;

            case 4:
                {
                    dialog.text = "�׷��� �̹� ������ ���⼭ �����ڽ��ϴ�.�����ϼ̽��ϴ�.";

                }
                break;

            case 5:
                {
                    dialog.text = "�ѹ��� Ŭ���Ͻ� ��� �� �������� ���� �����մϴ�.";

                }
                break;

            case 6:
                {
                    SceneManager.LoadScene("FirstScene");

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
