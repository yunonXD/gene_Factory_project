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
    public GameObject PlayerData;
    public GameObject MainBG_2;


    public GameObject SelectQ;          //����â
    public Button SelectQ_B_1;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Button SelectQ_B_2;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public GameObject FadeBoi;          //���̵� �� �ƿ� ��ų ���� ȭ��
    public GameObject FadeBoi_ALL;          //��üȭ�� ���̵��ξƿ�

    public GameObject UI_Dialoue;

    private Animator animator;
    private Animator animatorAll;
    private float Timer = 0;

    bool select1 = false;
    bool select2 = false;

    private void Awake()
    {
        animator = FadeBoi.GetComponent<Animator>();
        animatorAll = FadeBoi_ALL.GetComponent<Animator>();
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
                FadeBoi_ALL.gameObject.SetActive(true);

                break;


            case 4:
                MainBG_2.gameObject.SetActive(true);
                _name.text = "";
                _index.DOText("", 1);

                animatorAll.SetBool("FadeIn", true);
                animatorAll.SetBool("FadeOff", false);

                break;


            case 5:

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���ڵ� �������� �ʿ��� �� �̻� �»��� ����. �����ض�.", 1);
                break;

            case 6:


                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("�־��̱���, ���� ���� �̷� ��ì������ ���ϴٴϡ�", 1);
                break;

            case 7:

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�̹� ������ ������ �𸣰�����, ���ǹ��� ���׺��ٴ� ������ �����ϴ� ���� ���� ���̴�. ", 1);
                break;

            case 8:

                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("���ǹ�? ���������� ��ŵ��� ����ϴ� ���� ������ �޾� �̰����� ��Ȳ �ľ��� �� �� �𸣴±���.", 1);
                break;

            case 9:
                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("������ ���� �̹� ������ �޼��߽��ϴ�.", 1);
                break;


            case 10:

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("������ �̹� �޼��ߴٰ�?", 1);
                break;

            case 11:


                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("��ŵ��� �������δ� ���� ���� ���� �Ұ����մϴ�.", 1);
                break;

            case 12:

                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("���� �� ������ŭ�� ��ŵ��� �̰�ٰ� �����ϰ�����, ��ŵ��� ����� �ʿ����Դϴ�.", 1);
                break;

            case 13:

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("...", 1);
                break;

            case 14:

                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("���� �ƹ��� �غ� ���� �̰��� ������ ���� ������ �����߽��ϱ�?", 1);
                break;


            case 15:

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�����?", 1);
                break;

            case 16:

                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("���� ������ ���� ��ŵ��� �ü��� ������ ���� �̳� ������ ���Դϴ�.", 1);
                break;

            case 17:
                FadeBoi.gameObject.SetActive(true);

                break;

            case 18:


                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("�̰����� ���� �� ���� �ϼ��߽��ϴ�. ������ ��ſ��� �ñ�ڽ��ϴ�.", 1);
                break;


            case 19:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("�׵��� ����߾�, ������ ������ �ð��� �����Ͻ��ϸ�.", 1);
                break;

            case 20:
                _name.text = "�����Ͻ��ϸ�";
                _index.DOText("", 1);
                _index.DOText("�׷�, ������ �߹����� ���ְڽ��ϴ� ETI��", 1);
                break;

            case 21:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�� �༮ ����?!", 1);
                break;

            case 22:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("����, �� �ڸ����� �����ض�! ���� ������ �Ϸ��� �Ѵ�!", 1);
                break;


            case 23:
                _name.text = "";
                _index.DOText("", 1);

                ForStory_FMod.instance.Signal_off();

                break;


            case 24:

                MainBG_2.gameObject.SetActive(false);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("...��� �ߴ�", 1);
                break;

            case 25:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("...�� �༮�� �� ������ ���� ���̾�, �� �� �༮ ���� ������ ���̾�.", 1);
                break;

            case 26:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("���, ������ ���� ������ ģ���� ���ڳס�", 1);
                break;


            case 27:
                UI_Dialoue.gameObject.SetActive(false);
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);

                _name.text = "";
                _index.DOText("", 1);

                StartCoroutine(CountingameSceneScene());

                break;


            default:


                if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == false)
                {
                    SceneManager.LoadScene("inGameScene");
                }

                if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 == true)
                {
                    SceneManager.LoadScene("RecordMemoryScene");
                }
                break;


        }
    }


    IEnumerator CountingameSceneScene()
    {

        yield return new WaitForSeconds(3.0f);

        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == false)
        {
            SceneManager.LoadScene("inGameScene");
        }

        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between1 == true)
        {
            SceneManager.LoadScene("RecordMemoryScene");
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


}
