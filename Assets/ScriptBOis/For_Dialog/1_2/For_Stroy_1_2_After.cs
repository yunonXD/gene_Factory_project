using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_2_After : MonoBehaviour
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
    public GameObject PlayerData;
    public GameObject MainBG_2;
    public GameObject FadeBoi;          //���̵� �� �ƿ� ��ų ���� ȭ��
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //����â
    public Button SelectQ_B_1;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Button SelectQ_B_2;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Text _Select_text1;          //����â�� ���� �ؽ�Ʈ1
    public Text _Select_text2;          //����â�� ���� �ؽ�Ʈ2

    bool select1 = false;
    bool select2 = false;


    private Animator animator;

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


    //���� �����Ʒ� ��


    public void ForStory_2_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("�Ʒ��� �����ϰ�, �Ʒ� ����� �м��� ����� ������ �����ƿ��� �����ߴ�.", 1);
                break;


            case 2:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("���ηκ����� �м� ����� ��ٸ��� ��, ��� �ġ�", 1);
                ForStory_FMod.instance.Printer();

                //[�μ�⿡�� ���̰� ��µ� �� �߻��ϴ� ȿ����] �ƽ� �ؽ�Ʈ�� ��°� ���ÿ� �鸮���� ����
                break;

            case 3:
                Secretary.gameObject.SetActive(true);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("����ϼ̽��ϴ�, �����ڴ�.", 1);
                break;

            case 4:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� ��ġ�� �ö������� �������� ����ϼ̽��ϴ�.", 1);
                break;

            case 5:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�� ������� ���� �ʿ��� ������ �߻��ϴ��� ������ �� ���� ������ �Ǵܵ˴ϴ�.", 1);
                break;

            case 6:

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷���, ������ ��� ������ ���� ������ ������ �𸨴ϴ�. � ��Ȳ������ ħ���ϰ� ��ó�Ͻʽÿ�.", 1);
                break;

            case 7:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷� ���� �Ʒÿ� �˵��� �ϰڽ��ϴ�.", 1);
                break;

            case 8:

                FadeBoi.gameObject.SetActive(true);

                break;


            case 9:

                Secretary.gameObject.SetActive(false);
                _name.text = "";
                _index.DOText("", 1);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);

                MainBG_2.gameObject.SetActive(true);

                break;



            case 10:
                
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("ETI ���� ���� ���� ���� ��", 1);
                break;

            case 11:

                NPC_1.gameObject.SetActive(true);
                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("������ ������ �θ��±���, ETI ���� ����.", 1);
                break;

            case 12:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("�׷���, ��ŵ��� �ൿ�� ��ŵ��� ����� ������ ���߱⸸ �� ���Դϴ�.", 1);
                break;

            case 13:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("������ ����� ��ٸ��� �׺в� ���� ���� �帮�� ������", 1);
                break;

            case 14:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("�ٽ� �ѹ� �� �����ְڽ��ϴ�, ����� �ڵ��̿�.", 1);
                break;


            case 15:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("��� ������ ������� ��ŵ��� ����� �ʿ����Դϴ�.", 1);
                break;

            case 16:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("�ִ��� �߹����� �غ��ʽÿ� ETI ���� ����..", 1);
                break;

            case 17:
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);
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

}
