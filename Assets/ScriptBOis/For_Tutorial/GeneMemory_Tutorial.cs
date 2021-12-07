using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GeneMemory_Tutorial : MonoBehaviour
{
    
    public GameObject PlayerData;           //���̺굥����
    public GameObject Tutorial;             //Ʃ�丮�����ٺθ�ü


    public Text C_name;
    public Text C_Dialogue;

    private int Yeeter = 0;
    private GameObject Option;


    void Start()
    {
        Tutorial.gameObject.SetActive(true);

        Option = GameObject.Find("GameManager");

        
    }


    void Update()
    {
        CheckGMTutorial();
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;
    }


    void CheckGMTutorial()
    {
        //Ʃ�丮�� ������ ���� _Gene_Between3 �Ǻ�
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {

            //esc �۵� ��ũ��Ʈ DEAD
            Option.GetComponent<Button_Editor>().enabled = false;

        }
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == true)
        {
            //esc �۵� ��ũ��Ʈ Alive
            Option.GetComponent<Button_Editor>().enabled = true;
            Tutorial.gameObject.SetActive(false);

            Destroy(Tutorial);
            Destroy(this);      //�Ⱦ��� ����
        }
    }

    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "����Ʈ�̸�ŭ ���̺�");
    }


    public void gamememoryTutorial()
    {
        Yeeter = Yeeter + 1;
        PointSaver();

        switch (Yeeter)
        {
            case 36:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���� �������� �¸��ϰ� ���� ���丮�� �����Ͻð� ������ ������ Ŭ���Ͻø�," +
                    " ���±����� ����� Ȯ���� �� �ֽ��ϴ�.", 1);
                break;

            case 37:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("���丮�� �ٽ� �����ϰ� �����ôٸ� �̰����� ���ֽø� �˴ϴ�.", 1);
                break;

            case 38:
                C_name.text = "������";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("�׷� �ٽ� �繫�Ƿ� �̵��ϰڽ��ϴ�.", 1);
                break;

            case 39:
                SceneManager.LoadScene("inGameScene");
                break;











        }
    }
}
