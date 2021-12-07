using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class B_Select_Tutorial : MonoBehaviour
{

    public GameObject PlayerData;           //���̺굥����
    public GameObject Tutorial;             //Ʃ�丮�����ٺθ�ü
    public GameObject Dialogue;             //Ʃ�丮�����ٺθ�ü
    public GameObject Indicator;            //ȭ��ǥ
    public GameObject ScreenBlack;
    public GameObject ScreenBlack_2;
    public GameObject ScreenBlack_3;
    public GameObject ScreenBlack_4;

    public Button[] Stage;

    public Text C_name;
    public Text C_Dialogue;

    private int Yeeter = 0;               //���̾�α� �о�� ���̺����� �޾ƿ� ��Ʈ��

    private GameObject Option;


    void Start()
    {
        Option = GameObject.Find("GameManager");
        Tutorial.gameObject.SetActive(true);

    }

    void Update()
    {
        BattleSTutorial();
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;
    }

    void BattleSTutorial()
    {
        //Ʃ�丮�� ������ ���� _Gene_Between3 �Ǻ�
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {

            //esc �۵� ��ũ��Ʈ DEAD
            Option.GetComponent<Button_Editor>().enabled = false;

            for (int i = 0; i < 6; i++)
            {
                Stage[i].GetComponent<Button>().interactable = false;
            }


        }
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == true)
        {
            //esc �۵� ��ũ��Ʈ Alive
            Option.GetComponent<Button_Editor>().enabled = true;
            Tutorial.gameObject.SetActive(false);
            for (int i = 0; i < 6; i++)
            {
                Stage[i].GetComponent<Button>().interactable = true;
            }
            Destroy(this);      //�Ⱦ��� ����
        }
    }


    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "����Ʈ�̸�ŭ ���̺�");
    }


    public void BattleSelectTutorial()
    {
        Yeeter = Yeeter + 1;
        PointSaver();
        switch (Yeeter)
        {

            case 25:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("����ʼ� �����ڴ�.", 1);

                ScreenBlack_3.gameObject.SetActive(true);   //0-1 ����
                ScreenBlack.gameObject.SetActive(true);     //���̾�α�

                break;

            case 26:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�̹� �Ʒ��� ������ ����� �����Ʒ����� �����ڴ��� " +
                    "�������� ��� ��ó�ϴ��� �ľ��ϱ� ���� �Ʒ��Դϴ�.", 1);
                break;

            case 27:

                ScreenBlack_2.gameObject.SetActive(true);
                ScreenBlack_3.gameObject.SetActive(false);
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�������� 0 - 1 �� �����Ͻð�, ���� �� �ر��Ͻ� ����ü�� �������ּ���.", 1);




                break;

            case 28:
                ScreenBlack.gameObject.SetActive(false);
                Dialogue.gameObject.SetActive(false);
                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(-441f, 146f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -30f);

                break;


            case 29:

                ScreenBlack_4.gameObject.SetActive(true);
                ScreenBlack_2.gameObject.SetActive(false);
                ScreenBlack.gameObject.SetActive(false);

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(528f, -355f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -30f);


                break;









        }


    }



}
