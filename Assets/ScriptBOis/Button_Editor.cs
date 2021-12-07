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


    public void SceneChange_inGame(){       //�ΰ��Ӿ�
        SceneManager.LoadScene("inGameScene");
    }

    public void SceneChange_BattleStart()   //��Ʋ ����â
    { //��Ʋ ����â
        SceneManager.LoadScene("BattleScene");
    }

    public void SceneChange_Title()         //Ÿ��Ʋâ
    {
        SceneManager.LoadScene("FirstScene");
    }



    public void OptionSetActive()           //�ɼ�â(ó���� false - ��Ȱ��ȭ
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

    public void OnApplicationQuit(){        //��������
        Application.Quit();
    }


    public void Set_NewGame()
    {
        PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 = false;
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = 0;
    }


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))       //ESC ��ư���� �ɼ�â ����
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



    public void QuitButton1_1B()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == true)
        {
            SceneManager.LoadScene("BattleScene1_1");
        }
    }
    public void QuitButton1_1A()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            SceneManager.LoadScene("inGameScene");
        }
    }


    //=======================================================================//


    public void QuitButton1_2B()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == true)
        {
            SceneManager.LoadScene("BattleScene1_2");
        }
    }
    public void QuitButton1_2A()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            SceneManager.LoadScene("inGameScene");
        }
    }


    //=======================================================================//


    public void QuitButton1_3B()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == true)
        {
            SceneManager.LoadScene("BattleScene1_3");
        }
    }
    public void QuitButton1_3A()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            SceneManager.LoadScene("inGameScene");
        }
    }


    //=======================================================================//


    public void QuitButton2_1B()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == true)
        {
            SceneManager.LoadScene("BattleScene2_1");
        }
    }
    public void QuitButton2_1A()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            SceneManager.LoadScene("inGameScene");
        }
    }


    //=======================================================================//


    public void QuitButton2_2B()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == true)
        {
            SceneManager.LoadScene("BattleScene2_2");
        }
    }
    public void QuitButton2_2A()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            SceneManager.LoadScene("inGameScene");
        }
    }


    //=======================================================================//


    public void QuitButton2_3B()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == true)
        {
            SceneManager.LoadScene("BattleScene2_3");
        }
    }
    public void QuitButton2_3A()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            SceneManager.LoadScene("inGameScene");
        }
    }

}
