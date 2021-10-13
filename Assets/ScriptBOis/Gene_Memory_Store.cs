using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private int Gene_Memory_Chacker = 0;        //������ ���� �ٸ� ����â ���� ���� �ʿ��� ���� �Ҵ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            Gene_Memory_noUnlock[0].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[0];
            Gene_Memory_Chacker = 1;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            Gene_Memory_noUnlock[1].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[1];
            Gene_Memory_Chacker = 2;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            Gene_Memory_noUnlock[2].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[2];
            Gene_Memory_Chacker = 3;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            Gene_Memory_noUnlock[3].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[3];
            Gene_Memory_Chacker = 4;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            Gene_Memory_noUnlock[4].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[4];
            Gene_Memory_Chacker = 5;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            Gene_Memory_noUnlock[5].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[5];
            Gene_Memory_Chacker = 6;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            Gene_Memory_noUnlock[6].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[6];
            Gene_Memory_Chacker = 7;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            Gene_Memory_noUnlock[7].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[7];
            Gene_Memory_Chacker = 8;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            Gene_Memory_noUnlock[8].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[8];
            Gene_Memory_Chacker = 9;
        }

    }


    public void Gene_Button_1()
    {
        if (Gene_Memory_noUnlock[0] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
                IntelPage.gameObject.SetActive(true);

            //��������Ʈ ����
            Top_Title.text = "������ ������";
            Day_Log.text = "���� ��� ���� 2210.00.23";
            Cut_SceneText.text = "������ ���� ����? ������������������... �̾� ";

        }
    }
    public void Gene_Button_2()
    {
        if (Gene_Memory_noUnlock[1] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "�䳢�� ���� ��";
            Day_Log.text = "���� ��� ���� 2210.00.24";
            Cut_SceneText.text = "�� �䲸! ";
        }
    }

    public void Gene_Button_3()
    {
        if (Gene_Memory_noUnlock[2] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "������ ���� ��";
            Day_Log.text = "���� ��� ���� 2210.00.25";
            Cut_SceneText.text = "���������������� ";
        }
    }
    public void Gene_Button_4()
    {
        if (Gene_Memory_noUnlock[3] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "������ ���� ��";
            Day_Log.text = "���� ��� ���� 2210.00.26";
            Cut_SceneText.text = "��? ��?? ";
        }
    }
    public void Gene_Button_5()
    {
        if (Gene_Memory_noUnlock[4] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "�Ž��� ���� ��";
            Day_Log.text = "���� ��� ���� 2210.00.27";
            Cut_SceneText.text = "�ȳ� �� ��Ƽ�ھ�� ";
        }
    }
    public void Gene_Button_6()
    {
        if (Gene_Memory_noUnlock[5] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "�̸� ����????";
            Day_Log.text = "���� ��� ���� 2210.00.28";
            Cut_SceneText.text = " �ȳ� �� ���� �����̾� ������ �̸��� �ּ��� ";
        }
    }
    public void Gene_Button_7()
    {
        if (Gene_Memory_noUnlock[6] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "������ ���� ��";
            Day_Log.text = "���� ��� ���� 2210.00.29";
            Cut_SceneText.text = " ����? ���? De BIg?  ";
        }
    }
    public void Gene_Button_8()
    {
        if (Gene_Memory_noUnlock[7] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "���帮�尡 ���� ��";
            Day_Log.text = "���� ��� ���� 2210.00.30";
            Cut_SceneText.text = " ��! �� �׸��� �Ф� ";
        }
    }
    public void Gene_Button_9()
    {
        if (Gene_Memory_noUnlock[8] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "�̸� ����2";
            Day_Log.text = "���� ��� ���� 2210.00.31";
            Cut_SceneText.text = "���� �̸� ��������. �̸��� �ּ���. ";
        }
    }






}
