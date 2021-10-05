using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Editor : MonoBehaviour{

    public GameObject Optionpage;
    public GameObject PlayerData;

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
        Debug.Log("옵션창 테스트");
        Optionpage.SetActive(false);
    }

    public void OnApplicationQuit(){        //게임종료(유니티에선 해치웠나? 디버그만 나옴
        Application.Quit();
        Debug.Log("해치웠나?");
    }



    void Update()       //ESC 누를시 옵션창 활성화 / 비활성화
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Optionpage.SetActive(true);
        }
    }
}
