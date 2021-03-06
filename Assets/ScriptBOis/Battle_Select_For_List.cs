using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using FMODUnity;

public class Battle_Select_For_List : MonoBehaviour
{


    //마지막 스테이지 클리어 유무 => 세이브 데이터 활용 필요
    private int StageSelect = 0;                //스테이지 선택 유무
    public GameObject PlayerData;

    public GameObject SelectVictim;             //스테이지 누르면 나오는 캐릭터 선택창
    public Button[] Stage;                      //스테이지 버튼
    public Toggle[] Gene_Select;                //캐릭터 선택 리스트

    public Sprite[] Gene_List_Sprite;           //리스트 언락되면 바뀔 스프라이트
    public Sprite[] Gene_Select_Sprite;           //리스트 선택되면 바뀔 스프라이트



    void Update()
    {

    }



    public void SelectBattle_Button()       //시작버튼 각 버튼마다 다른 스테이지 할당
    {
        switch (StageSelect)
        {
            case 100:           //이거 튜토리얼임!!!
                if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
                {
                    SceneManager.LoadScene("BattleScene1_0");
                }
                break;

            case 1:
                if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
                {
                    PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 = true;
                    //세이브 데이터 사용용도 -> 스토리 재생 후 해당 부분이 트루면 배틀로 이동. (_Gene_Between1 은 메모리에서 사용)
                    SceneManager.LoadScene("1_1_before");
                }
                break;

            case 2:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true
                    && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
                {
                    PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 = true;
                    SceneManager.LoadScene("1_2_before");
                }
                break;

            case 3:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true
                    && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
                {
                    PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 = true;
                    SceneManager.LoadScene("1_3_before");

                }
                break;


            case 4:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true
                    && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
                {
                    PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 = true;
                    SceneManager.LoadScene("2_1_before");

                }
                break;

            case 5:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true
                    && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
                {
                    PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 = true;
                    SceneManager.LoadScene("2_2_before");
                }
                break;

            case 6:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true
                    && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
                {
                    PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 = true;
                    SceneManager.LoadScene("2_3_before");
                }
                break;
        }

    }

    public void Stage1_0()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            PlayFModUI.instance.NbuttonClick();
            StageSelect = 100;
            SelectVictim.gameObject.SetActive(true);
        }
    }


    public void Stage1_1()
    {
        if (Stage[1] == true)           //4번 1_4 스테이지가 튜토리얼 확인 스테이지
        {
            
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true)
            {
                
                //PlayFModUI.instance.NbuttonClick();
                StageSelect = 1;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }

    public void Stage1_2()
    {
        if (Stage[2] == true)
        {
            Debug.Log("넘어옴");
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
            {
                Debug.Log("한번 더 넘어옴");
                //PlayFModUI.instance.NbuttonClick();
                StageSelect = 2;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }

    public void Stage1_3()
    {
        if (Stage[3] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
            {
                //PlayFModUI.instance.NbuttonClick();
                StageSelect = 3;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }


    public void Stage2_1()
    {
        if (Stage[4] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
            {
                //PlayFModUI.instance.NbuttonClick();
                StageSelect = 4;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }

    public void Stage2_2()
    {
        if (Stage[5] == true)
        {

            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
            {
                //PlayFModUI.instance.NbuttonClick();
                StageSelect = 5;
                SelectVictim.gameObject.SetActive(true);
            }

        }
        PlayFModUI.instance.NUnknownClick();
    }

    public void Stage2_3()
    {
        if (Stage[6] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
            {
                StageSelect = 6;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }


    public void Gene_List_ConRabbit()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            if (Gene_Select[0].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[0];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
            }
            else if (Gene_Select[0].isOn == false)
            {
                PlayFModUI.instance.NKeypadMouse();
                Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[0];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }
    public void Gene_List_Mush()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            if (Gene_Select[1].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true )
            {
                PlayFModUI.instance.NKeypadMouse();
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[1].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[1];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
            }
            else if(Gene_Select[1].isOn == false)
            {
                PlayFModUI.instance.NKeypadMouse();
                Gene_Select[1].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[1];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }



    public void Gene_List_Fran()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            if (Gene_Select[2].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[2].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[2];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
            }
            else if (Gene_Select[2].isOn == false)
            {
                PlayFModUI.instance.NKeypadMouse();
                Gene_Select[2].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[2];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Nymph()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            if (Gene_Select[3].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[3].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[3];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
            }
            else if (Gene_Select[3].isOn == false)
            {
                PlayFModUI.instance.NKeypadMouse();
                Gene_Select[3].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[3];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Manticore()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            if (Gene_Select[4].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[4].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[4];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
            }
            else if (Gene_Select[4].isOn == false)
            {
                PlayFModUI.instance.NKeypadMouse();
                Gene_Select[4].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[4];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Temp_1()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            PlayFModUI.instance.NUnknownClick();
            //    if (Gene_Select[5].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
            //    {
            //        PlayFModUI.instance.NUnknownClick();
            //        //전투창에서 유전자를 선택하면
            //        //그리고 해당 유전자가 활성화 되어있는 것이라면
            //        //Gene_Select[5].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[5];
            //        //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
            //    }
            //    else if (Gene_Select[5].isOn == false)
            //    {
            //        PlayFModUI.instance.NUnknownClick();
            //        //Gene_Select[5].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[5];
            //        //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
            //    }
            //}
            //else
            //{
            //    PlayFModUI.instance.NUnknownClick();
         }
     }

    public void Gene_List_Mobidic()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            if (Gene_Select[6].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[6].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[6];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
            }
            else if(Gene_Select[6].isOn == false)
            {
                PlayFModUI.instance.NKeypadMouse();
                Gene_Select[6].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[6];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }

    }

    public void Gene_List_TangGreece()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            if (Gene_Select[7].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[7].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[7];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
            }
            else if(Gene_Select[7].isOn == false)
            {
                PlayFModUI.instance.NKeypadMouse();
                Gene_Select[7].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[7];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Temp_2()
    {
        PlayFModUI.instance.NUnknownClick();

        //if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        //{
        //    if (Gene_Select[8].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        //    {
        //        PlaySoundEvent_keypad();
        //        //전투창에서 유전자를 선택하면
        //        //그리고 해당 유전자가 활성화 되어있는 것이라면
        //        Gene_Select[8].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[8];
        //        //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
        //        SelectGene = 9;
        //    }
        //    else if (Gene_Select[8].isOn == false)
        //    {
        //        Gene_Select[8].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[8];
        //        //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
        //        SelectGene = 0;
        //    }
        //}
        //else {
        //    PlaySoundEvent_Unkown(); 
        //}

    }
    public void Start()
    {
        PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 = false;
        //전투중 탈주했을 수 있으니 한번 예외체크

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[0];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            Gene_Select[1].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[1];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            Gene_Select[2].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[2];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            Gene_Select[3].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[3];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            Gene_Select[4].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[4];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            Gene_Select[5].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[5];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            Gene_Select[6].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[6];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            Gene_Select[7].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[7];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            Gene_Select[8].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[8];
        }


    }
}