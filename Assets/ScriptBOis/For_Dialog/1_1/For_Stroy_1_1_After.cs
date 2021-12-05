using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_1_After : MonoBehaviour
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
    public GameObject MoveBlackScreen;
    public GameObject MoveBlackScreen_1;
    public GameObject MoveBlackScreen_2;
    public GameObject SpookyBG;


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


    // ���� ����ġ ���� ��� ��

    //.setDelay(?);
    public void ForStory_1_1_After()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("������������ �������� �����߰� ���� ������ ���ص� �ּ������� ���Ƴ´�.", 1);
                break;


            case 2:
                Secretary.gameObject.SetActive(true);
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�ӹ��� �������̱���, �̹� ������ ��ο����� ���� ���Ͻ� �̴ϴ�.", 1);
                break;

            case 3:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� �����鿡 ���� ���� �𸣴� ���� �ֽ��ϱ�?", 1);
                break;

            case 4:
                _name.text = "";
                ScreenLock.gameObject.SetActive(true);
                SelectQ.gameObject.SetActive(true);
                _Select_text1.text = "�������� ��Ÿ�� ������ ����?";
                _Select_text2.text = "ETI�� ��¼�� �������� ����ϰ� �� �ǰ���?";

                if (CountClick == 4 && select1 == true || select2 == true)
                {
                    Debug.Log("�Ѿ��");
                    select1 = false;
                    select2 = false;
                    CountClick += 1;
                }
                break;

            case 5:
                SelectQ.gameObject.SetActive(false);
                ScreenLock.gameObject.SetActive(false);

                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�������� ����, �̹� ������ ��� ��� ������ �ʿ��߱� ������ ���� �������� �˹��ϰ� ���������", 1);
                break;

            case 6:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� ������ ������ �͵� �翬�մϴ�.", 1);
                break;


            case 7:
                MoveBlackScreen.gameObject.SetActive(true);
                MoveBlackScreen.GetComponent<MoveBlackScreen>().MoveR_TO_L();
                break;

            case 8:

                //[����͸� ų �� �߻��ϴ� ȿ����] �ƽ� �ؽ�Ʈ�� ��°� ���ÿ� �鸮���� ����
                ForStory_FMod.instance.Monitor_On();

                MoveBlackScreen.GetComponent<MoveBlackScreen>().MoveR_TO_L_Num2();
                SpookyBG.gameObject.SetActive(true);
                _name.text = "������";
                //_index.DOText("", 1);
                _index.text="���� ���� �ο�� �ִ� �������� ���� ��� ���ڿ� ����� ����ü�� ���մϴ�.";
                break;


            case 9:
                MoveBlackScreen_1.gameObject.SetActive(true);
                MoveBlackScreen_1.GetComponent<MoveBlackScreen>().MoveR_TO_L();
                break;

            case 10:
                MoveBlackScreen_1.GetComponent<MoveBlackScreen>().MoveR_TO_L_Num2();
                _name.text = "������";
                _index.text="���߿����� ����ü�� ���յǸ鼭 ������ ���� ���� ����ü�� ���� �ɷ�ġ�� �ſ� �پ���ϴ�.";

                break;

            case 11:
                MoveBlackScreen_2.gameObject.SetActive(true);
                MoveBlackScreen_2.GetComponent<MoveBlackScreen>().MoveR_TO_L();

                break;

            case 12:
                MoveBlackScreen_2.GetComponent<MoveBlackScreen>().MoveR_TO_L_Num2();
                SpookyBG.gameObject.SetActive(false);
                _name.text = "������";
                //_index.DOText("", 1);
                _index.text="��������, �⺻������ �ΰ����� �����ϸ� �ΰ����� �������� �����߽��ϴ�.";
                break;

            case 13:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�������� �������� ���� �η��� ������ ���⸦ �޾����ϴ�.", 1);
                break;

            case 14:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText(" ���� ETI ���� ������ ���� ����� ������ ����ü�� ����� �����ϱ� �����߰�" +
                    " ���� �����Ǿ� ���� �־����ϴ�.", 1);
                break;

            case 15:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷��� ������ ���� ��ȭ�ϱ� �����߰� ��ȭ�� ������ ���������� ���� ETI ���� ������" +
                    " ���ظ� �԰� �ٽ� �ѹ� ���⸦ �ް� �Ǿ����ϴ�.", 1);
                break;


            case 16:
                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���ظ� ���� ETI ���� ������ ������ �����ڸ� �����ϱ� ���� " +
                    "�����ڸ� ���� ������ ������ ������ �ñ�� �� ���Դϴ�.", 1);
                break;

            case 17:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷����, ETI ���� ���ܿ� �Ի��Ͻ� ���� �ٽ� �ѹ� ȯ���մϴ� �����ڴ�.", 1);
                break;

            case 18:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���Ŀ� ���� ���� �Ͼ��, ��� �� �������� ���� ���縦 �帳�ϴ�.", 1);
                break;


            case 19:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�׷� ���� �ӹ��� ���� �����ϰڽ��ϴ�.", 1);
                break;

            case 20:
                

                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("�ࡦ", 1);
                ForStory_FMod.instance.Signal_off();
                break;


            case 21:
                //Secretary.gameObject.SetActive(false);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("ä�ο��� ������ ��� ��û�� ���Դ�.", 1);
                break;

            case 22:
                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�˼��մϴ�. ��ø� ��ٷ� �ֽʽÿ���", 1);
                break;

            case 23:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("�����ư� ���� ���� ����� ������ ���ߴ�.", 1);
                break;


            case 24:


                //[�ð� ��ħ�� ������ �� �߻��ϴ� ȿ����] �ƽ� �ؽ�Ʈ�� ����� ���� �� �鸮���� ����
                ForStory_FMod.instance.Clock_Sound(); 

                break;


            case 25:
                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("�������˰ڽ��ϴ�. ���� �����ڴԲ� �����ϰڽ��ϴ�.", 1);
                break;

            case 26:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("��� ���翡�� ������ �޾ҽ��ϴ�. �ٸ� ������ ������ �߻��Ͽ� " +
                    "������ �����Ϸ��� ������ ����Ǿ����ϴ�.", 1);
                break;

            case 27:
                _name.text = "������";
                _index.DOText("", 1);
                _index.DOText("���� �������� ���� ������ �Ʒ��� ��������Դϴ�. " +
                    "���� ���� �Ʒÿ� ���� ������ �����ϰڽ��ϴ�. �����ϼ̽��ϴ� �����ڴ�.", 1);
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
