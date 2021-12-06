using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class geneMap_Tutorial : MonoBehaviour
{
    public GameObject PlayerData;           //���̺굥����
    public GameObject Tutorial;             //Ʃ�丮�����ٺθ�ü
    public GameObject Indicator;            //ȭ��ǥ
    public GameObject[] GenemapBlocker;       //������ ���� Ŭ�� ������
    public Toggle[] geneSelect;

    public Text C_name;
    public Text C_Dialogue;

    private int Yeeter = 0;               //���̾�α� �о�� ���̺����� �޾ƿ� ��Ʈ��
    private GameObject obj;
    private GameObject obj1;
    private GameObject obj2;

    private int CountClick = 0;
    private GameObject Option;

    void Start()
    {
        Option = GameObject.Find("GameManager");


        //Ʃ�丮�� ������ ���� _Gene_Between3 �Ǻ�
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {
            Tutorial.gameObject.SetActive(true);
            //esc �۵� ��ũ��Ʈ DEAD
            Option.GetComponent<Button_Editor>().enabled = false;

            //�ܷ��� ���� ��� ��Ȱ��ȭ
            for (int i = 0; i < 8; i++){
                geneSelect[i].GetComponent<Toggle>().interactable = false;
                Debug.Log(geneSelect[i]);
            }
    

        }
        else
        {
            //esc �۵� ��ũ��Ʈ Alive
            Option.GetComponent<Button_Editor>().enabled = true;
            Tutorial.gameObject.SetActive(false);
            //�ٽ� ��� Ȱ��ȭ
            for (int i = 0; i < 8; i++)
            {
                geneSelect[i].GetComponent<Toggle>().interactable = true;
                Debug.Log(geneSelect[i]);
            }
            Destroy(this);      //�Ⱦ��� ����
        }


    }


    void Update()
    {
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;
    }

    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "����Ʈ�̸�ŭ ���̺�");
    }

    public void geneMapSceneTutorial()
    {

        Yeeter = Yeeter + 1;
        PointSaver();

        switch (Yeeter)
        {
            case 12:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("����, �־��� ����Ʈ�� �̿��� ����ü�� �ر��غ����� �սô�.", 1);
                break;

            case 13:

                GenemapBlocker[0].gameObject.SetActive(true);
                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(-197f, -295f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -90f);

                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���� ū ������ Ŭ��", 1);

                obj = GameObject.Find("BigIcon8_ForCheck"); 
                
                if (obj.GetComponent<Toggle>().isOn == true)
                {
                    Yeeter = Yeeter + 1;
                }

                break;


            case 14:
                GenemapBlocker[0].gameObject.SetActive(false);      //8�� ������ only

                Indicator.gameObject.SetActive(false);


                GenemapBlocker[1].gameObject.SetActive(true);       //���̾�αװ�����

                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�����ڴ��� ������ �������� ����ü�� ����� ���� ���� �����մϴ�. ", 1);
                break;

            case 15:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("ū ���������� ����ü�� �ر��� �� �ֽ��ϴ�. ", 1);
                break;

            case 16:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���� ������ ���� �ܰ�� �̾����� ���� �ʿ��մϴ�. " +
                    "�� �κ��� �ر��� ���� �Ǹ� �ڼ��� ����帮�ڽ��ϴ�. ", 1);
                break;

            case 17:
                GenemapBlocker[1].gameObject.SetActive(false);
                GenemapBlocker[2].gameObject.SetActive(true);      //���¹�ư ������

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(745, -381, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -90);


                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("������ ������ �ر��ϱ� ����, OPEN ��ư�� Ŭ���غ��ô�. ", 1);

                break;



            case 18:


                StartCoroutine(CountAttackDelay());


                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText(" �̰��� Ŭ�����ּ���. ", 1);
                break;


            case 19:

                GenemapBlocker[2].gameObject.SetActive(false);
                GenemapBlocker[0].gameObject.SetActive(true);

                Indicator.gameObject.transform.localPosition = new Vector3(-143, -312, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -120);

                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("����ü ��ư�� Ŭ���ϸ� ����ü ������ �ٽ� �� �� �ֽ��ϴ�. ", 1);


                obj1 = GameObject.Find("BigIcon8_Toggle");

                if (obj1.GetComponent<Toggle>().isOn == true)
                {
                    Yeeter = Yeeter + 1;
                }
                break;


            case 20:
                GenemapBlocker[0].gameObject.SetActive(true);


                Indicator.gameObject.transform.localPosition = new Vector3(-413, -291, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -30);


                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("����ü ������ �������� ��ư�� Ŭ���ϸ� ����ü ������ �ٽ� �� �� �ֽ��ϴ�. ", 1);

                obj2 = GameObject.Find("unlocked_8_Intel");

                if (obj2.GetComponent<Toggle>().isOn == true)
                {
                    Yeeter = Yeeter + 1;
                }
                break;


            case 21:
                GenemapBlocker[0].gameObject.SetActive(false);
                GenemapBlocker[3].gameObject.SetActive(true);

                Indicator.gameObject.transform.localPosition = new Vector3(-632, -5, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 130);

                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("����ü ������ �������� ��ư�� Ŭ���ϸ� ����ü ������ �ٽ� �� �� �ֽ��ϴ�. ", 1);

                break;



            case 22:
                GenemapBlocker[3].gameObject.SetActive(false);
                GenemapBlocker[4].gameObject.SetActive(false);
                Tutorial.gameObject.SetActive(false);



                break;

            case 23:
                GenemapBlocker[4].gameObject.SetActive(false);
                GenemapBlocker[5].gameObject.SetActive(true);

                Tutorial.gameObject.SetActive(true);
                GenemapBlocker[3].gameObject.SetActive(false);

                Indicator.gameObject.transform.localPosition = new Vector3(-706, -444, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("����ü�� ȹ�������� ���� �Ʒ����� �Ѿ�ڽ��ϴ�. ", 1);


                break;


            default:
                break;
        }


    }

    IEnumerator CountAttackDelay()
    {
        Debug.Log("18���� �Ѿ��");
        Tutorial.gameObject.SetActive(false);
        Debug.Log("�ڷ�ƾ����");
        yield return new WaitForSeconds(7.5f);
        Tutorial.gameObject.SetActive(true);

    }






}
