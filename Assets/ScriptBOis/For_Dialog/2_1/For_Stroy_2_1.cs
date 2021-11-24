using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_1 : MonoBehaviour
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
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //����â
    public Button SelectQ_B_1;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Button SelectQ_B_2;          //����â�� �ִ� ��ȣ�ۿ� ��ư
    public Text _Select_text1;          //����â�� ���� �ؽ�Ʈ1
    public Text _Select_text2;          //����â�� ���� �ؽ�Ʈ2

    bool select1 = false;
    bool select2 = false;

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


    //���� ���ڿ��� ����� �밡�� ������, ���� ����ũ ���� ����(High Risk High Return)

    //.setDelay(?);


    public void ForStory_2_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("ETI ���� ���� ������ �繫��", 1);
                break;


            case 2:
                Secretary.gameObject.SetActive(true);

                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� �ӹ��� ���� �̻����� ������ ��Ȳ�̾����ϴ�. ū ���� ���� ������ �������� ���� õ�������Դϴ�.", 1);
                break;

            case 3:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("������ ���α� ����ü�� ���������� ����� �߰����� ��ȹ�� �ִٴ� ��ǹۿ� �˾Ƴ��� ���߽��ϴ�.", 1);
                break;

            case 4:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("����� ������ ������ �ʾұ� ������ �����ڴԲ� �߰� �ӹ��� ��Ź�帮�ڽ��ϴ�.", 1);
                break;


            case 5:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�ֱ� ���� �������� ����� �ʴ� �������� �߰ߵȴٴ� ��� �����Դϴ�. " +
                    "���� ������ �̻��� �߻��� ���� �ľ��� �ֽñ� �ٶ��ϴ�.",1);
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
