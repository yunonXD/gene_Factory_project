using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_GeneMemory : MonoBehaviour
{
    private bool ClickCheck = false;
    private int Clicker_Check = 0;      // ��ư Ŭ�� Ƚ���� �Ǵ� ��. �ð� ��� �̷��� ��������.
    public Text dialog;
    public GameObject Checker;


    void Start()
    {
        
    }


    void Update()
    {
        switch (Clicker_Check)
        {
            case 0:
                {
                    Checker.gameObject.SetActive(false);
                    dialog.text = " ������ ��� 001 �� Ŭ�����ּ���.";

                    if(ClickCheck == true)
                    {
                        dialog.text = "������ �÷��� ��ư�� Ŭ���Ͻø�, ���±����� ����� Ȯ���Ͻ� �� �ֽ��ϴ�.";
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


    public void ClickChecker()
    {
        ClickCheck = true;
    }

}
