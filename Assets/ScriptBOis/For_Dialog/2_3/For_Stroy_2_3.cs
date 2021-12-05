using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_3 : MonoBehaviour
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
    public GameObject PlayerData;
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //����â
    public Button SelectQ_B_1;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Button SelectQ_B_2;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Text _Select_text1;          //����â�� ���� �ؽ�Ʈ1
    public Text _Select_text2;          //����â�� ���� �ؽ�Ʈ2
    public GameObject FadeBoi;          //���̵� �� �ƿ� ��ų ���� ȭ��


    private Animator animator;
    private bool Alpha_Secretary = false;
    private bool Alpha_NPC_1 = false;

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
                _index.DOText("�� ��, ETI ���� ������ ����� ������ ��...", 1);
                break;


            case 2:
                Secretary.gameObject.SetActive(true);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�ʾ �˼��մϴ� ������ũ��.", 1);
                break;

            case 3:

                ChangeLocation(200);


                NPC_1.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�̹� ������ �츮�Ӹ��� �ƴ� �������� ������ �Ⱥ��� ����Ǵ� �߿��� �����̶��. ", 1);
                break;

            case 4:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("������ ���������� �� ������ ���۵ȴٳ�, ������ �� �� �ִ� ��� �غ� ����ġ���� �ϳ�.", 1);
                break;


            case 5:
                ForStory_FMod.instance.Pen_Sound();
                //[������ �۾��� ���� �� �߻��ϴ� ȿ����] �ƽ� �ؽ�Ʈ�� ����� ���� �� �鸮���� ����

                break;

            case 6:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("����� �Ʊ� ���� ������� Ȯ���߳�. ���� ���ұ� ������.", 1);
                break;

            case 7:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� �Ͽ� �ּ��� ������ ���Դϴ�.", 1);
                break;

            case 8:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׸���, �����ڴ��� �߰� ���� �ް� ���� �𿩵� ���鿡 ���� �������� ���� ���Դϴ�.", 1);
                break;

            case 9:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷��� �������� ���� ���ο� ������ �����ϱ� ���� �߰����� �ð��� �ҿ�� ������ ���Դϴ�.", 1);
                break;

            case 10:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�����ڴ� ������� ������ �����ϵ��� ���ϰ�, �츮�� ���� ������ ���� �غ� �ʿ��ϴ� ���̳�. ", 1);
                break;

            case 11:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("��ɿ� ����, �츮�� ���⼭ ������� ������ �Ѱܳ��� �� ū �Ը��� ������ �����ϱ� ���� ���� �غ��̴� ���̳�.", 1);
                break;

            case 12:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�� ����� ����Դϱ��	", 1);
                break;

            case 13:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("������ ������ ���񿡰� ���� ���ѱ�鼭 ������ �����ϴ� ���� ���鱺�䡦��", 1);
                break;

            case 14:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("������ �е鵵 �̹� ������ �߿��ϱ� �� ����̾�, �̹� ������ ������ ������ �� ������ �����̶��.", 1);
                break;

            case 15:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�߰� �����̶��, ��� �� ������ ������ ���� �ο����� �����Ͻô� �̴ϱ�?", 1);
                break;


            case 16:
                PlayFModUI.instance.GeneDocument();
                //[���̷� �� ������ �ѱ�� ȿ����] �ƽ� �ؽ�Ʈ�� ��°� ���ÿ� �鸮���� ����
                break;

            case 17:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�츮���� ������ �Ҹ��� ��Ȳ�̶��, �����̳� ������ �ϸ�Ÿ���ϱ� ���� �����ڰ� ������ �����Ͽ� �������� ������.", 1);
                break;

            case 18:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�׷� ��Ȳ���� ������ ������ �����ϰ� ����� ���� ��������.", 1);
                break;

            case 19:
                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�̹� ������ ������ �е鿡�� �־ �ణ�� �Ҹ��� ������ ���̾�.", 1);
                break;

            case 20:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷��ٸ� �����ڴ��� ���迡 ó�� ��� �߰� �ηº��� �����ڴ��� �켱���� �����ؾ� �մϱ�?	", 1);
                break;

            case 21:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "������ũ";
                _index.DOText("", 1);
                _index.DOText("�� ������, �״� ������ �츮���� �߿��� ������ �� �� ����.", 1);
                break;

            case 22:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷����ϴ�. �Ի����� �� �� �Ǿ�����, ������ ������ �������� �� ���������� ������ ��ġ�� �ִٰ� �Ǵܵ˴ϴ�.", 1);
                break;

            case 23:
                FadeBoi.gameObject.SetActive(true);
                break;


            case 24:

                ChangeLocation(0);

                NPC_1.gameObject.SetActive(false);

                MainBG_1.gameObject.SetActive(false);
                MainBG_2.gameObject.SetActive(true);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("�ӽ� �繫�� ���Ρ���", 1);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);

                break;

            case 25:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�鸮�ʴϱ�, �����ڴ�?", 1);
                break;


            case 26:
                ForStory_FMod.instance.Signal_connect();
                //[����� ����Ǵ� ȿ����] �ƽ� �ؽ�Ʈ�� ��°� ���ÿ� �鸮���� ����
                break;

            case 27:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("��ȹ��� ������ �����Ͻô��� ����ϼ̽��ϴ�. �̹� ������ ����� ���������� ������ �� ���� �ּ̽��ϴ�.", 1);
                break;

            case 28:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���󺸴� ���� ������ ������ ��° ���� ����� ������ �־ �Ϻ� ���� ���� �ʿ��� ó���ϱ�� �߽��ϴ�.	", 1);
                break;


            case 29:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�����ڴԲ����� ������ ���븦 �����ؾ� �մϴ�. ���� ���� ö���� ��� �߰����� �����Ͻ� �� ���� �Ŷ� �Ͻ��ϴ�.", 1);
                break;

            case 30:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷��� ���ƿ��ñ� ���� ���� �����ϰ� ����ϰڽ��ϴ�. ", 1);
                break;

            case 31:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("������ ���ϴ١�	", 1);
                break;

            case 32:
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);
                break;


            default:
                if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == true)
                {
                    SceneManager.LoadScene("BattleScene2_3");
                }

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

    public void ChangeLocation(int i = 0 )
    {
        Vector3 position = Secretary.transform.localPosition;
        position.x = i;
        Secretary.transform.localPosition = position;
    }

    public void InputCountNum()
    {
        CountClick += 1;

        Debug.Log(CountClick);
    }

    private void Change_Alpha_Secretary(bool Alpha_Secretary)
    {


        if (Alpha_Secretary == true)
        {
            Secretary.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Normal_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Smile_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Surprise_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if (Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
            Normal_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
            Smile_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
            Surprise_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
        }
    }


        private void Change_Alpha_SNPC_1(bool Alpha_NPC_1)
    {
        if (Alpha_NPC_1 == true)
        {
            NPC_1.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);


        }

        if (Alpha_NPC_1 == false)
        {
            NPC_1.GetComponent<Image>().color = new Color(1, 1, 1);


        }
    }



}
