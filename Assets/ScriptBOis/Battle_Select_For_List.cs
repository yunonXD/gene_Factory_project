using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Battle_Select_For_List : MonoBehaviour
{
    //마지막 스테이지 클리어 유무 => 세이브 데이터 활용 필요
    private int StageSelect = 0;                //스테이지 선택 유무
    private int SelectGene = 0;                 //유전자 선택 유무(전투창과 연동 필요)
    public GameObject PlayerData;

    public GameObject SelectVictim;             //스테이지 누르면 나오는 캐릭터 선택창
    public Button[] Stage;                      //스테이지 버튼
    public Toggle[] Gene_Select;                //캐릭터 선택 리스트
    public Sprite[] Gene_List_Sprite;           //리스트 언락되면 바뀔 스프라이트
    public Sprite[] Gene_Select_Sprite;           //리스트 선택되면 바뀔 스프라이트



    void Start()
    {
        //해당 씬에 들어올때 한먼만 체크
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[0];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
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


    void Update()
    {


    }


    public void SelectBattle_Button()       //시작버튼 각 버튼마다 다른 스테이지 할당
    {
        switch (StageSelect)
        {


            case 100:           //이거 튜토리얼임!!!
                if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
                {
                    SceneManager.LoadScene("BattleScene1_0_For_Tutorial");
                }
                break;

            case 1:
                if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
                {
                    SceneManager.LoadScene("BattleScene1_1");
                }
                break;

            case 2:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
                {
                    SceneManager.LoadScene("BattleScene1_2");
                }
                break;

            case 3:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
                {
                    SceneManager.LoadScene("BattleScene1_3");

                }
                break;

            case 4:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true)
                {
                    SceneManager.LoadScene("BattleScene1_4");

                }
                break;

            case 5:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
                {
                    SceneManager.LoadScene("BattleScene2_1");

                }
                break;

            case 6:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
                {
                    SceneManager.LoadScene("BattleScene2_2");
                }
                break;

            case 7:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
                {
                    SceneManager.LoadScene("BattleScene2_3");
                }
                break;

            case 8:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_4 == true)
                {
                    SceneManager.LoadScene("BattleScene2_4");
                }
                break;


        }

    }

    public void Stage1_0()
    {
        if (Stage[0] == true)
        {
            StageSelect = 100;
            SelectVictim.gameObject.SetActive(true);
        }

        else
        {
            StageSelect = 0;
        }
    }


    public void Stage1_1()
    {
        if (Stage[0] == true)
        {
            StageSelect = 1;
            SelectVictim.gameObject.SetActive(true);
        }

        else
        {
            StageSelect = 0;
        }
    }

    public void Stage1_2()
    {
        if (Stage[1] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
            {
                StageSelect = 2;
                SelectVictim.gameObject.SetActive(true);
            }
        }

        else
        {
            StageSelect = 0;
        }
    }

    public void Stage1_3()
    {
        if (Stage[2] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
            {
                StageSelect = 3;
                SelectVictim.gameObject.SetActive(true);
            }
        }

        else
        {
            StageSelect = 0;
        }
    }

    public void Stage1_4()
    {
        if (Stage[3] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true)
            {
                StageSelect = 4;
                SelectVictim.gameObject.SetActive(true);
            }
        }

        else
        {
            StageSelect = 0;
        }
    }

    public void Stage2_1()
    {
        if (Stage[4] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
            {
                StageSelect = 5;
                SelectVictim.gameObject.SetActive(true);
            }
        }

        else
        {
            StageSelect = 0;
        }
    }

    public void Stage2_2()
    {
        if (Stage[5] == true)
        {

            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
            {
                StageSelect = 6;
                SelectVictim.gameObject.SetActive(true);
            }

            else
            {
                StageSelect = 0;
            }
        }
    }

    public void Stage2_3()
    {
        if (Stage[6] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
            {
                StageSelect = 7;
                SelectVictim.gameObject.SetActive(true);
            }
        }

        else
        {
            StageSelect = 0;
        }
    }

    public void Stage2_4()
    {
        if (Stage[7] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_4 == true)
            {
                StageSelect = 8;
                SelectVictim.gameObject.SetActive(true);
            }
        }

        else
        {
            StageSelect = 0;
        }
    }


    public void Gene_List_Mush()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            if (Gene_Select[0].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true )
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[0];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 1;
            }
            else if(Gene_Select[0].isOn == false)
            {
                Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[0];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else
        {

        }
    }

    public void Gene_List_ConRabbit()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            if (Gene_Select[1].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[1].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[1];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 2;
            }
            else if (Gene_Select[1].isOn == false)
            {
                Gene_Select[1].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[1];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else { }
    }

    public void Gene_List_Fran()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            if (Gene_Select[2].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[2].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[2];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 3;
            }
            else if (Gene_Select[2].isOn == false)
            {
                Gene_Select[2].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[2];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else
        {

        }
    }

    public void Gene_List_Nymph()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            if (Gene_Select[3].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[3].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[3];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 4;
            }
            else if (Gene_Select[3].isOn == false)
            {
                Gene_Select[3].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[3];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else
        {

        }
    }

    public void Gene_List_Manticore()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            if (Gene_Select[4].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[4].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[4];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 5;
            }
            else if (Gene_Select[4].isOn == false)
            {
                Gene_Select[4].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[4];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else
        {

        }
    }

    public void Gene_List_Temp_1()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            if (Gene_Select[5].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[5].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[5];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 6;
            }
            else if (Gene_Select[5].isOn == false)
            {
                Gene_Select[5].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[5];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else
        {

        }
    }

    public void Gene_List_Mobidic()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            if (Gene_Select[6].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[6].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[6];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 7;
            }
            else if(Gene_Select[6].isOn == false)
            {
                Gene_Select[6].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[6];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else
        {

        }

    }

    public void Gene_List_TangGreece()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            if (Gene_Select[7].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[7].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[7];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 8;
            }
            else if(Gene_Select[7].isOn == false)
            {
                Gene_Select[7].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[7];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else
        {

        }
    }

    public void Gene_List_Temp_2()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            if (Gene_Select[8].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
            {
                //전투창에서 유전자를 선택하면
                //그리고 해당 유전자가 활성화 되어있는 것이라면
                Gene_Select[8].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[8];
                //선택되었음. 그리고 해당 유전자 스프라이트 (선택된 스프라이트) 를 교체함
                SelectGene = 9;
            }
            else if (Gene_Select[8].isOn == false)
            {
                Gene_Select[8].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[8];
                //선택을 해제할 경우 스프라이트를 원래대로 되돌림.
                SelectGene = 0;
            }
        }
        else { }
        }

    }