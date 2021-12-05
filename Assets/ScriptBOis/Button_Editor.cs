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

    //public void SceneChange_gene(){         //������ ����â
    //    SceneManager.LoadScene("geneMap");
    //}

   // public void SceneChange_BattleSelect(){ //��Ʋ ����â
   //     SceneManager.LoadScene("BattleSelectScene");
   // }

    public void SceneChange_BattleStart()   //��Ʋ ����â
    { //��Ʋ ����â
        SceneManager.LoadScene("BattleScene");
    }

    public void SceneChange_Title()         //Ÿ��Ʋâ
    {
        SceneManager.LoadScene("FirstScene");
    }

    //public void SceneChange_Memor_gene()    //��� �����
    //{
    //    SceneManager.LoadScene("RecordMemoryScene");
    //}



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


    void Update()       //ESC ������ �ɼ�â Ȱ��ȭ / ��Ȱ��ȭ
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

}
