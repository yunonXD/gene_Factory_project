using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_1_After : MonoBehaviour
{
    public GameObject ScreenLock;       //��ư �������� �� �ɱ�

    private int CountClick = 0;
    public Text _index;                 //��ȭ ����
    public Text _name;                  //�̸�
    public GameObject Secretary;        //�� ��������Ʈ
    public GameObject Normal_eyes;      //�Ϲ� ǥ��
    public GameObject Close_eyes;       //���� ��
    public GameObject Smile_eyes;       //���� ��
    public GameObject Surprise_eyes;    //��� ��
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //����â
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


    //���� ���ڿ��� ����� �밡�� ������, ���� ����ũ ���� ����(High Risk High Return) after

    //.setDelay(?);
    public void ForStory_2_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("...", 1);
                break;


            case 2:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("�ӹ� �Ϸ� ��, �����ƿ��� ���� �Ϸ�.", 1);
                break;

            case 3:
                FadeBoi.gameObject.SetActive(true);
                break;

            case 4:
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);

                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("", 1);
                break;

            case 5:

                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("����� ������ �����ơ�", 1);
                break;

            case 6:
                //[���� �� �� �鸮�� ȿ����] �ƽ� �ؽ�Ʈ�� ��°� ���ÿ� �鸮���� ����
                break;

            case 7:
                Secretary.gameObject.SetActive(true);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� ��Ȳ�� �������� �ξ� �� �ɰ��մϴ�. ???��.", 1);
                break;


            case 8:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�����ڴ��� ���翡 ������, ������ ���񺸴� ���� �������� ������ �� ���� �Ҹ��� ��Ȳ�̶�� �� �� �ֽ��ϴ�.", 1);
                break;

            case 9:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� �����̰� �ִ� ��Ȳ���� ���� �� �� ��ó�� �ִٰ� �� �� �ֽ��ϴ�.", 1);
                break;

            case 10:

                Vector3 position = Secretary.transform.localPosition;
                position.x = 200;
                Secretary.transform.localPosition = position;


                NPC_1.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("...", 1);
                break;

            case 11:

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�츮�� �׵��� �չٴ� ���� �ִ� ���ΰ���.", 1);
                break;

            case 12:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�ƹ����� ������ ���� ���� �����ΰ�?", 1);
                break;


            case 13:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�㳪 �׷� ��졦", 1);
                break;

            case 14:

                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�츮�� �Դ� ���� ���� ��� ���� �߻��ϰ���.", 1);
                break;


            case 15:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("��, �� �������δ� ���� �� ���� ���� ���� ���� ������ ���Դϴ�.", 1);
                break;

            case 16:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("������ �Ϸ��� ��� ������ ����ũ�� �����ؾ� �ϴ� ������.", 1);
                break;


            case 17:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷��� �̹� ���� �ʹ� ���赵�� �����ϴ�. ��� �ٸ� ��츦 ����ؼ� �ִ��� ������ ������Ρ�", 1);
                break;

            case 18:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("ȣ���̸� ��� ���ؼ��� ȣ���� ���� �� �� �˾ƾ� �ϳ�.", 1);
                break;

            case 19:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("������ �����, �� �ð��η� ���� ������ ��� �����ϰڳ�, ������.", 1);
                break;

            case 20:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�� �������� �ӹ��� ����μ� ������ �ʿ䰡 ����.", 1);
                break;

            case 21:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�˰ڽ��ϴ�.", 1);
                break;

            case 22:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷��顦������ �����ڴ��� �ð� �ִ� �ӹ��� ��� ó���ϴ� ���� ���ڽ��ϱ�?", 1);
                break;

            case 23:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�� ������ ���� �ذ��ϵ��� ����, �� ���� ������ �ذ��ϱ� ���� �ι��� ã�� �����.", 1);
                break;


            case 24:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�׷��� ���� ������, �� �����ڡ������ÿ� ������ �ִ°�?", 1);
                break;

            case 25:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("��?", 1);
                break;

            case 26:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�װǡ������ ���� �����ϴٸ�����", 1);
                break;

            case 27:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("???��, ��������", 1);
                break;

            case 28:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("���˴밡 �ִٰ� ����Ⱑ ������ ������ �ʴ� ������, ����⸦ ������ �ŷ����� �̳��� �ʿ��� ���̳�.", 1);
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
            Surprise_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Normal_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if(Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
            Surprise_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
            Normal_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
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
        }

        if(Alpha_NPC_1 == false)
        {
            NPC_1.GetComponent<Image>().color = new Color(1, 1, 1);

        }
    }





}
