using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_BattleSelectScene : MonoBehaviour
{

    private int Clicker_Check = 0;      // 버튼 클릭 횟수로 판단 함. 시간 없어서 이렇게 만들어야함.
    public Text dialog;

    public GameObject BlockScreen_1;      //0-1 스테이지 가림막
    public GameObject Checker;            //화면 가리고 있는 체커
    public GameObject For_Story;          //스토리창
    public GameObject SelectVictim;       //전투선택창
    public GameObject Arrow_1;              //화살표(캐릭터를 향하여)
    public GameObject Arrow_2;              //화살표(시작 버튼을 향하여)
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
                    dialog.text = "이번 훈련은 실전을 대비한 모의훈련으로 관리자님이" +
                        " 전투에서 어떻게 대처하는지 파악하기 위한 훈련입니다 ";
                }
                break;

            case 2:
                {
                    Checker.gameObject.SetActive(false);
                    BlockScreen_1.gameObject.SetActive(true);
                    dialog.text = "스테이지 0-1을 선택하시고, 조금 전 해금하긴 실험체를 선택해 주세요.";
                    if(SelectVictim.gameObject.activeSelf == true)
                    {
                        Clicker_Check = 3;
                        Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
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
        Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
    }
}
