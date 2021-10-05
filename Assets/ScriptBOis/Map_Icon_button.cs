using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;

//�ؾ��ϴ°� - ����Ʈ ��ġ ����, no information â �˾� ���� , ����� �˾�â �����ϱ�


public class Map_Icon_button : MonoBehaviour
{
    [Header("==��� ����Ʈ==")]
    public GameObject[] Unlock_Effect;
    //����Ʈ�� ĳ���͸��� �޶��� ���� ������ ��������(����Ʈ�� ��������Ʈ�ϼ���, Ȥ�� ����Ʈ(��ƼŬ)�� �� �� �ִ�~

    [Header("==��� ��ũ��==")]
    public GameObject[] Unlock_Screen;



    public Text Gene_Name, Gene_Intel, Point_Check;
    [Space]
    public GameObject Gene_Intel_Text;

    //Gene_Intel_Text�κ� ������ �̸�,����, ���λ��� 
    //����Ʈ ( ȭ�鿡 ǥ���� ����Ʈ : â �ҷ�����) 

    int point = 99;
    //����Ʈ ( �⺻ 30����Ʈ. ����� �ʿ� ����Ʈ 3)

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


    [Header("==���� ������==")]
    public Toggle[] Small_Icon;

    [Header("==����� ���� ������==")]
    public GameObject[] Unlock_Small_Icon;

    //Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Gene_Resource/GMAP_mini_1");

    private bool checkbuttonClick = false;      //������ ���� ���� �ϴ� �ر� ��ư�� ���� �� ������ ��ư ������ �ƴ��� Ȯ�� ����
    private int Icon_discernment = 0;           //�������� ������ �ش� �����ܿ� ���ڰ� ������. ����&&����Ʈ ������ ��� �̷������� ����


    private int LeftgeneChecker = 0;            //������ ������ ��� ����(�Ʒ����� �������� ���
    private int MiddlegeneChecker = 0;          //����� ������ ��� ����(�Ʒ����� �������� ���
    private int RightgeneChecker = 0;           //�������� ������ ��� ����(�Ʒ����� �������� ���


    public void Start()
    {
        //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
        //Debug.Log(NoneIntelVector);
        Point_Check.text = "����Ʈ :" + point;    //ȭ�� ���� ��ܿ� ����Ʈâ(�ӽ�)
    }

    //--------------------------------------����ȵȹ�ư��----------------------//


