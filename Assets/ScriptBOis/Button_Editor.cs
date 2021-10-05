using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        SceneManager.LoadScene("IntroScene");
    }

    public void SceneChange_Stage1_1()         //����ȭ�� 1_1â 
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            SceneManager.LoadScene("BattleScene1_1");
        }
        else
        {
            Debug.Log("�������� ���� ������ �������� ���߽��ϴ�.");
        }
    }

    public void SceneChange_Stage1_2()         //����ȭ�� 1_2â 
    {
       // SceneManager.LoadScene("BattleScene1_2");
    }

    public void SceneChange_Stage1_3()        //����ȭ�� 1_3â 
    {
       // SceneManager.LoadScene("BattleScene1_3");
    }

    public void SceneChange_Stage1_4()        //����ȭ�� 1_4â 
    {
        // SceneManager.LoadScene("BattleScene1_4");
    }

    public void SceneChange_Stage2_1()        //����ȭ�� 2_1â 
    {
        // SceneManager.LoadScene("BattleScene2_1");
    }
    public void SceneChange_Stage2_2()        //����ȭ�� 2_2â 
    {
        // SceneManager.LoadScene("BattleScene2_2");
    }
    public void SceneChange_Stage2_3()        //����ȭ�� 2_3â 
    {
        // SceneManager.LoadScene("BattleScene2_3");
    }
    public void SceneChange_Stage2_4()        //����ȭ�� 2_4â 
    {
        // SceneManager.LoadScene("BattleScene2_4");
    }



    public void OptionSetActive()           //�ɼ�â(ó���� false - ��Ȱ��ȭ
    {
        Debug.Log("�ɼ�â �׽�Ʈ");
        Optionpage.SetActive(false);
    }

    public void OnApplicationQuit(){        //��������(����Ƽ���� ��ġ����? ����׸� ����
        Application.Quit();
        Debug.Log("��ġ����?");
    }



    void Update()       //ESC ������ �ɼ�â Ȱ��ȭ / ��Ȱ��ȭ
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Optionpage.SetActive(true);
        }
    }
}
