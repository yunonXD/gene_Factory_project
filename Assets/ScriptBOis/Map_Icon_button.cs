using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using FMODUnity;

public class Map_Icon_button : MonoBehaviour
{
    public GameObject PlayerData; //�÷��̾� ������

    [Header("==��� ����Ʈ==")]
    public GameObject[] Unlock_Effect;
    //����Ʈ�� ĳ���͸��� �޶��� ���� ������ ��������(����Ʈ�� ��������Ʈ�ϼ���, Ȥ�� ����Ʈ(��ƼŬ)�� �� �� �ִ�~

    [Header("==��� ��ũ��==")]
    public GameObject[] Unlock_Screen;


    public Text Point_Check;
    public Sprite[] Gene_List_Sprite;           //����Ʈ ����Ǹ� �ٲ� ��������Ʈ
    public GameObject Gene_Info_for;


    
    int point = 0;
    //����Ʈ

    [Header("==��� �ȵ� ū ������==")]
    public Toggle[] No_Unlock_B_Icon;


    [Header("==����� ū ������==")]
    public Toggle[] Unlock_B_Icon;


    [Space]
    public Button Unlock_Button;        //���� �ϴ� ��� ��ư

    [Header("==���� ��~�� ���� �˾�â==")]
    public Toggle[] BiconIntel_L;

    [Header("==���� ū ���� �˾�â==")]
    public Toggle[] BiconIntelSus_L;

    [Header("==��� �ȵǾ������� ������ ���� ����â==")]
    public GameObject[] BiconNoneIntel;

    [Header("�ε�������â")]
    public GameObject Indicate;


    private bool checkbuttonClick = false;      //������ ���� ���� �ϴ� �ر� ��ư�� ���� �� ������ ��ư ������ �ƴ��� Ȯ�� ����
    private int Icon_discernment = 0;           //�������� ������ �ش� �����ܿ� ���ڰ� ������. ����&&����Ʈ ������ ��� �̷������� ����



    public void Start()
    {



    }

    public void Update()
    {

        point = PlayerData.GetComponent<SaveDataManager>()._ResearchPoint;
        Point_Check.text = "����Ʈ :" + point;    //ȭ�� ���� ��ܿ� ����Ʈâ

        ConRabbit_Load();
        Mush_Load();
        Fran_Load();
        Nymph_Load();
        Manticore_Load();
        unknown1_Load();
        Mobidic_Load();
        TangGreece_Load();
        unknow2_Load();
    }