    public void ForCheck1()
    {        //1~9 �� ���̸� �� ��ġ���� ���� �ο�.
        if (No_Unlock_B_Icon[0].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 1;
            Debug.Log("1");

            BiconNoneIntel[0].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //-257.8 , 227.5 , 0.0
            //NoneIntelVector.x = -257.8f;
            //NoneIntelVector.y = 227.5f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;        //���ڸ� 0�� �༭ ����Ʈ �����ص� ��� �ȵǵ���
            Debug.Log("1-0");

            BiconNoneIntel[0].gameObject.SetActive(false);
        }
    }
    public void ForCheck2()
    {
        if (No_Unlock_B_Icon[1].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 2;
            Debug.Log("2");

            BiconNoneIntel[1].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //150.7 , 227.5 , 0.0
            //NoneIntelVector.x = 150.7f;
            //NoneIntelVector.y = 227.5f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("2-0");

            BiconNoneIntel[1].gameObject.SetActive(false);
        }
    }
    public void ForCheck3()
    {
        if (No_Unlock_B_Icon[2].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 3;
            Debug.Log("3");

            BiconNoneIntel[2].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //565.4 , 227.5 , 0.0
            //NoneIntelVector.x = 565.4f;
            //NoneIntelVector.y = 227.5f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("3-0");

            BiconNoneIntel[2].gameObject.SetActive(false);
        }
    }
    public void ForCheck4()
    {
        if (No_Unlock_B_Icon[3].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 4;
            Debug.Log("4");

            BiconNoneIntel[3].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //-267.8 , -86.9 , 0.0
            //NoneIntelVector.x = -267.8f;
            //NoneIntelVector.y = -86.9f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("4-0");

            BiconNoneIntel[3].gameObject.SetActive(false);
        }
    }
    public void ForCheck5()
    {
        if (No_Unlock_B_Icon[4].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 5;
            Debug.Log("5");

            BiconNoneIntel[4].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //150.7 , -86.9 , 0.0
            //NoneIntelVector.x = 150.7f;
            //NoneIntelVector.y = -86.9f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("5-0");

            BiconNoneIntel[4].gameObject.SetActive(false);
        }
    }
    public void ForCheck6()
    {
        if (No_Unlock_B_Icon[5].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 6;
            Debug.Log("6");

            BiconNoneIntel[5].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //565.4 , -86.9 , 0.0
            //NoneIntelVector.x = 565.4f;
            //NoneIntelVector.y = -86.9f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("6-0");

            BiconNoneIntel[5].gameObject.SetActive(false);
        }
    }
    public void ForCheck7()
    {        //1~9 �� ���̸� �� ��ġ���� ���� �ο�.

        if (No_Unlock_B_Icon[6].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 7;
            //Bicon7Intel.gameObject.SetActive(true); //��� �ȵǾ������� ������ ����â ���� ���� ����
            Debug.Log("7");

            BiconNoneIntel[6].gameObject.SetActive(true);



            //BiconNoneIntel.gameObject.SetActive(true); // -267.8 , -374.6, 0.0
            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //NoneIntelVector.x = -267.8f;
            //NoneIntelVector.y = -374.6f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;        //���ڸ� 0�� �༭ ����Ʈ �����ص� ��� �ȵǵ���
            Debug.Log("7-0");

            BiconNoneIntel[6].gameObject.SetActive(false);
        }
    }
    public void ForCheck8()
    {
        if (No_Unlock_B_Icon[7].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 8;
            Debug.Log("8");

            BiconNoneIntel[7].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //150.7 , -374.6 , 0.0
            //NoneIntelVector.x = 150.7f;
            //NoneIntelVector.y = -374.6f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("8-0");

            BiconNoneIntel[7].gameObject.SetActive(false);
        }
    }
    public void ForCheck9()
    {
        if (No_Unlock_B_Icon[8].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 9;
            Debug.Log("9");

            BiconNoneIntel[8].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //565.4 , -374.6 , 0.0
            //NoneIntelVector.x = 565.4f;
            //NoneIntelVector.y = -374.6f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
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
            case 1:
                if (checkbuttonClick == true && point > 3 && LeftgeneChecker == 2)
                //�رݹ�ư On �׸��� ���� ������ üũ��ư(�״ϱ�... �߰��ܰ���� ��� ������)���� ����2���
                {
                    BiconNoneIntel[0].gameObject.SetActive(false); //���� ������ ��Ȱ��ȭ
                    No_Unlock_B_Icon[0].gameObject.SetActive(false);       //? ��������Ʈ ��Ȱ��ȭ
                    Unlock_B_Icon[0].gameObject.SetActive(true);          //ĳ���� �� ��������Ʈ Ȱ��ȭ

                    Unlock_Effect[0].SetActive(true);             //����Ʈ Ȱ��ȭ (�ڵ� destroy)

                    StartCoroutine(WaitForUnlock_Screen(0));        //����� ������ ����߾��! ��ũ��. �ڷ�ƾ 

                    point = point - 5;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;
            case 2:
                if (checkbuttonClick == true && point > 3 && MiddlegeneChecker == 2)
                {
                    BiconNoneIntel[1].gameObject.SetActive(false);
                    No_Unlock_B_Icon[1].gameObject.SetActive(false);
                    Unlock_B_Icon[1].gameObject.SetActive(true);
                    Unlock_Effect[1].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(1));

                    point = point - 5;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;
            case 3:
                if (checkbuttonClick == true && point > 3 && RightgeneChecker == 2)
                {
                    BiconNoneIntel[2].gameObject.SetActive(false);
                    No_Unlock_B_Icon[2].gameObject.SetActive(false);
                    Unlock_B_Icon[2].gameObject.SetActive(true);
                    Unlock_Effect[2].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(2));

                    point = point - 5;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }

                break;

            //4~5�� ������� 4 5 6
            case 4:
                if (checkbuttonClick == true && point > 3 && LeftgeneChecker == 1)
                {
                    BiconNoneIntel[3].gameObject.SetActive(false);
                    No_Unlock_B_Icon[3].gameObject.SetActive(false);
                    Unlock_B_Icon[3].gameObject.SetActive(true);
                    Unlock_Effect[3].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(3));

                    LeftgeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 5:
                if (checkbuttonClick == true && point > 3 && MiddlegeneChecker == 1)
                {
                    BiconNoneIntel[4].gameObject.SetActive(false);
                    No_Unlock_B_Icon[4].gameObject.SetActive(false);
                    Unlock_B_Icon[4].gameObject.SetActive(true);
                    Unlock_Effect[4].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(4));

                    MiddlegeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;
            case 6:
                if (checkbuttonClick == true && point > 3 && RightgeneChecker == 1)
                {
                    BiconNoneIntel[5].gameObject.SetActive(false);
                    No_Unlock_B_Icon[5].gameObject.SetActive(false);
                    Unlock_B_Icon[5].gameObject.SetActive(true);
                    Unlock_Effect[5].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(5));

                    RightgeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            // 7~ 9�� �� �Ʒ���  7 8 9
            case 7:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel[6].gameObject.SetActive(false);
                    No_Unlock_B_Icon[6].gameObject.SetActive(false);
                    Unlock_B_Icon[6].gameObject.SetActive(true);
                    Unlock_Effect[6].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(6));



                    LeftgeneChecker = 1;

                    point = point - 2;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 8:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel[7].gameObject.SetActive(false);
                    No_Unlock_B_Icon[7].gameObject.SetActive(false);
                    Unlock_B_Icon[7].gameObject.SetActive(true);
                    Unlock_Effect[7].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(7));

                    MiddlegeneChecker = 1;

