using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_2_After : MonoBehaviour
{
    public GameObject ScreenLock;       //��ư �������� �� �ɱ�

    private int CountClick = 0;
    public Text _index;                 //��ȭ ����
    public Text _name;                  //�̸�
    public GameObject MainBG_1;          //�⺻ ���� BG
    public GameObject MainBG_2;         //�ٲ� ���� BG

    public GameObject Secretary;        //�� ��������Ʈ
    public GameObject Normal_eyes;      //�Ϲ� ǥ��
    public GameObject Close_eyes;       //���� ��
    public GameObject Smile_eyes;       //���� ��
    public GameObject Surprise_eyes;    //��� ��
    public GameObject NPC_1;            //NPC1
    public GameObject NPC_2;            //NPC2
    public GameObject SelectQ;          //����â
    public Text _Select_text1;          //����â�� ���� �ؽ�Ʈ1
    public Text _Select_text2;          //����â�� ���� �ؽ�Ʈ2
    public Button SelectQ_B_1;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Button SelectQ_B_2;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public GameObject FadeBoi;          //���̵� �� �ƿ� ��ų ���� ȭ��
    public GameObject UI_Dialoue;

    private Animator animator;
    private bool Alpha_Secretary = false;
    private bool Alpha_NPC_1 = false;
    private float Timer = 0;

    bool select1 = false;
    bool select2 = false;

    private void Awake()
    {
        animator = FadeBoi.GetComponent<Animator>();
    }


    void Start()
    {
        SelectQ_B_1.onClick.AddListener(SelectQ_1);
        SelectQ_B_2.onClick.AddListener(SelectQ_2);

    }


    void Update()
    {
    }

    public void SelectQ_1()          //������ â���� �������� �ƴ��� Ȯ���ϴºκ�.
    {
        select1 = true;
        Debug.Log(select1);
    }

    public void SelectQ_2()          //������ â���� �������� �ƴ��� Ȯ���ϴºκ�.
    {
        select2 = true;
        Debug.Log(select2);
    }


    //���� ������ȣ

    //.setDelay(?);
    public void ForStory_2_2()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("�����ڰ� ����ü ���������� ������ �ð�, ���� ����", 1);
                break;


            case 2:
                NPC_1.gameObject.SetActive(true);
                _name.text = "????";
                _index.DOText("", 1);
                _index.DOText("���� ���ݾ�, ���� �������� ��ٷ� ��� �Ǵ� �ž�? ���� ���� ���� ������ �����? ", 1);
                break;

            case 3:
                NPC_1.gameObject.SetActive(false);
                _name.text = "����";
                _index.DOText("", 1);
                _index.DOText("�𸨴ϴ�! ��¥�� �ƹ��͵� �𸨴ϴ�! ", 1);

                break;

            case 4:
                NPC_1.gameObject.SetActive(true);
                _name.text = "????";
                _index.DOText("", 1);
                _index.DOText("ETI ���� ���� �ֿ� ��� ��ġ�� ���� �޶��! �ƹ��� ���� �˷����� ������ ȭ�� �ž�!", 1);
                break;

            case 5:
                NPC_1.gameObject.SetActive(false);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("������ �ڽ��� ����� ���� �� �� ���� �ٸ��� �񷶴�.", 1);
                break;


            case 6:
                //�ش� �ƽſ��� �ؽ�Ʈ�� ���� ������ ���� ��ī�ο� ������ ��� ȿ������ ���´�.
                break;

            case 7:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("������ ����� ������ ���뽺�����ߴ�.", 1);
                break;


            case 8:
                _name.text = "����";
                _index.DOText("", 1);
                _index.DOText("������ ��ġ�� �𸨴ϴ�, ���� ������� ����ֽʽÿ�!", 1);
                break;

            case 9:
                NPC_1.gameObject.SetActive(true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText(".....", 1);
                break;

            case 10:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("��, �˷��ֱ� ������ ����, ����콺 ���� ����!", 1);
                break;

            case 11:

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�� �� ��� ������ ������ ��������� �ۿ� �ִ� ģ������ �� �̻� ���⿡ �ִ� �� �����ϴٰ� �ϴϱ� ���� ���ư���.", 1);
                break;

            case 12:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�������� �� ����� ETI", 1);
                break;

            case 13:

                FadeBoi.gameObject.SetActive(true);
                break;

            case 14:
                MainBG_1.gameObject.SetActive(false);
                MainBG_2.gameObject.SetActive(true);
                NPC_1.gameObject.SetActive(false);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);
                _name.text = "";
                _index.DOText("", 1);
                break;


            case 15:
                Secretary.gameObject.SetActive(true);

                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("����ϼ̽��ϴ�, �����ڴ�.", 1);
                break;

            case 16:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� ���ο� �ִ� �����ڵ��� ������ ���� ����� ������ �˰� �Ǿ����ϴ�.", 1);
                break;


            case 17:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� ������ �����ϱ� ���� ������ �� �����Դϴ�. �̹� ������ ���� �ӹ� �̻����� ������ ������ ����˴ϴ�.", 1);
                break;

            case 18:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷��� �����Ѵٸ� ���� ������ ������ų �� �ֱ� ������ ������ �����ϴ��� ���� ������ �����߽��ϴ�.", 1);
                break;

            case 19:

                Vector3 position = Secretary.transform.localPosition;
                position.x = 200;
                Secretary.transform.localPosition = position;

                NPC_2.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("����Ʊ����ڳװ� �� ������ ��? �ݰ���.", 1);
                break;

            case 20:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� �Ұ��� �帮�ڽ��ϴ�. �̺�����", 1);
                break;

            case 21:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�� �̸��� ������ũ��� �ϳ�, ETI ���� ������ �ְ� �濵�� ���� �ð� �ֳ�.", 1);
                break;

            case 22:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("������ũ���� ETI ���� ������ �����Ͻ� ���Դϴ�.", 1);
                break;

            case 23:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� ����� �������� ����ü�� ����� ������� �ο�� ���� �ý����� ����� ��� ������ ��� �Ͻô� �� ��� ������ũ���� �����Դϴ�.", 1);
                break;

            case 24:
                    ScreenLock.gameObject.SetActive(true);
                    SelectQ.gameObject.SetActive(true);
                    _Select_text1.text = "�˰� �Ǿ� �����Դϴ�.";
                    _Select_text2.text = "������ũ�Բ��� �̰����� ���� �Ϸ�?";

                if (select1 == true || select2 == true){
                    CountClick += 1;
                    select1 = false;
                    select2 = false;
                    Debug.Log("�Ѿ����.");
                }
                break;

                

            case 25:

                ScreenLock.gameObject.SetActive(false);
                SelectQ.gameObject.SetActive(false);
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�主�� �ʿ� ������ ��Ǻ��� ���ϰڳ�.", 1);
                break;

            case 26:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�ڳ׿��� ������ ��θӸ��� �����ϱ� ���� �̳� ������ ��Ź�ϰ� �ͳ�.", 1);
                break;

            case 27:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("���� �츮 ��Ȳ�� ���� ��Ȳ�̶�� �� �� ����.", 1);
                break;

            case 28:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�׷��� ���� ��Ȳ�� �����ϱ� ���� ��Ը� ������ �ʿ��ϳ�.", 1);
                break;

            case 29:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("����� ������ ������� ����, ������ �ϸ�Ÿ���Ѵٸ� �츮�� �±⸦ ���� �� �ִٳ�.", 1);
                break;

            case 30:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�ڳ׿��� ������ ã�ƿ����� �ڳ׶�� �̰ܳ� �Ŷ�� �ϰ� �ֳ�, ��Ź�ϳ� �̹� ���⸦ �Ѱܳ� �� �ֵ��� ���� �����ְԳ�.", 1);
                break;


            case 31:
                ScreenLock.gameObject.SetActive(true);
                SelectQ.gameObject.SetActive(true);
                _Select_text1.text = "�ϰ� �ð� �ֽʽÿ�.";
                _Select_text2.text = "���������, �ּ��� ���ϰڽ��ϴ�.";

                if (select1 == true || select2 == true)
                {
                    Debug.Log("�Ѿ�� 31��");
                    //CountClick += 1;
                }
                break;

            case 32:
                ScreenLock.gameObject.SetActive(false);
                SelectQ.gameObject.SetActive(false);

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("����ϰ� �ְڳ�.", 1);

                break;


            case 33:
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);

                break;

            default:
                //_index.DOText("", 1);
                _index.text = "��ȭ ������. ���⼭ â ���� ���⼭ �� ����.";
                break;


        }
    }




    public void InputCountNum()
    {
        CountClick += 1;

        Debug.Log(CountClick);
    }

    private void Change_Alpha_Secretary(bool Alpha_Secretary)
    {


        if(Alpha_Secretary == true)
        {
            Secretary.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if(Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
        }


        //if (Alpha_Secretary == true) {      //���� ��
        //    Color color_Secretary = Secretary_image.color;
        //    for (float i = 1.0f; i >= 0.6f; i -= 0.01f)
        //    {
        //        color_Secretary.r = i;
        //        Secretary_image.color = color_Secretary;
        //    }
        //}

        //else if(Alpha_Secretary == false){  //���� ����
        //    Color color_Secretary = Secretary_image.color;
        //    for (float i = 0.6f; i >= 1.0f; i += 0.01f)
        //    {
        //        color_Secretary.a = i;
        //        Secretary_image.color = color_Secretary;
        //    }
        //}
    }

    private void Change_Alpha_SNPC_1(bool Alpha_NPC_1)
    {
        if(Alpha_NPC_1 == true)
        {
            NPC_1.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Normal_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
        }

        if(Alpha_NPC_1 == false)
        {
            NPC_1.GetComponent<Image>().color = new Color(1, 1, 1);
            Normal_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }
    }





}
