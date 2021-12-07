using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class inGameScene_Tutorial : MonoBehaviour
{
    public GameObject PlayerData;           //���̺굥����
    public GameObject Tutorial;             //Ʃ�丮�����ٺθ�ü
    public GameObject Secretary;            //�׸�׸��
    public GameObject Indicator;            //ȭ��ǥ
    public GameObject GenemapBlocker;       //������ ���� Ŭ�� ������
    public GameObject StageBlocker;       //����â Ŭ�� ������
    public GameObject memoryBlocker;       //������ ���� Ŭ�� ������

    public Text C_name;
    public Text C_Dialogue;

    [Header("==Button Lock==")]
    public GameObject C_GeneSelect;
    private Animator GS_animator;

    public GameObject C_GeneMemory;
    private Animator GM_animator;

    public GameObject C_BattleSelect;
    private Animator MS_animator;


    //==================================ingameScene==========================================//

    private int Yeeter = 0;               //���̾�α� �о�� ���̺����� �޾ƿ� ��Ʈ��

    private GameObject Option;


    private void Start()
    {
        Option = GameObject.Find("GameManager");

        GS_animator = C_GeneSelect.GetComponent<Animator>();
        GM_animator = C_GeneMemory.GetComponent<Animator>();
        MS_animator = C_BattleSelect.GetComponent<Animator>();

        C_GeneSelect.GetComponent<Button>().interactable = false;
        GS_animator.SetTrigger("Disabled");

        C_GeneMemory.GetComponent<Button>().interactable = false;
        GM_animator.SetTrigger("Disabled");

        C_BattleSelect.GetComponent<Button>().interactable = false;
        MS_animator.SetTrigger("Disabled");

    }


    private void CheckTutorial()
    {
        //Ʃ�丮�� ������ ���� _Gene_Between3 �Ǻ�
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {
            Tutorial.gameObject.SetActive(true);
            //esc �۵� ��ũ��Ʈ DEAD
            Option.GetComponent<Button_Editor>().enabled = false;

        }
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == true)
        {
            Tutorial.gameObject.SetActive(false);
            //esc �۵� ��ũ��Ʈ Alive
            Option.GetComponent<Button_Editor>().enabled = true;

            C_GeneSelect.GetComponent<Button>().interactable = true;
            GS_animator.SetTrigger("Normal");

            C_GeneMemory.GetComponent<Button>().interactable = true;
            GM_animator.SetTrigger("Normal");

            C_BattleSelect.GetComponent<Button>().interactable = true;
            MS_animator.SetTrigger("Normal");

            Destroy(Tutorial);
            Destroy(this);      //�Ⱦ��� ����
        }
    }


    void Update()
    {
        CheckTutorial();
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;
    }

    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "����Ʈ�̸�ŭ ���̺�");
    }


    public void inGameSceneTutorial()
    {
        Yeeter = Yeeter + 1;
        PointSaver();
        
        switch (Yeeter)
        {
            case 0:
                C_name.text = "";
                C_Dialogue.text = "";
                break;

            case 1:
                C_name.text = "???";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���� ��ħ�Դϴ� �����ڴ�.", 1);
                break;

            case 2:
                C_name.text = "???";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("ETI ���� �繫�ǿ� ó�� ���Űǵ�, ����� ��ʴϱ�?", 1);
                break;

            case 3:
                C_name.text = "???";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�����ڴԲ��� ETI ���� ���ܿ� �����Ͻ� ���� ���� ���ϵ帳�ϴ�.", 1);
                break;

            case 4:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�켱 �� �Ұ��� �帮�ڸ�, �� �̸��� �����ƶ�� �մϴ�." +
                    " �����ڴ��� ���� ���Դϴ�.",1);
                break;

            case 5:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("������ �����ƶ�� �θ��ø� �˴ϴ�. �׷��� ������ �����ڴ����� �θ��ڽ��ϴ�", 1);
                break;

            case 6:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���ú��� �����ڴ��� ETI ���� ������ ������ �����ϴ� �������Դϴ�.", 1);
                break;

            case 7:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�����ڴԲ��� �� ���� �� �س� �� ������ ������ �ǽŴٰ��?", 1);
                break;

            case 8:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�Ƚ��ϼ���, ETI ���� ������ ������ ������ ���� ������ ���� �����ڸ� �����մϴ�.", 1);
                break;

            case 9:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�׷� ������ ������ ���� ����ϼ�����, �����ڴ��� �и� ���������� �̴ϴ�.", 1);
                break;

            case 10:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�׸��� ���� �Ʒÿ����� �����ڴ��� �Ͽ� �ͼ����� �� �ֵ��� ���� ������ �帱 �����Դϴ�.", 1);
                break;

            case 11:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("��, �ϴ� ������ ������ ��ȯ�غ����� ����.", 1);

                C_GeneSelect.GetComponent<Button>().interactable = true;
                GS_animator.SetTrigger("Normal");

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(613f, 0f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
                GenemapBlocker.gameObject.SetActive(true);
                break;


            case 23:

                C_name.text = "";
                C_Dialogue.DOText("", 1);
                break;


            case 24:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���� ���������� �����ϱ� ���� �������� â�� Ŭ���� �ֽʽÿ�.", 1);

                Secretary.gameObject.transform.localPosition = new Vector3(730f, 43f, 0);

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(-2f, 7f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -0f);

                StageBlocker.gameObject.SetActive(true);

                C_BattleSelect.GetComponent<Button>().interactable = true;
                MS_animator.SetTrigger("Normal");

                break;

                //������ ������ 33���� ����

            case 33:
                C_name.text = "";
                C_Dialogue.DOText("", 1);

                break;


            case 34:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�Ʒ��� ���������� �Ϸ��߽��ϴ�.", 1);

                break;

            case 35:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���� �� ���丮�� ���� ������ ��� �����ҿ��� Ȯ���� �����մϴ�.", 1);


                memoryBlocker.gameObject.SetActive(true);
                Secretary.gameObject.transform.localPosition = new Vector3(730f, 43f, 0);

                C_GeneMemory.GetComponent<Button>().interactable = true;
                GM_animator.SetTrigger("Normal");

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(-559f, 7f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -180f);

                break;


            case 40:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�̹� �Ʒ����� �������� �� ���� �������� �������̳���?", 1);

                break;

            case 41:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("ETI ���� ������ ������ ������ ��ã�� ���� ������� ���� ȸ���Դϴ�.", 1);

                break;


            case 42:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���� ETI ���� ���ܿ��� ���� ū ������ �ٷ� ������ �����ϴ� �������Դϴ�.", 1);

                break;


            case 43:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�׷��� ������ �����ڴ��� �ϼž� �Ǵ� ������ ����ü�� �����ϰ� �����ϴ� ������� �¼� �ο��� �մϴ�.", 1);

                break;

            case 44:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�׷��� �̹� ������ ���⼭ �����ڽ��ϴ�. �����ϼ̽��ϴ�.", 1);

                break;

            case 45:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�̰��� Ŭ���� ù ȭ������ �Ѿ�ϴ�.", 1);
                break;

            default:

                if (Yeeter >= 45)
                {
                    PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 = true;
                    PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = 0;
                    SceneManager.LoadScene("FirstScene");

                }

                break;
        }

    }






}
