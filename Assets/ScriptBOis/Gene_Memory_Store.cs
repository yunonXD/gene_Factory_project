using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using FMODUnity;

public class Gene_Memory_Store : MonoBehaviour
{

    public GameObject PlayerData;
    public Button[] Gene_Memory_noUnlock;   //배열. 언락 시켜도 이름은 똑같음 
    public Sprite[] Gene_Unlock_Sprite;     //언락되어있는 스프라이트
    public Sprite[] Gene_BigIntel_Screen;   //기록 클릭하면 나오는 오른쪽에 큰 사진 스프라이트

    [Header("==텍스트==")]
    public Text Top_Title;                  //맨 위에 스토리 제목
    public Text Day_Log;                    //우측 정보 기록 시일
    public Text Cut_SceneText;                 //아래 설명
    public Text ForStoryText;               //스토리 진행시 나오는 대화창 텍스트

    public GameObject IntelPage;            //오른쪽에 사진있고 인텔 창 나오는거

    private int Gene_click_checker = 0;     //유전자 클릭한지 아닌지 확인하여 그에 맞는 스토리 출력


    // Update is called once per frame
    
    public void Gene_Button_1()
    {
        
        if (Gene_Memory_noUnlock[0] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "예상치 못한 기습 A-1";
            Day_Log.text = "정보 기록 시일 2210.00.23";
            Cut_SceneText.text = " ETI 제조 공단 사무실에 도착하고 본래 예정된 계획에 따라, 다음 훈련을 진행할 계획이었으나… ";

            Gene_click_checker = 1;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_2()
    {
        if (Gene_Memory_noUnlock[1] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            //스프라이트 변경
            Top_Title.text = "예상치 못한 기습 A-2";
            Day_Log.text = "정보 기록 시일 2210.00.24";
            Cut_SceneText.text = " …성공적으로 괴물들을 섬멸했고 공단 설비의 피해도 최소한으로 막아냈다. 상부에서도 이번 평가는 분명 긍정적일 것이다. ";

            Gene_click_checker = 2;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;

        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }


    
    }

    public void Gene_Button_3()
    {

        if (Gene_Memory_noUnlock[2] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "모의 훈련 B-1";
            Day_Log.text = "정보 기록 시일 2210.00.25";
            Cut_SceneText.text = " 적의 공격을 대비한 모의 훈련이 준비되어 있다. 평소대로 한다면 별거 없을것이다.";

            Gene_click_checker = 3;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_4()
    {
        
        if (Gene_Memory_noUnlock[3] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " 모의 훈련 B-2 ";
            Day_Log.text = "정보 기록 시일 2210.00.26";
            Cut_SceneText.text = " 적의 수치가 예상 밖이었지만 훌륭하게 통과했다. 이정도라면 문제 발생시 적절하게 대응할 수 있을 것이다. ";

            Gene_click_checker = 4;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_5()
    {

        if (Gene_Memory_noUnlock[4] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " 거점 수호 C-1 ";
            Day_Log.text = "정보 기록 시일 2210.00.27";
            Cut_SceneText.text = " 상부로부터 긴급 브리핑이 들어왔다. 간부급 개체의 출현으로 비상이 걸렸다. 만반의 준비를 해야 할 것이다. ";

            Gene_click_checker = 5;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_6()
    {

        if (Gene_Memory_noUnlock[5] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " 거점 수호 C-2 ";
            Day_Log.text = "정보 기록 시일 2210.00.28";
            Cut_SceneText.text = " 간부급 개체를 제압하였으나 오히려 위험에 빠질뻔했다. 녀석이 남긴 의미심장한 말이 아직도 기억에 남는다.";
            Gene_click_checker = 6;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_7()
    {

        if (Gene_Memory_noUnlock[6] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " 하이리스크 하이리턴 D-1";
            Day_Log.text = "정보 기록 시일 2210.00.29";
            Cut_SceneText.text = " 저번 간부급 개체 교전 지점에 아직 처리하지 못한 괴물이 발견된다는 소식을 전해들었다." +
                " 해당 지역에 무슨 현상이 발생했는지 직접 확인하러 가야한다. ";

            Gene_click_checker = 7;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_8()
    {

        if (Gene_Memory_noUnlock[7] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " 하이리스크 하이리턴 D-2 ";
            Day_Log.text = "정보 기록 시일 2210.00.30";
            Cut_SceneText.text = " 마리아가 의미심장한 말을 남겼다. 이런 상황에 낚시라니.  ";

            Gene_click_checker = 8;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_9()
    {

        if (Gene_Memory_noUnlock[8] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " 구조신호 E-1 ";
            Day_Log.text = "정보 기록 시일 2210.00.31";
            Cut_SceneText.text = " 숲 근처 ETI 제조 공단 부속 공장에서 긴급 구조신호가 들어왔다." +
                "해당 지역의 정찰 임무가 내려올 것이다. " +
                "생존자 수색, 구조, 탈환하는것이 주 목표이며 가능하다면 공장을 지켜내야한다." +
                "만약 생존자가 없을 경우 공장 내부의 데이터 확보가 중요시 될 것이다. ";

            Gene_click_checker = 9;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_10()
    {

        if (Gene_Memory_noUnlock[9] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " 구조신호 E-2 ";
            Day_Log.text = "정보 기록 시일 2210.01.00";
            Cut_SceneText.text = " 생존자의 증언을 바탕으로 녀석들의 목적을 알게되었다." +
                "적을 유인하여 공세에 들어갈 예정이며 분명 상상 이상으로 위험할 것 이다." +
                "또한 예상치 못한 인물을 만나게 될 것다.  ";

            Gene_click_checker = 10;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }

    public void Gene_Button_11()
    {

        if (Gene_Memory_noUnlock[10] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "물러날 곳은 없다 F-1";
            Day_Log.text = "정보 기록 시일 2210.01.01";
            Cut_SceneText.text = " 바프니크님은 이번 작전에 유인책으로 나를 지목했다. " +
                "매우 위험한 일이지만 그만큼 상부의 지원이 있을 예정이니 이를 토대로 적의 본대를 돌파해야한다. ";

            Gene_click_checker = 11;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }

    public void Gene_Button_12()
    {

        if (Gene_Memory_noUnlock[11] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "물러날 곳은 없다 F-2";
            Day_Log.text = "정보 기록 시일 2210.00.31";
            Cut_SceneText.text = " 마지막 전투가 끝나고 ETI에 평화가 찾아왔다." +
                " 많은 개체를 상대하였고 나는 생존하였다." +
                "언제나 다음 임무가 기다리고 있을 것이다.  ";

            Gene_click_checker = 12;
            Debug.Log("클리커 :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }





    public void GeneRecord_Checker()
    {

        switch (Gene_click_checker)
        {
            case 1:
                SceneManager.LoadScene("1_1_Before");
                break;

            case 2:
                SceneManager.LoadScene("1_1_After");
                break;

            case 3:
                SceneManager.LoadScene("1_2_Before");
                break;

            case 4:
                SceneManager.LoadScene("1_2_After");
                break;

            case 5:
                SceneManager.LoadScene("1_3_Before");
                break;

            case 6:
                SceneManager.LoadScene("1_3_After");
                break;

            case 7:
                SceneManager.LoadScene("2_1_Before");
                break;
            case 8:
                SceneManager.LoadScene("2_1_After");
                break;
            case 9:
                SceneManager.LoadScene("2_2_Before");
                break;

            case 10:
                SceneManager.LoadScene("2_2_After");
                break;
            case 11:
                SceneManager.LoadScene("2_3_Before");
                break;
            case 12:
                SceneManager.LoadScene("2_3_After");
                break;




        }


    }

    public void ResetMemorySelect()
    {
        PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
    }


    void Update()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            Gene_Memory_noUnlock[0].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[0];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            Gene_Memory_noUnlock[1].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[1];
        }

        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            Gene_Memory_noUnlock[2].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[2];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            Gene_Memory_noUnlock[3].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[3];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            Gene_Memory_noUnlock[4].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[4];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            Gene_Memory_noUnlock[5].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[5];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            Gene_Memory_noUnlock[6].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[6];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            Gene_Memory_noUnlock[7].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[7];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            Gene_Memory_noUnlock[8].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[8];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            Gene_Memory_noUnlock[9].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[9];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            Gene_Memory_noUnlock[10].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[10];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            Gene_Memory_noUnlock[11].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[11];
        }

    }



}
