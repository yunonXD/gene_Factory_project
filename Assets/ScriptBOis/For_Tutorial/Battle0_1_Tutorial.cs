using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Battle0_1_Tutorial : MonoBehaviour
{
    
    public GameObject PlayerData;           //���̺굥����
    public GameObject Tutorial;             //Ʃ�丮�����ٺθ�ü
    public GameObject Indicator;            //ȭ��ǥ

    public GameObject BlockDialogue;

    public Text C_name;
    public Text C_Dialogue;

    private int Yeeter = 0;               //���̾�α� �о�� ���̺����� �޾ƿ� ��Ʈ��
    private GameObject Option;


    void Start()
    {
        //29���� ����

        StartCoroutine(CountStartDelay());

        Option = GameObject.Find("GameManager");
        Option.GetComponent<Button_Editor>().enabled = false;
        Tutorial.gameObject.SetActive(true);
    }




    void Update()
    {    
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;

        StartCoroutine(DialogueStartDelay());
    }

    IEnumerator CountStartDelay()
    {
        yield return new WaitForSeconds(22f);
        Time.timeScale = 0f;

    }

    IEnumerator DialogueStartDelay()
    {
        yield return new WaitForSeconds(21.0f);
        Indicator.gameObject.SetActive(true);
        C_name.text = "������";
        C_Dialogue.text = "��ų ��ư�� ���� �� �ش� ����ü�� ��ų�� ����մϴ�.";
    }

    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "����Ʈ�̸�ŭ ���̺�");
    }


    public void B0_1_Tutorial()
    {
        Yeeter = Yeeter + 1;
        PointSaver();

        switch (Yeeter)
        {

            case 29:
                C_name.text = "";
                C_Dialogue.DOText("", 1);

                break;

            case 30:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�� �鸮�ʴϱ�. �����ڴ�?", 1);

                break;

            case 31:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���� �Ʒ��� �غ� �Ϸ�Ǿ�����, �������� �Ʒ��� �����ϴ� ���� �����մϴ�.", 1);

                break;

            case 32:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�׷� �Ʒ��� �����ϵ��� �ϰڽ��ϴ�.", 1);
                BlockDialogue.gameObject.SetActive(true);


                break;

            default:
                break;



        }


    }
}
