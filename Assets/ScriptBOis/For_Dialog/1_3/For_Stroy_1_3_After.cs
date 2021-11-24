using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_3_After : MonoBehaviour
{
    public GameObject ScreenLock;       //��ư �������� �� �ɱ�

    private int CountClick = 0;
    public Text _index;                 //��ȭ ����
    public Text _name;                  //�̸�
    public GameObject Secretary;        //�� ��������Ʈ
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


    //���� ���� ��ȣ ��

    //.setDelay(?);

    public void ForStory_3_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("��ð��� ���� ���� �����Ͻ��ϸ��� ��������.", 1);
                break;


            case 2:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("���� �ɷ��� ����� �����Ͻ��ϸ��� ���ڴ��ϰ�, ������ ����ƴ�.", 1);
                break;

            case 3:
                Secretary.gameObject.SetActive(true);
                NPC_1.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���ڵ� �������� �ʿ��� �� �̻� �»��� ����. �����ض�.", 1);
                break;

            case 4:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("�־��̱���, ���� ���� �̷� ��ì������ ���ϴٴϡ�", 1);
                break;

            case 5:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�̹� ������ ������ �𸣰�����, ���ǹ��� ���׺��ٴ� ������ �����ϴ� ���� ���� ���̴�. ", 1);
                break;

            case 6:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("���ǹ�? ���������� ��ŵ��� ����ϴ� ���� ������ �޾� �̰����� ��Ȳ �ľ��� �� �� �𸣴±���.", 1);
                break;

            case 7:
                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("������ ���� �̹� ������ �޼��߽��ϴ�.", 1);
                break;


            case 8:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("������ �̹� �޼��ߴٰ�?", 1);
                break;

            case 9:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                NPC_1.gameObject.SetActive(true);
                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("��ŵ��� �������δ� ���� ���� ���� �Ұ����մϴ�.", 1);
                break;

            case 10:

                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("���� �� ������ŭ�� ��ŵ��� �̰�ٰ� �����ϰ�����, ��ŵ��� ����� �ʿ����Դϴ�.", 1);
                break;

            case 11:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("...", 1);
                break;

            case 12:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("���� �ƹ��� �غ� ���� �̰��� ������ ���� ������ �����߽��ϱ�?", 1);
                break;


            case 13:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�����?", 1);
                break;

            case 14:

                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("���� ������ ���� ��ŵ��� �ü��� ������ ���� �̳� ������ ���Դϴ�.", 1);
                break;


            //���� ��ο����� ��Ʈ

            case 15:
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);

                break;

            case 16:


                NPC_1.gameObject.SetActive(false);
                Secretary.gameObject.SetActive(false);

                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("�̰����� ���� �� ���� �ϼ��߽��ϴ�. ������ ��ſ��� �ñ�ڽ��ϴ�.", 1);
                break;


            case 17:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�׵��� ����߾�, ������ ������ �ð��� �����Ͻ��ϸ�.", 1);
                break;

            case 18:
                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("�׷�, ������ �߹����� ���ְڽ��ϴ� ETI��", 1);
                break;

            case 19:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�� �༮ ����?!", 1);
                break;

            case 20:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("����, �� �ڸ����� �����ض�! ���� ������ �Ϸ��� �Ѵ�!", 1);
                break;

            




            case 21:
                //[����� ���� �� �鸮�� ȿ����] �ƽ� �ؽ�Ʈ�� ��°� ���ÿ� �鸮���� ����
                //���̵� ��
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("...��� �ߴ�", 1);
                break;

            case 22:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("...�� �༮�� �� ������ ���� ���̾�, �� �� �༮ ���� ������ ���̾�.", 1);
                break;

            case 23:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("���, ������ ���� ������ ģ���� ���ڳס�", 1);
                break;


            case 24:
                UI_Dialoue.gameObject.SetActive(false);
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);

                _name.text = "";
                _index.DOText("", 1);


                Timer += Time.deltaTime;
                if(Timer > 3)
                {
                    //�� ü����
                }


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
        }

        if(Alpha_NPC_1 == false)
        {
            NPC_1.GetComponent<Image>().color = new Color(1, 1, 1);
        }
    }





}
