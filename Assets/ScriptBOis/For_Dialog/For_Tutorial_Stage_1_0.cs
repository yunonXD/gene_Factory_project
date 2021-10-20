using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_Stage_1_0 : MonoBehaviour
{
    private bool SkillChecker = false;

    private float waitgene = 0;
    private int Clicker_Check = 0;      // ��ư Ŭ�� Ƚ���� �Ǵ� ��. �ð� ��� �̷��� ��������.
    public Text dialog;
    public GameObject BlackScrean;
    public GameObject Checker;
    public GameObject Arrow;
    public GameObject For_Story;

    public Button SKILL;

    public Image skill_Amount;
    public Image skill_Amount_Dummy;
    public GameObject MissionClear;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        switch (Clicker_Check)
        {
            case 1:
                {
                    dialog.text = "�� �鸮�ʴϱ�. �����ڴ�?";
                }
                break;


            case 2:
                {
                    dialog.text = "���� �Ʒ��� �غ� �Ϸ�Ǿ�����, �������� �Ʒ��� �����ϴ� ���� �����մϴ�.";
                }
                break;

            case 3:
                {
                    dialog.text = "�׷� �Ʒ��� �����ϵ��� �ϰڽ��ϴ�.";
                }
                break;

            case 4:
                {

                    
                    dialog.text = "������ �⺻������ ������ ���� ���ʴ�� ������ �����մϴ�.";
                   
                    BlackScrean.gameObject.SetActive(false);
                    Time.timeScale = 1;
                    waitgene += Time.deltaTime;
                    if (waitgene >= 5)
                    {
                        Time.timeScale = 0;
                    }


                }
                break;

            case 5:
                {
                    Time.timeScale = 1;
                    dialog.text = "����/�ǰݽ� 25�ۼ�Ʈ�� ��ų�������� ȹ���ϰ� " +
                        "\n 100�ۼ�Ʈ�� �ɽ� ��ų�������� Ȱ��ȭ �˴ϴ�.";

                }
                break;

            case 6:
                {
                    Time.timeScale = 0;
                    Checker.gameObject.SetActive(false);
                    BlackScrean.gameObject.SetActive(true);
                    Arrow.gameObject.SetActive(true);
                    dialog.text = "��ų ��ư�� ���� �� �ش� ����ü�� ��ų�� ����˴ϴ�.";
                    skill_Amount_Dummy.gameObject.SetActive(true);

                    skill_Amount.fillAmount = 1;
                    SKILL.gameObject.SetActive(true);
                    if (SkillChecker == true)
                    {
                        SKILL.gameObject.SetActive(false);
                        skill_Amount_Dummy.gameObject.SetActive(false);
                        BlackScrean.gameObject.SetActive(false);
                        Arrow.gameObject.SetActive(false);
                        For_Story.gameObject.SetActive(false);
                        Time.timeScale = 1;
                    }
                }
                break;



        }

    }


    public void Clicker_Count_Num()
    {
        Clicker_Check += 1;
        Debug.Log("Ŭ��Ŀ �۵��ϴ��� Ȯ���� : " + Clicker_Check);
    }


    public void Skill_Check()
    {
        SkillChecker = true;
    }

}
