using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_inGameScene_Memory : MonoBehaviour
{

    private int Clicker_Check = 0;      // ��ư Ŭ�� Ƚ���� �Ǵ� ��. �ð� ��� �̷��� ��������.
    public Text dialog;
    public GameObject Arrow;
    public GameObject BlackScreen_1;
    public GameObject BlackScreen_2;
    public GameObject Clicker;


    // Update is called once per frame
    void Update()
    {

        switch (Clicker_Check)
        {
            case 1:
                {
                    dialog.text = "�Ʒ��� ���������� �Ϸ��߽��ϴ�.";
                }
                break;

            case 2:
                {
                    dialog.text = "���� �� ���丮�� ���� ������ ��� �����ҿ��� Ȯ���� �����մϴ�.";
                }
                break;

            case 3:
                {
                    Clicker.gameObject.SetActive(false);
                    BlackScreen_1.gameObject.SetActive(false);
                    BlackScreen_2.gameObject.SetActive(true);
                    Arrow.gameObject.SetActive(true);
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
