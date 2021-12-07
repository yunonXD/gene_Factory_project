using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class B_Select_Tutorial : MonoBehaviour
{

    public GameObject PlayerData;           //세이브데이터
    public GameObject Tutorial;             //튜토리얼띄워줄부모객체
    public GameObject Dialogue;             //튜토리얼띄워줄부모객체
    public GameObject Indicator;            //화살표
    public GameObject ScreenBlack;
    public GameObject ScreenBlack_2;
    public GameObject ScreenBlack_3;
    public GameObject ScreenBlack_4;

    public Button[] Stage;

    public Text C_name;
    public Text C_Dialogue;

    private int Yeeter = 0;               //다이어로그 읽어올 세이브파일 받아올 인트값

    private GameObject Option;


    void Start()
    {
        Option = GameObject.Find("GameManager");
        Tutorial.gameObject.SetActive(true);

    }

    void Update()
    {
        BattleSTutorial();
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;
    }

    void BattleSTutorial()
    {
        //튜토리얼 진행을 위한 _Gene_Between3 판별
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {

            //esc 작동 스크립트 DEAD
            Option.GetComponent<Button_Editor>().enabled = false;

            for (int i = 0; i < 6; i++)
            {
                Stage[i].GetComponent<Button>().interactable = false;
            }


        }
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == true)
        {
            //esc 작동 스크립트 Alive
            Option.GetComponent<Button_Editor>().enabled = true;
            Tutorial.gameObject.SetActive(false);
            for (int i = 0; i < 6; i++)
            {
                Stage[i].GetComponent<Button>().interactable = true;
            }
            Destroy(this);      //안쓰면 삭제
        }
    }


    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "포인트이만큼 세이브");
    }


    public void BattleSelectTutorial()
    {
        Yeeter = Yeeter + 1;
        PointSaver();
        switch (Yeeter)
        {

            case 25:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("어서오십쇼 관리자님.", 1);

                ScreenBlack_3.gameObject.SetActive(true);   //0-1 막기
                ScreenBlack.gameObject.SetActive(true);     //다이어로그

                break;

            case 26:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("이번 훈련은 실전을 대비한 모의훈련으로 관리자님이 " +
                    "전투에서 어떻게 대처하는지 파악하기 위한 훈련입니다.", 1);
                break;

            case 27:

                ScreenBlack_2.gameObject.SetActive(true);
                ScreenBlack_3.gameObject.SetActive(false);
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("스테이지 0 - 1 을 선택하시고, 조금 전 해금하신 실험체를 선택해주세요.", 1);




                break;

            case 28:
                ScreenBlack.gameObject.SetActive(false);
                Dialogue.gameObject.SetActive(false);
                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(-441f, 146f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -30f);

                break;


            case 29:

                ScreenBlack_4.gameObject.SetActive(true);
                ScreenBlack_2.gameObject.SetActive(false);
                ScreenBlack.gameObject.SetActive(false);

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(528f, -355f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -30f);


                break;









        }


    }



}
