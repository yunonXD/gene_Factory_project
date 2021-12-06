using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Battle0_1_Tutorial : MonoBehaviour
{
    
    public GameObject PlayerData;           //세이브데이터
    public GameObject Tutorial;             //튜토리얼띄워줄부모객체
    public GameObject Indicator;            //화살표

    public GameObject BlockDialogue;

    public Text C_name;
    public Text C_Dialogue;

    private int Yeeter = 0;               //다이어로그 읽어올 세이브파일 받아올 인트값
    private GameObject Option;


    void Start()
    {
        StartCoroutine(CountStartDelay());

        Option = GameObject.Find("GameManager");

        //튜토리얼 진행을 위한 _Gene_Between3 판별
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {
            //esc 작동 스크립트 DEAD
            Option.GetComponent<Button_Editor>().enabled = false;
            Tutorial.gameObject.SetActive(true);
        }

        else
        {
            //esc 작동 스크립트 Alive
            Option.GetComponent<Button_Editor>().enabled = true;
            Tutorial.gameObject.SetActive(false);

            Destroy(this);      //안쓰면 삭제.. 인데 여긴 무조건 쓰잖아..?

        }


    }




    void Update()
    {    
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;

        StartCoroutine(DialogueStartDelay());
    }

    IEnumerator CountStartDelay()
    {
        yield return new WaitForSeconds(22.0f);
        Time.timeScale = 0f;

    }

    IEnumerator DialogueStartDelay()
    {
        yield return new WaitForSeconds(21.0f);
        Indicator.gameObject.SetActive(true);
        C_name.text = "마리아";
        //C_Dialogue.DOText("", 1);
        C_Dialogue.DOText("스킬 버튼을 누를 시 해당 실험체의 스킬을 사용합니다.", 1);
    }

    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "포인트이만큼 세이브");
    }


    public void B0_1_Tutorial()
    {
        Yeeter = Yeeter + 1;
        PointSaver();

        switch (Yeeter)
        {

            case 30:
                C_name.text = "";
                C_Dialogue.DOText("", 1);

                break;

            case 31:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("잘 들리십니까. 관리자님?", 1);

                break;

            case 32:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("모의 훈련의 준비가 완료되었으니, 언제든지 훈련을 시작하는 것이 가능합니다.", 1);

                break;

            case 33:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("그럼 훈련을 시작하도록 하겠습니다.", 1);
                BlockDialogue.gameObject.SetActive(true);


                break;

            default:
                break;



        }


    }
}
