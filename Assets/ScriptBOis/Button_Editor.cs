using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Editor : MonoBehaviour{

    public GameObject Optionpage;
    public GameObject PlayerData;
    public GameObject SelectVictim;             //�������� ������ ������ ĳ���� ����â
    public Button[] Stage;                      //�������� ��ư


    //������ �������� Ŭ���� ���� => ���̺� ������ Ȱ�� �ʿ�

    private int StageSelect = 0;

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




    public void SelectBattle_Button()       //���۹�ư �� ��ư���� �ٸ� �������� �Ҵ�
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
        //Debug.Log("�ɼ�â �׽�Ʈ");
        Optionpage.SetActive(false);
    }

    public void OnApplicationQuit(){        //��������(����Ƽ���� ��ġ����? ����׸� ����
        Application.Quit();
        //Debug.Log("��ġ����?");
    }



    void Update()       //ESC ������ �ɼ�â Ȱ��ȭ / ��Ȱ��ȭ
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Optionpage.SetActive(true);
        }
    }
}
