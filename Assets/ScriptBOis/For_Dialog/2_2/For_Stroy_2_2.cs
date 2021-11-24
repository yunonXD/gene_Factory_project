using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_2 : MonoBehaviour
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


    //���� ������ȣ

    //.setDelay(?);



    public void ForStory_2_2()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                Secretary.gameObject.SetActive(true);
                _name.text = "������";
                _index.DOText("�����ڴ�, ���ο� �ӹ��� �����߽��ϴ�.", 1);
                break;


            case 2:
                //[����͸� ų �� �߻��ϴ� ȿ����] �ƽ� �ؽ�Ʈ�� ����� ���� �� �鸮���� ����
                break;

            case 3:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�� ��ó�� �ִ� ETI ���� ������ �μ� ���忡�� ��� ���� ��ȣ�� �޾ҽ��ϴ�. ", 1);
                break;

            case 4:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�����ڴ��� �ӹ��� �ش� ������ ���� �� ������ Ȯ��, �ش� ��ҿ��� �Ͼ ���� �ľ��ϴ� ���Դϴ�.", 1);
                break;


            case 5:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("������ ������, ���� ���ο� �����ڰ� �������� ���ɼ��� �����ϴ�. " +
                    "�׷��⿡ �̹� �ӹ��� �θ����� �ֿ켱���� �ϰ� ���� ��ü�κ��� ������ ���ѳ��� �մϴ�.", 1);
                break;

            case 6:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� �ܺο� ������ �����ڵ��� Ż������ ���ϵ��� �����ϰ� �־� ������ ������ ���������ϴ� ���� ȿ������ ������ �Ǵܵ˴ϴ�.", 1);
                break;

            case 7:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� ���忡 ��Ƴ��� �����ڰ� ���� ��� ���� ������ �����͸� Ȯ���ؾ� �մϴ�.", 1);
                break;

            case 8:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷��� ���� �ӹ� �Ϸ� ���� ��ٸ��� �ְڽ��ϴ�.", 1);
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

}
