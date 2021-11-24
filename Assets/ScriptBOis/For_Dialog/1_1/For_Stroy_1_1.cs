using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_1 : MonoBehaviour
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


    //.setDelay(?);
    public void ForStory_1_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("ETI ���� ���� �繫�ǿ� �����ߴ�.", 1);
                break;


            case 2:
                _name.text = "";
                _index.DOText("���� ������ ��ȹ�� ����, ���� �Ʒ��� ������ ��ȹ�̾�������", 1);
                break;

            case 3:
                _name.text = "������";
                _index.DOText("�۱��մϴ�. �����ڴԡ�", 1);
                Secretary.gameObject.SetActive(true);
                break;

            case 4:
                _name.text = "������";
                _index.DOText("������ ��ȹ�� ������ �߻��Ͽ�, ���� ��ȹ�� ������ ������ϴ�.", 1);
                break;

            case 5:
                    ScreenLock.gameObject.SetActive(true);
                    SelectQ.gameObject.SetActive(true);
                    _Select_text1.text = "�����̿�?";
                    _Select_text2.text = "��� ��Ȳ�ΰ���?";

                    if (CountClick == 5 && select1 == true || select2 == true)
                    {
                        Debug.Log("�Ѿ��");
                        select1 = false;
                        select2 = false;
                        CountClick += 1;
                    } 
               
                break;

            case 6:
                SelectQ.gameObject.SetActive(false);
                ScreenLock.gameObject.SetActive(false);
                _name.text = "������";
                _index.DOText("���翡�� ���� ������ ��û�ϼ̽��ϴ�...", 1);
                break;

            case 7:
                _name.text = "������";
                _index.DOText("����� ������� �ֱ� ���� ������ �α� ������ �������� ������ ���߽��ϴ�.", 1);
                break;

            case 8:
                _name.text = "������";
                _index.DOText("�̷��� �������� ������ ������ �е��� �����ֽ��ϰ� �ִ� ��Ȳ�Դϴ�.", 1);
                break;

            case 9:
                _name.text = "������";
                _index.DOText("���翡���� �������� ó���ϴ� �Ͱ� ���ÿ� �������� �����ϴ� ������ �ľ��ϴ� ���� �ӹ��Դϴ�.", 1);
                break;
            case 10:
                _name.text = "������";
                _index.DOText("����� ���ÿ� ����, �����ڴ��� ������ �ʿ��մϴ�.", 1);
                break;

            case 11:
                _name.text = "������";
                _index.DOText(" �����ڴ��� �Ի����� �� �� �Ǿ���, �Ʒ� Ƚ���� ����������" +
                    " ���� ���� �η°� �ð��� �����ϱ� ������ ��¿ �� ���ٰ� �Ǵ��߽��ϴ�.", 1);
                break;

            case 12:
                _name.text = "������";
                _index.DOText("�׷��� �����ڴ��� �Ʒ� ������ ����غ����� �� �̹� �ӹ��� ����� �ϼ��� �� �������Դϴ�.", 1);
                break;

            default:
                _index.text = "��ȭ ������. ���⼭ â ���� ���⼭ �� ����.";
                break;


        }
    }




    public void InputCountNum()
    {
        CountClick += 1;

        Debug.Log(CountClick);
    }

}
