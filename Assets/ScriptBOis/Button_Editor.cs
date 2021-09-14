using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Editor : MonoBehaviour{

    public GameObject Optionpage;

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
