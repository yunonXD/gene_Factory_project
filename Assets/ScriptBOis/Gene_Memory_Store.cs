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

    void Start()
    {
        
    }

    // Update is called once per frame
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


    public void Gene_Button_1()
    {
        
        if (Gene_Memory_noUnlock[0] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "토끼가 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.24";
            Cut_SceneText.text = "야 토껴! ";

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
            Top_Title.text = "버섯이 많은날";
            Day_Log.text = "정보 기록 시일 2210.00.23";

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

            Top_Title.text = "프랑이 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.25";
            Cut_SceneText.text = "프랑프랑프랑프랑 ";

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

            Top_Title.text = "님프가 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.26";
            Cut_SceneText.text = "님? 프?? ";

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

            Top_Title.text = "거신이 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.27";
            Cut_SceneText.text = "안녕 난 멘티코어야 ";

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

            Top_Title.text = "이름 미정????";
            Day_Log.text = "정보 기록 시일 2210.00.28";
            Cut_SceneText.text = " 안녕 난 아직 미정이야 나에게 이름을 주세요 ";
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

            Top_Title.text = "모디빅이 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.29";
            Cut_SceneText.text = " 모디빅? 디빅? De BIg?  ";

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

            Top_Title.text = "탕드리드가 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.30";
            Cut_SceneText.text = " 탕! 악 그리드 ㅠㅠ ";

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

            Top_Title.text = "이름 미정2";
            Day_Log.text = "정보 기록 시일 2210.00.31";
            Cut_SceneText.text = "저는 이름 강도에요. 이름을 주세요. ";

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

            Top_Title.text = "이름 미정2";
            Day_Log.text = "정보 기록 시일 2210.00.31";
            Cut_SceneText.text = "저는 이름 강도에요. 이름을 주세요. ";

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

            Top_Title.text = "이름 미정2";
            Day_Log.text = "정보 기록 시일 2210.00.31";
            Cut_SceneText.text = "저는 이름 강도에요. 이름을 주세요. ";

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

            Top_Title.text = "이름 미정2";
            Day_Log.text = "정보 기록 시일 2210.00.31";
            Cut_SceneText.text = "저는 이름 강도에요. 이름을 주세요. ";

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

}
