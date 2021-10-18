using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_GeneMemory : MonoBehaviour
{
    private bool ClickCheck = false;
    private int Clicker_Check = 0;      // 버튼 클릭 횟수로 판단 함. 시간 없어서 이렇게 만들어야함.
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
                    dialog.text = " 좌측의 기록 001 을 클릭해주세요.";

                    if(ClickCheck == true)
                    {
                        dialog.text = "우측의 플레이 버튼을 클릭하시면, 여태까지의 기록을 확인하실 수 있습니다.";
                    }
                }
                break;

        }

    }




    public void Clicker_Count_Num()
    {
        Clicker_Check += 1;
        Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
    }


    public void ClickChecker()
    {
        ClickCheck = true;
    }

}
