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

    public void SceneChange_gene(){         //������ ����â
        SceneManager.LoadScene("geneMap");
    }

    public void SceneChange_BattleSelect(){ //��Ʋ ����â
        SceneManager.LoadScene("BattleSelectScene");
    }

    public void SceneChange_BattleStart()   //��Ʋ ����â
    { //��Ʋ ����â
        SceneManager.LoadScene("BattleScene");
    }

    public void SceneChange_Title()         //Ÿ��Ʋâ
    {
        SceneManager.LoadScene("FirstScene");
    }

    public void SceneChange_Memor_gene()    //��� �����
    {
        SceneManager.LoadScene("RecordMemoryScene");
    }



    public void OptionSetActive()           //�ɼ�â(ó���� false - ��Ȱ��ȭ
    {
        //Debug.Log("�ɼ�â �׽�Ʈ");
        Optionpage.SetActive(false);
        isPause = false;
    }




    public void OnApplicationQuit(){        //��������
        Application.Quit();
    }


    /// <summary>
    /// ���� Ʃ�丮��� ��ư��!!! ���� ������ ������ �� ������ �����Ұ�!
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
            SceneManager.LoadScene("BattleScene1_0_For_Tutorial"); //Ȥ�� ��ŸƮ���� ������ ������ Ŭ�� ����ó��
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

    private void Start()
    {


    }


}
