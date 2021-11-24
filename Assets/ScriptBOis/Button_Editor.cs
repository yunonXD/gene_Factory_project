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
        SceneManager.LoadScene("FirstScene");
    }

    public void SceneChange_Memor_gene()    //기억 저장소
    {
        SceneManager.LoadScene("RecordMemoryScene");
    }



    public void OptionSetActive()           //옵션창(처음은 false - 비활성화
    {
        //Debug.Log("옵션창 테스트");
        Optionpage.SetActive(false);
        isPause = false;
    }




    public void OnApplicationQuit(){        //게임종료
        Application.Quit();
    }


    /// <summary>
    /// 여긴 튜토리얼용 버튼임!!! 시전 종료후 삭제할 수 있으니 주의할것!
    /// </summary>


    public void SceneChange_inGameScene_Tutorial()
    {
        SceneManager.LoadScene("inGameScene_FOR_Tutorial");
    }

    public void SceneChange_geneMap_Tutorial()
    {
        SceneManager.LoadScene("geneMap_Tutorial");
    }

    public void SceneChange_inGameScene_Tutorial_FORMOVE()
    {
        SceneManager.LoadScene("inGameScene_Tutorial_FORMOVE");
    }

    public void SceneChange_BattleSelect_Tutorial()
    {
        SceneManager.LoadScene("BattleSelectScene_Tutorial");
    }

    public void SceneChange_Battle_1_0_Tutorial()
    {
        if(PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            SceneManager.LoadScene("BattleScene1_0_For_Tutorial"); //혹시 스타트부터 누르는 무지성 클릭 예외처리
        }

    }

    public void SceneChange_Gene_Memory_Tutorial()
    {
        SceneManager.LoadScene("RecordMemoryScene_For_Tutorial");
    }

    public void SceneChenge_inGameScene_For_Final_Tutorial()
    {
        SceneManager.LoadScene("inGameScene_For_Final_Tutorial");
    }




    /// <summary>
    /// 
    /// </summary>



    void Update()       //ESC 누를시 옵션창 활성화 / 비활성화
    {
        

        if (Input.GetKeyDown(KeyCode.Escape))
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

    private void Start()
    {


    }


}