                    point = point - 2;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 9:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel[8].gameObject.SetActive(false);
                    No_Unlock_B_Icon[8].gameObject.SetActive(false);
                    Unlock_B_Icon[8].gameObject.SetActive(true);
                    Unlock_Effect[8].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(8));

                    RightgeneChecker = 1;

                    point = point - 2;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 10:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[3].gameObject.activeSelf == true)
                {
                    Small_Icon[0].gameObject.SetActive(false);
                    Unlock_Small_Icon[0].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 11:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[3].gameObject.activeSelf == true && Unlock_B_Icon[4].gameObject.activeSelf == true)
                {
                    Small_Icon[1].gameObject.SetActive(false);
                    Unlock_Small_Icon[1].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 12:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[4].gameObject.activeSelf == true && Unlock_B_Icon[5].gameObject.activeSelf == true)
                {
                    Small_Icon[2].gameObject.SetActive(false);
                    Unlock_Small_Icon[2].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 13:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[5].gameObject.activeSelf == true)
                {
                    Small_Icon[3].gameObject.SetActive(false);
                    Unlock_Small_Icon[3].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 14:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[6].gameObject.activeSelf == true)
                {
                    Small_Icon[4].gameObject.SetActive(false);
                    Unlock_Small_Icon[4].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;


            case 15:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[6].gameObject.activeSelf == true && Unlock_B_Icon[7].gameObject.activeSelf == true)
                {
                    Small_Icon[5].gameObject.SetActive(false);
                    Unlock_Small_Icon[5].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;


            case 16:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[7].gameObject.activeSelf == true && Unlock_B_Icon[8].gameObject.activeSelf == true)
                {
                    Small_Icon[6].gameObject.SetActive(false);
                    Unlock_Small_Icon[6].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "����Ʈ :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 17:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[8].gameObject.activeSelf == true)
                {
                    Small_Icon[7].gameObject.SetActive(false);
                    Unlock_Small_Icon[7].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "����Ʈ :" + point;
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

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "����";

            Gene_Intel.text = "1�� ����";


        }
        else
        {
            BiconIntelSus_L[0].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus2()
    {
        if (BiconIntel_L[1].isOn)
        {
            BiconIntelSus_L[1].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "���׸���";

            Gene_Intel.text = "2�� ����";


        }
        else
        {
            BiconIntelSus_L[1].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus3()
    {
        if (BiconIntel_L[2].isOn)
        {
            BiconIntelSus_L[2].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "3��";

            Gene_Intel.text = "3�� ����";


        }
        else
        {
            BiconIntelSus_L[2].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus4()
    {
        if (BiconIntel_L[3].isOn)
        {
            BiconIntelSus_L[3].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "����";

            Gene_Intel.text = "4�� ����";


        }
        else
        {
            BiconIntelSus_L[3].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus5()
    {
        if (BiconIntel_L[4].isOn)
        {
            BiconIntelSus_L[4].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "��Ƽ�ھ�";

            Gene_Intel.text = "5�� ����";


        }
        else
        {
            BiconIntelSus_L[4].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus6()
    {
        if (BiconIntel_L[5].isOn)
        {
            BiconIntelSus_L[5].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "6��";

            Gene_Intel.text = "6�� ����";


        }
        else
        {
            BiconIntelSus_L[5].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus7()
    {
        if (BiconIntel_L[6].isOn)
        {
            BiconIntelSus_L[6].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "�ӽ�";

            Gene_Intel.text = "7�� ����";


        }
        else
        {
            BiconIntelSus_L[6].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus8()
    {
        if (BiconIntel_L[7].isOn)
        {
            BiconIntelSus_L[7].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "�ܷ���";

            Gene_Intel.text = "8�� ����";


        }
        else
        {
            BiconIntelSus_L[7].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus9()
    {
        if (BiconIntel_L[8].isOn)
        {
            BiconIntelSus_L[8].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "����";

            Gene_Intel.text = "9�� ����";


        }
        else
        {
            BiconIntelSus_L[8].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }




    //--------------------------------------���� ������ �ر� ��ư----------------------//


    public void Small_Unlocker1()
    {
        if (Small_Icon[0].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 10;
            Debug.Log("S_1");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_1");

        }
    }
    public void Small_Unlocker2()
    {
        if (Small_Icon[1].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 11;
            Debug.Log("S_2");



        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_2");

        }
    }
    public void Small_Unlocker3()
    {
        if (Small_Icon[2].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 12;
            Debug.Log("S_3");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_3");

        }
    }

    public void Small_Unlocker4()
    {
        if (Small_Icon[3].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 13;
            Debug.Log("S_4");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_4");

        }
    }
    public void Small_Unlocker5()
    {
        if (Small_Icon[4].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 14;
            Debug.Log("S_5");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_5");

        }
    }

    public void Small_Unlocker6()
    {
        if (Small_Icon[5].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 15;
            Debug.Log("S_6");



        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_6");

        }
    }


    public void Small_Unlocker7()
    {
        if (Small_Icon[6].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 16;
            Debug.Log("S_7");

  

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_7");

        }
    }

    public void Small_Unlocker8()
    {
        if (Small_Icon[7].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 17;
            Debug.Log("S_8");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_8");

        }
    }
}
