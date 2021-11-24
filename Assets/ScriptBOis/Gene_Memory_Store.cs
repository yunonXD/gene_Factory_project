using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using FMODUnity;

public class Gene_Memory_Store : MonoBehaviour
{

    public GameObject PlayerData;
    public Button[] Gene_Memory_noUnlock;   //�迭. ��� ���ѵ� �̸��� �Ȱ��� 
    public Sprite[] Gene_Unlock_Sprite;     //����Ǿ��ִ� ��������Ʈ
    public Sprite[] Gene_BigIntel_Screen;   //��� Ŭ���ϸ� ������ �����ʿ� ū ���� ��������Ʈ

    [Header("==�ؽ�Ʈ==")]
    public Text Top_Title;                  //�� ���� ���丮 ����
    public Text Day_Log;                    //���� ���� ��� ����
    public Text Cut_SceneText;                 //�Ʒ� ����
    public Text ForStoryText;               //���丮 ����� ������ ��ȭâ �ؽ�Ʈ

    public GameObject IntelPage;            //�����ʿ� �����ְ� ���� â �����°�

    private int Gene_click_checker = 0;     //������ Ŭ������ �ƴ��� Ȯ���Ͽ� �׿� �´� ���丮 ���

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            Gene_Memory_noUnlock[0].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[0];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            Gene_Memory_noUnlock[1].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[1];
        }

        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            Gene_Memory_noUnlock[2].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[2];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            Gene_Memory_noUnlock[3].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[3];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            Gene_Memory_noUnlock[4].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[4];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            Gene_Memory_noUnlock[5].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[5];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            Gene_Memory_noUnlock[6].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[6];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            Gene_Memory_noUnlock[7].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[7];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            Gene_Memory_noUnlock[8].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[8];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            Gene_Memory_noUnlock[9].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[9];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            Gene_Memory_noUnlock[10].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[10];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            Gene_Memory_noUnlock[11].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[11];
        }

    }


    public void Gene_Button_1()
    {
        
        if (Gene_Memory_noUnlock[0] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "����ġ ���� ��� A-1";
            Day_Log.text = "���� ��� ���� 2210.00.24";
            Cut_SceneText.text = " ����ġ ���� ��� A-1 ";

            Gene_click_checker = 1;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_2()
    {
        if (Gene_Memory_noUnlock[1] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            //��������Ʈ ����
            Top_Title.text = "����ġ ���� ��� A-2";
            Day_Log.text = "���� ��� ���� 2210.00.23";
            Cut_SceneText.text = " ����ġ ���� ��� A-2 ";

            Gene_click_checker = 2;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;

        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }


    
    }

    public void Gene_Button_3()
    {

        if (Gene_Memory_noUnlock[2] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "���� �Ʒ� B-1";
            Day_Log.text = "���� ��� ���� 2210.00.25";
            Cut_SceneText.text = " ���� �Ʒ� B-1 ";

            Gene_click_checker = 3;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_4()
    {
        
        if (Gene_Memory_noUnlock[3] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " ���� �Ʒ� B-2 ";
            Day_Log.text = "���� ��� ���� 2210.00.26";
            Cut_SceneText.text = " ���� �Ʒ� B-2 ";

            Gene_click_checker = 4;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_5()
    {

        if (Gene_Memory_noUnlock[4] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " ���� ��ȣ C-1 ";
            Day_Log.text = "���� ��� ���� 2210.00.27";
            Cut_SceneText.text = " ���� ��ȣ C-1 ";

            Gene_click_checker = 5;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_6()
    {

        if (Gene_Memory_noUnlock[5] == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " ���� ��ȣ C-2 ";
            Day_Log.text = "���� ��� ���� 2210.00.28";
            Cut_SceneText.text = " ���� ��ȣ C-2 ";
            Gene_click_checker = 6;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_7()
    {

        if (Gene_Memory_noUnlock[6] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " ���̸���ũ ���̸��� D-1";
            Day_Log.text = "���� ��� ���� 2210.00.29";
            Cut_SceneText.text = " ���̸���ũ ���̸��� D-1 ";

            Gene_click_checker = 7;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_8()
    {

        if (Gene_Memory_noUnlock[7] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " ���̸���ũ ���̸��� D-2 ";
            Day_Log.text = "���� ��� ���� 2210.00.30";
            Cut_SceneText.text = " ���̸���ũ ���̸��� D-2 ";

            Gene_click_checker = 8;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_9()
    {

        if (Gene_Memory_noUnlock[8] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " ������ȣ E-1 ";
            Day_Log.text = "���� ��� ���� 2210.00.31";
            Cut_SceneText.text = " ������ȣ E-1 ";

            Gene_click_checker = 9;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }
    public void Gene_Button_10()
    {

        if (Gene_Memory_noUnlock[9] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = " ������ȣ E-2 ";
            Day_Log.text = "���� ��� ���� 2210.00.31";
            Cut_SceneText.text = " ������ȣ E-2 ";

            Gene_click_checker = 10;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }

    public void Gene_Button_11()
    {

        if (Gene_Memory_noUnlock[10] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "�̸� ����2";
            Day_Log.text = "���� ��� ���� 2210.00.31";
            Cut_SceneText.text = "���� �̸� ��������. �̸��� �ּ���. ";

            Gene_click_checker = 11;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }

    public void Gene_Button_12()
    {

        if (Gene_Memory_noUnlock[11] == true && PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            PlayFModUI.instance.NKeypadMouse();
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "�̸� ����2";
            Day_Log.text = "���� ��� ���� 2210.00.31";
            Cut_SceneText.text = "���� �̸� ��������. �̸��� �ּ���. ";

            Gene_click_checker = 12;
            Debug.Log("Ŭ��Ŀ :" + Gene_click_checker);
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = true;
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
            PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
        }
    }





    public void GeneRecord_Checker()
    {

        switch (Gene_click_checker)
        {
            case 1:
                SceneManager.LoadScene("1_1_Before");
                break;

            case 2:
                SceneManager.LoadScene("1_1_After");
                break;

            case 3:
                SceneManager.LoadScene("1_2_Before");
                break;

            case 4:
                SceneManager.LoadScene("1_2_After");
                break;

            case 5:
                SceneManager.LoadScene("1_3_Before");
                break;

            case 6:
                SceneManager.LoadScene("1_3_After");
                break;

            case 7:
                SceneManager.LoadScene("2_1_Before");
                break;
            case 8:
                SceneManager.LoadScene("2_1_After");
                break;
            case 9:
                SceneManager.LoadScene("2_2_Before");
                break;

            case 10:
                SceneManager.LoadScene("2_2_After");
                break;
            case 11:
                SceneManager.LoadScene("2_3_Before");
                break;
            case 12:
                SceneManager.LoadScene("2_3_After");
                break;




        }


    }


    public void ResetMemorySelect()
    {
        PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 = false;
    }

}
