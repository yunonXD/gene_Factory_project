using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using FMODUnity;

public class Button_Editor : MonoBehaviour{


    public GameObject Optionpage;
    public GameObject PlayerData;
    private bool isPause = false;


    public void SceneChange_inGame(){       //인게임씬
        SceneManager.LoadScene("inGameScene");
    }

    //public void SceneChange_gene(){         //유전자 지도창
    //    SceneManager.LoadScene("geneMap");
    //}

   // public void SceneChange_BattleSelect(){ //배틀 선택창
   //     SceneManager.LoadScene("BattleSelectScene");
   // }

    public void SceneChange_BattleStart()   //배틀 시작창
    { //배틀 선택창
        SceneManager.LoadScene("BattleScene");
    }

    public void SceneChange_Title()         //타이틀창
    {
        SceneManager.LoadScene("FirstScene");
    }

    //public void SceneChange_Memor_gene()    //기억 저장소
    //{
    //    SceneManager.LoadScene("RecordMemoryScene");
    //}



    public void OptionSetActive()           //옵션창(처음은 false - 비활성화
    {
        PlayFModUI.instance.NbuttonClick();
        Optionpage.SetActive(false);
        isPause = false;
    }

    public void OptionSetActiveON()
    {
        PlayFModUI.instance.NbuttonClick();
        Optionpage.SetActive(true);
        isPause = true;
    }

    public void OnApplicationQuit(){        //게임종료
        Application.Quit();
    }


    public void Set_NewGame()
    {
        PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 = false;
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = 0;
    }


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))       //ESC 버튼으로 옵션창 제어
        {
            if (isPause == false)
            {
                PlayFModUI.instance.NbuttonClick();
                Optionpage.SetActive(true);
                isPause = true;
                return;
            }

            if(isPause == true)
            {
                PlayFModUI.instance.NbuttonClick();
                Optionpage.SetActive(false);
                isPause = false;
                return;
            }
        }


    }


}
