using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_3_After : MonoBehaviour
{
    public GameObject ScreenLock;       //��ư �������� �� �ɱ�

    private int CountClick = 0;
    public Text _index;                 //��ȭ ����
    public Text _name;                  //�̸�
    public GameObject MainBG_1;          //�⺻ ���� BG
    public GameObject MainBG_2;         //�ٲ� ���� BG
    public GameObject MainBG_3;         //�ٲ� ����2 BG

    public GameObject Secretary;        //�� ��������Ʈ
    public GameObject Normal_eyes;      //�Ϲ� ǥ��
    public GameObject Close_eyes;       //���� ��
    public GameObject Smile_eyes;       //���� ��
    public GameObject Surprise_eyes;    //��� ��
    public GameObject PlayerData;
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //����â
    public Text _Select_text1;          //����â�� ���� �ؽ�Ʈ1
    public Text _Select_text2;          //����â�� ���� �ؽ�Ʈ2
    public Button SelectQ_B_1;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Button SelectQ_B_2;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public GameObject FadeBoi;          //���̵� �� �ƿ� ��ų ���� ȭ��
    public GameObject UI_Dialoue;
    public GameObject MoveBlackScreen;


    private Animator animator;

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


    //���� ���̻� ������ ���� ����.

    //.setDelay(?);

    public void ForStory_2_3()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("����콺 óġ �������κ��� �� ��, ETI ���� ���� ����� �� ��", 1);
                break;


            case 2:
                //���ȶȶȡ��̶�� �ƽ� �ؽ�Ʈ�� ���� �� ���� �ε���� �߻��ϴ� ȿ������ ���´�.

                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("�ȶȶ�", 1);
                break;

            case 3:
                NPC_1.gameObject.SetActive(false);
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("������.", 1);

                break;

            case 4:

                MoveBlackScreen.gameObject.SetActive(true);
                MoveBlackScreen.GetComponent<MoveBlackScreen>().MoveR_TO_L();

                break;

            case 5:
                MainBG_1.gameObject.SetActive(false);
                MainBG_2.gameObject.SetActive(true);
                MoveBlackScreen.GetComponent<MoveBlackScreen>().MoveR_TO_L_Num2();
                break;


            case 6:

                NPC_1.gameObject.SetActive(true);
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�� �׷��� �ֳ�. � �ɰ�.", 1);

                break;

            case 7:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�ڳ��� ���ݱ����� ����� �ó�, �̰� ���� �������� ������ �ϱ��� �ʴ±�.", 1);
                break;


            case 8:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�ڳװ� �����ٸ� �츮 ETI ���� ������ �̹� ������ �Ѱܳ��� ������ ���̳�.", 1);
                break;

            case 9:
                ScreenLock.gameObject.SetActive(true);
                SelectQ.gameObject.SetActive(true);
                _Select_text1.text = "�ؾ� �� ���� �� �ͻ��Դϴ�.";
                _Select_text2.text = "�����̽ʴϴ�.";

                if (select1 == true || select2 == true)
                {
                    CountClick += 1;
                    select1 = false;
                    select2 = false;
                    Debug.Log("�Ѿ����.");
                }
                break;


            case 10:
                ScreenLock.gameObject.SetActive(false);
                SelectQ.gameObject.SetActive(false);
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("����, ��յ� ���ϸ� ��Ƴ��� �Ǳ� �����̳�.", 1);
                break;

            case 11:

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�̹� ���� ���� ������ �ڳ׿��� �������� �� �� ���Ǵ� �ƴϾ��׸�, " +
                    "�׸�ŭ �츮�� ������ ��Ȳ���� ������ �ָ� ���ڳ�. �׷��� �Ǹ��ϰ� �س� �־���.", 1);
                break;

            case 12:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�׷��� �츮�� ���� �� ��ǳ�츦 ��� ���ܹ��ϼ�, �ٸ� ���� �Ű� �� �ܸ��� ���ٳ�.", 1);
                break;

            case 13:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�̹� �ӹ����� �츮�� �̷��� ��Ƴ��� ������, �ڳ��� ���� ũ�ٰ� �����ϳ�.", 1);

                break;

            case 14:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("���� �̷��� ����ִ� �͵�, ������ �е��� �ϱ� ���� ���� ���� ����� �� �ֱ� �����̶��.", 1);

                break;


            case 15:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("������ �ڳ� �޶�. �ڳ� ���� ����, ��ɵ� ����. ��� ������ ū���� �̷�ɼ�.", 1);

                break;

            case 16:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("������ �е��� �ڳ׸� ������ �� ����̾�, �ڳ׸� ���Ѵٸ� ���⺸�� �� ���� ������ ���� �� �ִٳ�." +
                    " �����ݵ� ���� ���Գ�, ���� �ε��� �� �״�.", 1);

                break;


            case 17:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�ڳ׸� ���Ѵٸ�, �� ȸ�縦 �׸��ΰ� ������ �װ����� ���ϰ� ���� �� �־�.", 1);
                break;

            case 18:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("��å�� ���� �ʿ� ����. �ڳ� �̹� �츱 ���� ������� �ʾҴ°�. �� ������ ���ο��� ����, �ູ�� ���� �� �ڰ��� �����.", 1);
                break;

            case 19:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("������ �ʰڴٰ�? ������ ���� ���� ������ �� ������ ������ �� ����. " +
                    "������ �Ҿ��� �ٽ� �ѹ� Ÿ������ ����, �׶� ���� �ٽ� ����ų �� ���� �ɼ�.", 1);
                break;

            case 20:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�ƹ���, ���� ���� ������ �ʿ�� ���ٳ�, õõ�� �� ������ ����.", 1);
                break;

            case 21:

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�ڳ��� ������ �׷��ٸ� �� �̻� �������� �ʰڳ�, ETI�� �ڳ� ���� ����� �ξ�, ���� �����̳�.", 1);
                break;

            case 22:

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�׷� ���߿� �� �������.", 1);
                break;

            case 23:
                FadeBoi.gameObject.SetActive(true);

                break;

            case 24:
                MainBG_2.gameObject.SetActive(false);
                MainBG_3.gameObject.SetActive(true);

                NPC_1.gameObject.SetActive(false);
                _name.text = "";
                _index.DOText("", 1);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);

                break;

            case 25:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("ETI ���� ���� �繫��.", 1);

                break;

            case 26:
                Secretary.gameObject.SetActive(true);
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("������ ���ƿ��ż� �����Դϴ�. �����ڴ�.", 1);
                break;

            case 27:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�ٷ� ���� �ӹ��� ���Խ��ϴ�. �ٷ� �ӹ��� �����ϰڽ��ϴ�.", 1);
                break;

            case 28:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�����ε� �� ��Ź�帳�ϴ�. �����ڴ�.", 1);
                break;

            case 29:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("[������ ���� END]", 1);
                break;

            case 30:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("�÷����� �ּż� �����մϴ�.", 1);
                break;


            default:
                if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 == true)
                {
                    SceneManager.LoadScene("RecordMemoryScene");
                }
                break;


        }
    }


    public void QuitButtonBoi()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 == true)
        {
            SceneManager.LoadScene("RecordMemoryScene");
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
            Smile_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if(Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
            Smile_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
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
