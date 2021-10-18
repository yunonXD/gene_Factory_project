using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_inGameScene_Memory : MonoBehaviour
{

    private int Clicker_Check = 0;      // 버튼 클릭 횟수로 판단 함. 시간 없어서 이렇게 만들어야함.
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
                    dialog.text = "훈련은 성공적으로 완료했습니다.";
                }
                break;

            case 2:
                {
                    dialog.text = "전투 후 스토리에 대한 정보는 기록 보관소에서 확인이 가능합니다.";
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
        Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
    }

}
