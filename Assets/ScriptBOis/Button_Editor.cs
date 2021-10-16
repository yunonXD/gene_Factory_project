using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Editor : MonoBehaviour{

    public GameObject Optionpage;
    public GameObject PlayerData;


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
    }

    public void OnApplicationQuit(){        //��������
        Application.Quit();
    }


    void Update()       //ESC ������ �ɼ�â Ȱ��ȭ / ��Ȱ��ȭ
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Optionpage.SetActive(true);
        }

    }




}
