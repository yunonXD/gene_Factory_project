using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private int Gene_Memory_Chacker = 0;        //유전자 마다 다른 인텔창 띄우기 위해 필요한 숫자 할당
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            Gene_Memory_noUnlock[0].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[0];
            Gene_Memory_Chacker = 1;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            Gene_Memory_noUnlock[1].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[1];
            Gene_Memory_Chacker = 2;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            Gene_Memory_noUnlock[2].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[2];
            Gene_Memory_Chacker = 3;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            Gene_Memory_noUnlock[3].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[3];
            Gene_Memory_Chacker = 4;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            Gene_Memory_noUnlock[4].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[4];
            Gene_Memory_Chacker = 5;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            Gene_Memory_noUnlock[5].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[5];
            Gene_Memory_Chacker = 6;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            Gene_Memory_noUnlock[6].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[6];
            Gene_Memory_Chacker = 7;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            Gene_Memory_noUnlock[7].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[7];
            Gene_Memory_Chacker = 8;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            Gene_Memory_noUnlock[8].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[8];
            Gene_Memory_Chacker = 9;
        }

    }


    public void Gene_Button_1()
    {
        if (Gene_Memory_noUnlock[0] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
                IntelPage.gameObject.SetActive(true);

            //스프라이트 변경
            Top_Title.text = "버섯이 많은날";
            Day_Log.text = "정보 기록 시일 2210.00.23";
            Cut_SceneText.text = "버섯이 옷을 버섯? 엌ㅋㅋㅋㅋㅋㅋㅋㅋ... 미안 ";

        }
    }
    public void Gene_Button_2()
    {
        if (Gene_Memory_noUnlock[1] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "토끼가 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.24";
            Cut_SceneText.text = "야 토껴! ";
        }
    }

    public void Gene_Button_3()
    {
        if (Gene_Memory_noUnlock[2] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "프랑이 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.25";
            Cut_SceneText.text = "프랑프랑프랑프랑 ";
        }
    }
    public void Gene_Button_4()
    {
        if (Gene_Memory_noUnlock[3] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "님프가 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.26";
            Cut_SceneText.text = "님? 프?? ";
        }
    }
    public void Gene_Button_5()
    {
        if (Gene_Memory_noUnlock[4] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "거신이 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.27";
            Cut_SceneText.text = "안녕 난 멘티코어야 ";
        }
    }
    public void Gene_Button_6()
    {
        if (Gene_Memory_noUnlock[5] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "이름 미정????";
            Day_Log.text = "정보 기록 시일 2210.00.28";
            Cut_SceneText.text = " 안녕 난 아직 미정이야 나에게 이름을 주세요 ";
        }
    }
    public void Gene_Button_7()
    {
        if (Gene_Memory_noUnlock[6] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "모디빅이 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.29";
            Cut_SceneText.text = " 모디빅? 디빅? De BIg?  ";
        }
    }
    public void Gene_Button_8()
    {
        if (Gene_Memory_noUnlock[7] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "탕드리드가 많은 날";
            Day_Log.text = "정보 기록 시일 2210.00.30";
            Cut_SceneText.text = " 탕! 악 그리드 ㅠㅠ ";
        }
    }
    public void Gene_Button_9()
    {
        if (Gene_Memory_noUnlock[8] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "이름 미정2";
            Day_Log.text = "정보 기록 시일 2210.00.31";
            Cut_SceneText.text = "저는 이름 강도에요. 이름을 주세요. ";
        }
    }






}
