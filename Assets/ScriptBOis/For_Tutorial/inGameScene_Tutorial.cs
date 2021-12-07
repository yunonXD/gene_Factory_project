using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class inGameScene_Tutorial : MonoBehaviour
{
    public GameObject PlayerData;           //세이브데이터
    public GameObject Tutorial;             //튜토리얼띄워줄부모객체
    public GameObject Secretary;            //네모네모비서
    public GameObject Indicator;            //화살표
    public GameObject GenemapBlocker;       //유전자 지도 클릭 가림막
    public GameObject StageBlocker;       //전투창 클릭 가림막
    public GameObject memoryBlocker;       //유전자 지도 클릭 가림막

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

    private int Yeeter = 0;               //다이어로그 읽어올 세이브파일 받아올 인트값

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
        //튜토리얼 진행을 위한 _Gene_Between3 판별
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {
            Tutorial.gameObject.SetActive(true);
            //esc 작동 스크립트 DEAD
            Option.GetComponent<Button_Editor>().enabled = false;

        }
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == true)
        {
            Tutorial.gameObject.SetActive(false);
            //esc 작동 스크립트 Alive
            Option.GetComponent<Button_Editor>().enabled = true;

            C_GeneSelect.GetComponent<Button>().interactable = true;
            GS_animator.SetTrigger("Normal");

            C_GeneMemory.GetComponent<Button>().interactable = true;
            GM_animator.SetTrigger("Normal");

            C_BattleSelect.GetComponent<Button>().interactable = true;
            MS_animator.SetTrigger("Normal");

            Destroy(Tutorial);
            Destroy(this);      //안쓰면 삭제
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
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "포인트이만큼 세이브");
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
                C_Dialogue.DOText("좋은 아침입니다 관리자님.", 1);
                break;

            case 2:
                C_name.text = "???";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("ETI 제조 사무실에 처음 오신건데, 기분은 어떠십니까?", 1);
                break;

            case 3:
                C_name.text = "???";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("관리자님께서 ETI 제조 공단에 취직하신 것을 정말 축하드립니다.", 1);
                break;

            case 4:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("우선 제 소개를 드리자면, 제 이름은 마리아라고 합니다." +
                    " 관리자님의 개인 비서입니다.",1);
                break;

            case 5:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("앞으로 마리아라고 부르시면 됩니다. 그러면 앞으로 관리자님으로 부르겠습니다", 1);
                break;

            case 6:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("오늘부터 관리자님은 ETI 제조 공단의 구역을 관리하는 관리자입니다.", 1);
                break;

            case 7:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("관리자님께서 이 일을 잘 해낼 수 있을까 걱정이 되신다고요?", 1);
                break;

            case 8:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("안심하세요, ETI 제조 공단은 언제나 엄격한 선별 과정을 거쳐 관리자를 선발합니다.", 1);
                break;

            case 9:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("그런 엄격한 과정을 전부 통과하셨으니, 관리자님은 분명 문제없으실 겁니다.", 1);
                break;

            case 10:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("그리고 다음 훈련에서는 관리자님이 일에 익숙해질 수 있도록 제가 도움을 드릴 예정입니다.", 1);
                break;

            case 11:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("자, 일단 유전자 지도로 전환해보도록 하죠.", 1);

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
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("전투 스테이지를 선택하기 위해 스테이지 창을 클릭해 주십시오.", 1);

                Secretary.gameObject.transform.localPosition = new Vector3(730f, 43f, 0);

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(-2f, 7f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -0f);

                StageBlocker.gameObject.SetActive(true);

                C_BattleSelect.GetComponent<Button>().interactable = true;
                MS_animator.SetTrigger("Normal");

                break;

                //전투씬 끝나고 33부터 시작

            case 33:
                C_name.text = "";
                C_Dialogue.DOText("", 1);

                break;


            case 34:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("훈련은 성공적으로 완료했습니다.", 1);

                break;

            case 35:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("전투 후 스토리에 대한 정보는 기록 보관소에서 확인이 가능합니다.", 1);


                memoryBlocker.gameObject.SetActive(true);
                Secretary.gameObject.transform.localPosition = new Vector3(730f, 43f, 0);

                C_GeneMemory.GetComponent<Button>().interactable = true;
                GM_animator.SetTrigger("Normal");

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(-559f, 7f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -180f);

                break;


            case 40:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("이번 훈련으로 앞으로의 할 일이 무엇인지 깨달으셨나요?", 1);

                break;

            case 41:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("ETI 제조 공단은 세계의 안전을 되찾기 위해 만들어진 제조 회사입니다.", 1);

                break;


            case 42:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("현재 ETI 제조 공단에게 가장 큰 위협은 바로 지구상에 존재하는 괴물들입니다.", 1);

                break;


            case 43:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("그렇기 때문에 관리자님이 하셔야 되는 업무는 생명체를 관리하고 적대하는 괴물들과 맞서 싸워야 합니다.", 1);

                break;

            case 44:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("그러면 이번 작전은 여기서 끝내겠습니다. 수고하셨습니다.", 1);

                break;

            case 45:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("이곳을 클릭시 첫 화면으로 넘어갑니다.", 1);
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
