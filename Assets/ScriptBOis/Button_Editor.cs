using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Editor : MonoBehaviour{

    public GameObject Optionpage;
    public GameObject PlayerData;
    public GameObject SelectVictim;             //스테이지 누르면 나오는 캐릭터 선택창
    public Button[] Stage;                      //스테이지 버튼


    //마지막 스테이지 클리어 유무 => 세이브 데이터 활용 필요

    private int StageSelect = 0;

    public void SceneChange_inGame(){       //인게임씬

        SceneManager.LoadScene("inGameScene");
    }

    public void SceneChange_gene(){         //유전자 지도창
        SceneManager.LoadScene("geneMap");
    }

    public void SceneChange_BattleSelect(){ //배틀 선택창
        SceneManager.LoadScene("BattleSelectScene");
    }

    public void SceneChange_BattleStart()   //배틀 시작창
    { //배틀 선택창
        SceneManager.LoadScene("BattleScene");
    }

    public void SceneChange_Title()         //타이틀창
    {
        SceneManager.LoadScene("IntroScene");
    }




    public void SelectBattle_Button()       //시작버튼 각 버튼마다 다른 스테이지 할당
    {
        switch (StageSelect)
        {
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
        if (Stage[1]==true)
        {
            StageSelect = 2;
            SelectVictim.gameObject.SetActive(true);
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
            StageSelect = 3;
            SelectVictim.gameObject.SetActive(true);
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
            StageSelect = 4;
            SelectVictim.gameObject.SetActive(true);
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
            StageSelect = 5;
            SelectVictim.gameObject.SetActive(true);
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
            StageSelect = 6;
            SelectVictim.gameObject.SetActive(true);
        }

        else
        {
            StageSelect = 0;
        }
    }

    public void Stage2_3()
    {
        if (Stage[6] == true)
        {
            StageSelect = 7;
            SelectVictim.gameObject.SetActive(true);
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
            StageSelect = 8;
            SelectVictim.gameObject.SetActive(true);
        }

        else
        {
            StageSelect = 0;
        }
    }







    public void SceneChange_Stage1_1()         //전투화면 1_1창 
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            SceneManager.LoadScene("BattleScene1_1");
        }
        else
        {
            Debug.Log("스테이지 입장 조건을 만족하지 못했습니다.");
        }
    }

    public void SceneChange_Stage1_2()         //전투화면 1_2창 
    {
       // SceneManager.LoadScene("BattleScene1_2");
    }

    public void SceneChange_Stage1_3()        //전투화면 1_3창 
    {
       // SceneManager.LoadScene("BattleScene1_3");
    }

    public void SceneChange_Stage1_4()        //전투화면 1_4창 
    {
        // SceneManager.LoadScene("BattleScene1_4");
    }

    public void SceneChange_Stage2_1()        //전투화면 2_1창 
    {
        // SceneManager.LoadScene("BattleScene2_1");
    }
    public void SceneChange_Stage2_2()        //전투화면 2_2창 
    {
        // SceneManager.LoadScene("BattleScene2_2");
    }
    public void SceneChange_Stage2_3()        //전투화면 2_3창 
    {
        // SceneManager.LoadScene("BattleScene2_3");
    }
    public void SceneChange_Stage2_4()        //전투화면 2_4창 
    {
        // SceneManager.LoadScene("BattleScene2_4");
    }



    public void OptionSetActive()           //옵션창(처음은 false - 비활성화
    {
        //Debug.Log("옵션창 테스트");
        Optionpage.SetActive(false);
    }

    public void OnApplicationQuit(){        //게임종료(유니티에선 해치웠나? 디버그만 나옴
        Application.Quit();
        //Debug.Log("해치웠나?");
    }



    void Update()       //ESC 누를시 옵션창 활성화 / 비활성화
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Optionpage.SetActive(true);
        }
    }
}