    private void ConRabbit_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)       
            //�ܷ��� �ҷ�����
        {
            Indicate.gameObject.SetActive(true);
            BiconNoneIntel[7].gameObject.SetActive(false);
            No_Unlock_B_Icon[7].gameObject.SetActive(false);
            Unlock_B_Icon[7].gameObject.SetActive(true);
        }
    }

    private void Mush_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)        
    //�ӽ� �ҷ�����
        {
            Indicate.gameObject.transform.localPosition = new Vector3(245, -400, 0);
            BiconNoneIntel[6].gameObject.SetActive(false);
            No_Unlock_B_Icon[6].gameObject.SetActive(false);
            Unlock_B_Icon[6].gameObject.SetActive(true);
        }
    }

    private void Fran_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)       
    //���� �𷯿���
        {
            Indicate.gameObject.transform.localPosition = new Vector3(385, -220, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);
            BiconNoneIntel[8].gameObject.SetActive(false);
            No_Unlock_B_Icon[8].gameObject.SetActive(false);
            Unlock_B_Icon[8].gameObject.SetActive(true);
        }
    }

    private void Nymph_Load()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)       
    //���� �𷯿���
        {
            Indicate.gameObject.transform.localPosition = new Vector3(240, -50, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);

            BiconNoneIntel[3].gameObject.SetActive(false);
            No_Unlock_B_Icon[3].gameObject.SetActive(false);
            Unlock_B_Icon[3].gameObject.SetActive(true);
        }
    }

    private void Manticore_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)       
    //��Ƽ�ھ� �𷯿���
        {
            Indicate.gameObject.transform.localPosition = new Vector3(-50, -50, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);

            BiconNoneIntel[4].gameObject.SetActive(false);
            No_Unlock_B_Icon[4].gameObject.SetActive(false);
            Unlock_B_Icon[4].gameObject.SetActive(true);
        }
    }

    private void unknown1_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true
    )      //6�� ����(��ȹ���� 6��)
        {
            Indicate.gameObject.transform.localPosition = new Vector3(-190, 110, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);

            BiconNoneIntel[5].gameObject.SetActive(false);
            No_Unlock_B_Icon[5].gameObject.SetActive(false);
            Unlock_B_Icon[5].gameObject.SetActive(true);
        }
    }

    private void Mobidic_Load()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)    
    //���� �𷯿���
        {
            Indicate.gameObject.transform.localPosition = new Vector3(-45, 270, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);

            BiconNoneIntel[0].gameObject.SetActive(false);
            No_Unlock_B_Icon[0].gameObject.SetActive(false);
            Unlock_B_Icon[0].gameObject.SetActive(true);
        }
    }

    private void TangGreece_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)      
    //���׸��� �𷯿���
        {
            Indicate.gameObject.transform.localPosition = new Vector3(240, 270, 0);

            BiconNoneIntel[1].gameObject.SetActive(false);
            No_Unlock_B_Icon[1].gameObject.SetActive(false);
            Unlock_B_Icon[1].gameObject.SetActive(true);
        }
    }

    private void unknow2_Load()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true
    )           //3�� ����(��ȹ���� 3��)
        {
            Indicate.gameObject.SetActive(false);
            BiconNoneIntel[2].gameObject.SetActive(false);
            No_Unlock_B_Icon[2].gameObject.SetActive(false);
            Unlock_B_Icon[2].gameObject.SetActive(true);
        }
    }










    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._ResearchPoint = point;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._ResearchPoint + "����Ʈ�̸�ŭ ���̺�");
    }


    //--------------------------------------����ȵȹ�ư��----------------------//


    public void ForCheck1()     //����
    {        //1~9 �� ���̸� �� ��ġ���� ���� �ο�.
        if (No_Unlock_B_Icon[0].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 1;
            Debug.Log("1");

            BiconNoneIntel[0].gameObject.SetActive(true);
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;        //���ڸ� 0�� �༭ ����Ʈ �����ص� ��� �ȵǵ���
            Debug.Log("1-0");

            BiconNoneIntel[0].gameObject.SetActive(false);
        }
    }
    public void ForCheck2()     //���׸���
    {
        if (No_Unlock_B_Icon[1].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 2;
            Debug.Log("2");

            BiconNoneIntel[1].gameObject.SetActive(true);


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("2-0");

            BiconNoneIntel[1].gameObject.SetActive(false);
        }
    }
    public void ForCheck3()     //??
    {
        if (No_Unlock_B_Icon[2].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 3;
            Debug.Log("3");

            BiconNoneIntel[2].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("3-0");

            BiconNoneIntel[2].gameObject.SetActive(false);
        }
    }
    public void ForCheck4()     //����
    {
        if (No_Unlock_B_Icon[3].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 4;
            Debug.Log("4");

            BiconNoneIntel[3].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("4-0");

            BiconNoneIntel[3].gameObject.SetActive(false);
        }
    }
    public void ForCheck5()     //??
    {
        if (No_Unlock_B_Icon[4].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 5;
            Debug.Log("5");

            BiconNoneIntel[4].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("5-0");

            BiconNoneIntel[4].gameObject.SetActive(false);
        }
    }
    public void ForCheck6()     //??
    {
        if (No_Unlock_B_Icon[5].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 6;
            Debug.Log("6");

            BiconNoneIntel[5].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("6-0");

            BiconNoneIntel[5].gameObject.SetActive(false);
        }
    }
    public void ForCheck7()     //�ӽ�
    {        //1~9 �� ���̸� �� ��ġ���� ���� �ο�.

        if (No_Unlock_B_Icon[6].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 7;
            //Bicon7Intel.gameObject.SetActive(true); //��� �ȵǾ������� ������ ����â ���� ���� ����
            Debug.Log("7");


            BiconNoneIntel[6].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;        //���ڸ� 0�� �༭ ����Ʈ �����ص� ��� �ȵǵ���
            Debug.Log("7-0");

            BiconNoneIntel[6].gameObject.SetActive(false);
        }
    }
    public void ForCheck8()     //�ܷ���
    {
        if (No_Unlock_B_Icon[7].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 8;
            Debug.Log("8");

            BiconNoneIntel[7].gameObject.SetActive(true);


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("8-0");

            BiconNoneIntel[7].gameObject.SetActive(false);
        }
    }
    public void ForCheck9()     //����
    {
        if (No_Unlock_B_Icon[8].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 9;
            Debug.Log("9");

            BiconNoneIntel[8].gameObject.SetActive(true);

        }
        else
        {
            Icon_discernment = 0;
            checkbuttonClick = false;
            Debug.Log("9-0");
            BiconNoneIntel[8].gameObject.SetActive(false);
        }
    }


    //--------------------------------------�����ư----------------------//

    public void Unlock_ButtonPress()        //���� ForCheck[] ���� �ο����� ���ڷ� �رݹ�ư Ȱ��ȭ
    {

        switch (Icon_discernment)
        {

            // 1~3�� �� ���� 1 2 3
            case 1:     //����
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
                //�رݹ�ư On �׸��� ���� ������ üũ��ư(�״ϱ�... �߰��ܰ���� ��� ������)���� ����2���
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(-45, 270, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();

                    BiconNoneIntel[0].gameObject.SetActive(false);          //���� ������ ��Ȱ��ȭ
                    No_Unlock_B_Icon[0].gameObject.SetActive(false);        //? ��������Ʈ ��Ȱ��ȭ
                    Unlock_B_Icon[0].gameObject.SetActive(true);            //ĳ���� �� ��������Ʈ Ȱ��ȭ

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic = true;        //���̺� ������ ����. ���� set false -> true

                    Unlock_Effect[0].SetActive(true);                       //����Ʈ Ȱ��ȭ (�ڵ� destroy)

                    StartCoroutine(WaitForUnlock_Screen(0));                //����� ������ ����߾��! ��ũ��. �ڷ�ƾ 

                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;
            case 2:     //���׸���
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(240, 270, 0);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();

                    BiconNoneIntel[1].gameObject.SetActive(false);
                    No_Unlock_B_Icon[1].gameObject.SetActive(false);
                    Unlock_B_Icon[1].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece = true;

                    Unlock_Effect[1].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(1));

                    point = point - 3;
                    Point_Check.text = "����Ʈ :"+ point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;
            case 3:     //??
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
                {
                    Indicate.gameObject.SetActive(false);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[2].gameObject.SetActive(false);
                    No_Unlock_B_Icon[2].gameObject.SetActive(false);
                    Unlock_B_Icon[2].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 = true;

                    Unlock_Effect[2].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(2));

                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }

                break;

            //4~5�� ������� 4 5 6
            case 4:     //����
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(240, -50, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[3].gameObject.SetActive(false);
                    No_Unlock_B_Icon[3].gameObject.SetActive(false);
                    Unlock_B_Icon[3].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph = true;

                    Unlock_Effect[3].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(3));

                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            case 5:     //��Ƽ�ھ�
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(-50, -50, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[4].gameObject.SetActive(false);
                    No_Unlock_B_Icon[4].gameObject.SetActive(false);
                    Unlock_B_Icon[4].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore = true;

                    Unlock_Effect[4].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(4));


                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            case 6:     //??
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(-190, 110, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[5].gameObject.SetActive(false);
                    No_Unlock_B_Icon[5].gameObject.SetActive(false);
                    Unlock_B_Icon[5].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 = true;

                    Unlock_Effect[5].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(5));


                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            // 7~ 9�� �� �Ʒ���  7 8 9
            case 7:     //�ӽ�
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
                {

                    Indicate.gameObject.transform.localPosition = new Vector3(245, -400, 0);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[6].gameObject.SetActive(false);
                    No_Unlock_B_Icon[6].gameObject.SetActive(false);
                    Unlock_B_Icon[6].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Mush = true;

                    Unlock_Effect[6].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(6));

                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            case 8:     //�ܷ���
                if (checkbuttonClick == true && point >= 3)
                {
                    Indicate.gameObject.SetActive(true);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[7].gameObject.SetActive(false);
                    No_Unlock_B_Icon[7].gameObject.SetActive(false);
                    Unlock_B_Icon[7].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit = true;

                    Unlock_Effect[7].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(7));

                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            case 9:     //����
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(385, -220, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[8].gameObject.SetActive(false);
                    No_Unlock_B_Icon[8].gameObject.SetActive(false);
                    Unlock_B_Icon[8].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Fran = true;

                    Unlock_Effect[8].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(8));


                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

        }

    }

    // ----------------------------- ����� ��ũ�� �����°� ----------------------------- ������Ÿ��. �ϳ��� ����
    IEnumerator WaitForUnlock_Screen(int checker)
    {
        yield return new WaitForSeconds(0.7f);
        Unlock_Screen[checker].gameObject.SetActive(true);

    }


    //--------------------------------------ū ������ Ŭ���� �����ִ� �ٸ� ����â �ݱ� ��ư----------------------//
    public void IntelChecker1()
    {
        if (Unlock_B_Icon[0].isOn)
        {
            BiconIntel_L[0].gameObject.SetActive(true);

            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;

            //GameObject.Find("Gene_Intel_Text").SetActive(false);

            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[0].gameObject.SetActive(false);
            BiconIntel_L[0].isOn = false;

        }
    }
    public void IntelChecker2()
    {
        if (Unlock_B_Icon[1].isOn)
        {
            BiconIntel_L[1].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[1].gameObject.SetActive(false);
            BiconIntel_L[1].isOn = false;
        }
    }
    public void IntelChecker3()
    {
        if (Unlock_B_Icon[2].isOn)
        {
            BiconIntel_L[2].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[2].gameObject.SetActive(false);
            BiconIntel_L[2].isOn = false;
        }
    }

    public void IntelChecker4()
    {
        if (Unlock_B_Icon[3].isOn)
        {
            BiconIntel_L[3].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[3].gameObject.SetActive(false);
            BiconIntel_L[3].isOn = false;
        }
    }

    public void IntelChecker5()
    {
        if (Unlock_B_Icon[4].isOn)
        {
            BiconIntel_L[4].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[4].gameObject.SetActive(false);
            BiconIntel_L[4].isOn = false;
        }
    }

    public void IntelChecker6()
    {
        if (Unlock_B_Icon[5].isOn)
        {
            BiconIntel_L[5].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[5].gameObject.SetActive(false);
            BiconIntel_L[5].isOn = false;
        }
    }

    public void IntelChecker7()
    {
        if (Unlock_B_Icon[6].isOn)
        {
            BiconIntel_L[6].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[6].gameObject.SetActive(false);
            BiconIntel_L[6].isOn = false;
        }
    }

    public void IntelChecker8()
    {
        if (Unlock_B_Icon[7].isOn)
        {
            BiconIntel_L[7].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[7].gameObject.SetActive(false);
            BiconIntel_L[7].isOn = false;
        }
    }

    public void IntelChecker9()
    {
        if (Unlock_B_Icon[8].isOn)
        {
            BiconIntel_L[8].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
        }
        else
        {
            BiconIntel_L[8].gameObject.SetActive(false);
            BiconIntel_L[8].isOn = false;
        }
    }


    //--------------------------------------����â Ŭ���� ���ʿ� ������ ū ����â �� �̸� ���λ��� ��ư----------------------//

    public void IntelForSus1()
    {
        if (BiconIntel_L[0].isOn)
        {
            BiconIntelSus_L[0].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[5];


        }
        else
        {
            BiconIntelSus_L[0].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus2()
    {
        if (BiconIntel_L[1].isOn)
        {
            BiconIntelSus_L[1].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[6];




        }
        else
        {
            BiconIntelSus_L[1].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus3()
    {
        if (BiconIntel_L[2].isOn)
        {
            BiconIntelSus_L[2].gameObject.SetActive(true);

            //Gene_Info_for.gameObject.SetActive(true);



        }
        else
        {
            BiconIntelSus_L[2].gameObject.SetActive(false);
            //Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus4()
    {
        if (BiconIntel_L[3].isOn)
        {
            BiconIntelSus_L[3].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[3];



        }
        else
        {
            BiconIntelSus_L[3].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus5()
    {
        if (BiconIntel_L[4].isOn)
        {
            BiconIntelSus_L[4].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[4];


        }
        else
        {
            BiconIntelSus_L[4].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus6()
    {
        if (BiconIntel_L[5].isOn)
        {
            BiconIntelSus_L[5].gameObject.SetActive(true);

            //Gene_Info_for.gameObject.SetActive(true);



        }
        else
        {
            BiconIntelSus_L[5].gameObject.SetActive(false);
            //Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus7()
    {
        if (BiconIntel_L[6].isOn)
        {
            BiconIntelSus_L[6].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[1];



        }
        else
        {
            BiconIntelSus_L[6].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus8()
    {
        if (BiconIntel_L[7].isOn)
        {
            BiconIntelSus_L[7].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[0];


        }
        else
        {
            BiconIntelSus_L[7].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus9()
    {
        if (BiconIntel_L[8].isOn)
        {
            BiconIntelSus_L[8].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[2];


        }
        else
        {
            BiconIntelSus_L[8].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }



}
