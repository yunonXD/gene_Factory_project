using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_Yeeter : MonoBehaviour
{
    private int Clicker_Check = 0;      // ��ư Ŭ�� Ƚ���� �Ǵ� ��. �ð� ��� �̷��� ��������.
    private bool ISON = false;                  //�����ư ���ȴ��� �ƴ��� Ȯ���ؾ���.

    public GameObject For_Story;        //���丮â

    public GameObject Clicker;          //ȭ�� Ŭ���ϸ� ���� �ö󰡴� ī����
    public Text dialog;                 //�ؽ�Ʈ ��¿� ���̾�α�

    public GameObject BlackScreen1;     //unknown�� ���� ������
    public GameObject Arrow_1;          //unknown�� ����ų ȭ��ǥ
    public Toggle BigIcon7_ForCheck;    //unknow ���

    public GameObject BlackScreen2;     //Open�� ���� ������

    public Toggle BigIcon7_Toggle;
    public GameObject Arrow_2;          //gene ����ų ȭ��ǥ
    public Toggle unlocked_7_Intel; //����

    public GameObject Arrow_3;          //intel �� ����ų

    public Toggle BigIcon7_Intel_Sus;

    public GameObject Arrow_4;          //big intel �� ����ų

    public GameObject Arrow_5;          //exit�� ����ų

    public GameObject Screen_For;


    public GameObject BlackScreen3;     //EXIT�� ���� ������


    //�ӽÿ� ��ũ��Ʈ. �̰� ����� ������ ����.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // �� ��ٻ�� �̰� �̷��� ������ ������������������������ ��ġ�ڳ� ��¥
        switch (Clicker_Check)
        {
            case 0:
                {
                    dialog.text = "����, �־��� ����Ʈ�� �̿��� ����ü�� �ر��غ����� �սô�.";
                }
                break;

            case 1:
                {
                    dialog.text = "���� ū ������ Ŭ��.";
                    BlackScreen1.gameObject.SetActive(true);
                    Arrow_1.gameObject.SetActive(true);
                    Clicker.gameObject.SetActive(false);

                    if (BigIcon7_ForCheck.isOn)
                    {
                        Clicker.gameObject.SetActive(true);
                        
                    }

                }
                break;


            case 2:
                {

                    BlackScreen1.gameObject.SetActive(false);
                    Arrow_1.gameObject.SetActive(false);
                    dialog.text = "�����ڴ��� ������ �������� ����ü�� ����� ���� ���� �����մϴ�.";

                }
                break;

            case 3:
                {

                    dialog.text = "ū ���������� ����ü�� �ر��� �� �ֽ��ϴ�.";

                }
                break;

            case 4:
                {

                    dialog.text = "���� ������ ���� �ܰ�� �̾����� ���� �ʿ��մϴ�." +
                        " �� �κ��� �ر��� ���� �Ǹ� �ڼ��� ����帮�ڽ��ϴ�. ";

                }
                break;
            case 5:
                {
                    Clicker.gameObject.SetActive(false);
                    dialog.text = "������ ������ �ر��ϱ� ����, OPEN ��ư�� Ŭ���غ��ô�. ";
                    BlackScreen2.gameObject.SetActive(true);


                    if (ISON == true)
                    {

                        Debug.Log("�����");
                        For_Story.gameObject.SetActive(false);
                        BlackScreen2.gameObject.SetActive(false);
                        Clicker_Check += 1;
                    }


                }
                break;
            case 6:
                {
                    StartCoroutine("WaitForUnilockAnime");
 
                }
                break;

            case 7:
                {
                    StopCoroutine("WaitForUnilockAnime");
                    Clicker.gameObject.SetActive(false);
                    Debug.Log("Ŭ��Ŀ �۵��ϴ��� Ȯ���� : " + Clicker_Check);
                    dialog.text = "����ü ��ư�� Ŭ���ϸ� ����ü ������ �ٽ� �� �� �ֽ��ϴ�.";
                    BlackScreen2.gameObject.SetActive(true);
                    Arrow_2.gameObject.SetActive(true);

                    if (BigIcon7_Toggle.isOn)
                    {
                        Arrow_2.gameObject.SetActive(false);
                        Arrow_3.gameObject.SetActive(true);

                        if (unlocked_7_Intel.isOn)
                        {
                            Arrow_3.gameObject.SetActive(false);
                            Arrow_4.gameObject.SetActive(true);
                            if (BigIcon7_Intel_Sus.isOn)
                            {
                                Arrow_4.gameObject.SetActive(false);
                                    Clicker_Check = 8;
                            }
                        }
                    }

                }
                break;



            case 8:
                {
                    StartCoroutine("ScreanWait");


                }
                break;





            case 9:
                {
                    StopCoroutine("ScreanWait");
                    Clicker.gameObject.SetActive(false);
                    BlackScreen2.gameObject.SetActive(false);
                    BlackScreen3.gameObject.SetActive(true);
                    Debug.Log("Ŭ��Ŀ �۵��ϴ��� Ȯ���� : " + Clicker_Check);
                    dialog.text = "����ü�� ȹ�������� ���� �Ʒ����� �Ѿ�ڽ��ϴ�.";
                    Arrow_5.gameObject.SetActive(true);

                }
                break;







        }




    }


    public void UnlockButton_Checker()
    {
        ISON = true;
    }


    IEnumerator WaitForUnilockAnime()
    {
        yield return new WaitForSeconds(9.0f);
        For_Story.gameObject.SetActive(true);
        Clicker.gameObject.SetActive(true);
    }

    IEnumerator ScreanWait()
    {
        yield return new WaitForSeconds(4.0f);
        Clicker.gameObject.SetActive(true);

    }


    public void Clicker_Count_Num()
    {
        Clicker_Check += 1;
        Debug.Log("Ŭ��Ŀ �۵��ϴ��� Ȯ���� : " + Clicker_Check);
    }






}
