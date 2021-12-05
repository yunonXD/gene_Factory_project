using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_3 : MonoBehaviour
{
    public GameObject ScreenLock;       //버튼 못누르게 락 걸기

    private int CountClick = 0;
    public Text _index;                 //대화 내용
    public Text _name;                  //이름
    public GameObject MainBG_1;          //기본 메인 BG
    public GameObject MainBG_2;         //바뀔 메인 BG

    public GameObject Secretary;        //비서 스프라이트
    public GameObject Normal_eyes;      //일반 표정
    public GameObject Close_eyes;       //닫은 눈
    public GameObject Smile_eyes;       //웃는 눈
    public GameObject Surprise_eyes;    //놀란 눈
    public GameObject PlayerData;
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //선택창
    public Button SelectQ_B_1;          //선택창에 있는 상호작용 버튼
    public Button SelectQ_B_2;          //선택창에 있는 상호작용 버튼
    public Text _Select_text1;          //선택창에 나올 텍스트1
    public Text _Select_text2;          //선택창에 나올 텍스트2
    public GameObject FadeBoi;          //페이드 인 아웃 시킬 검은 화면


    private Animator animator;
    private bool Alpha_Secretary = false;
    private bool Alpha_NPC_1 = false;

    bool select1 = false;
    bool select2 = false;


    private void Awake()
    {
        animator = FadeBoi.GetComponent<Animator>();
    }

    void Start()
    {
        SelectQ_B_1.onClick.AddListener(SelectQ_1);
        SelectQ_B_2.onClick.AddListener(SelectQ_2);

    }


    void Update()
    {
    }

    public void SelectQ_1()          //선택지 창에서 눌렀는지 아닌지 확인하는부분.
    {
        select1 = true;
        Debug.Log(select1);
    }

    public void SelectQ_2()          //선택지 창에서 눌렀는지 아닌지 확인하는부분.
    {
        select2 = true;
        Debug.Log(select2);
    }


    //제목 더이상 물러날 곳은 없다.

    //.setDelay(?);



    public void ForStory_2_3()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("얼마 뒤, ETI 제조 공단의 사장실 집무실 안...", 1);
                break;


            case 2:
                Secretary.gameObject.SetActive(true);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("늦어서 죄송합니다 라프니크님.", 1);
                break;

            case 3:

                ChangeLocation(200);


                NPC_1.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("이번 작전은 우리뿐만이 아닌 앞으로의 국가의 안보와 연결되는 중요한 작전이라네. ", 1);
                break;

            case 4:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("적들을 유인했으니 곧 전투가 시작된다네, 그전에 할 수 있는 모든 준비를 끝마치려고 하네.", 1);
                break;


            case 5:
                ForStory_FMod.instance.Pen_Sound();
                //[펜으로 글씨를 적을 때 발생하는 효과음] 컷신 텍스트가 출력이 끝날 때 들리도록 설정

                break;

            case 6:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("보고는 아까 전에 통신으로 확인했네. 수고가 많았군 마리아.", 1);
                break;

            case 7:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("맡은 일에 최선을 다했을 뿐입니다.", 1);
                break;

            case 8:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그리고, 관리자님의 추가 보고를 받고 현재 모여든 적들에 대한 정보들을 정리 중입니다.", 1);
                break;

            case 9:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그러나 이전에는 없던 새로운 정보를 정리하기 위해 추가적인 시간이 소요될 것으로 보입니다.", 1);
                break;

            case 10:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("관리자는 예정대로 적들을 유인하도록 전하게, 우리는 다음 작전을 위한 준비가 필요하니 말이네. ", 1);
                break;

            case 11:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("명령에 따라, 우리가 여기서 저놈들의 공세를 넘겨내야 더 큰 규모의 작전을 실행하기 위한 사전 준비이니 말이네.", 1);
                break;

            case 12:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("또 상부의 명령입니까……	", 1);
                break;

            case 13:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("문제란 문제는 저희에게 전부 떠넘기면서 지원은 부족하니 정말 힘들군요……", 1);
                break;

            case 14:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("높으신 분들도 이번 작전이 중요하긴 한 모양이야, 이번 작전을 도와줄 지원이 곧 도착할 예정이라네.", 1);
                break;

            case 15:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("추가 지원이라면, 방금 전 도착한 보고서에 적힌 인원들을 말씀하시는 겁니까?", 1);
                break;


            case 16:
                PlayFModUI.instance.GeneDocument();
                //[종이로 된 서류를 넘기는 효과음] 컷신 텍스트가 출력과 동시에 들리도록 설정
                break;

            case 17:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("우리들은 여전히 불리한 상황이라네, 가뜩이나 적들을 일망타진하기 위해 관리자가 적들을 유인하여 포위당한 상태지.", 1);
                break;

            case 18:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("그런 상황에서 적들의 포위를 느슨하게 만들기 위한 지원이지.", 1);
                break;

            case 19:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("이번 지원은 높으신 분들에게 있어서 약간의 소모라고 생각할 것이야.", 1);
                break;

            case 20:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그렇다면 관리자님이 위험에 처할 경우 추가 인력보다 관리자님을 우선으로 구조해야 합니까?	", 1);
                break;

            case 21:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("내 생각엔, 그는 앞으로 우리에게 중요한 전력이 될 것 같네.", 1);
                break;

            case 22:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그렇습니다. 입사한지 얼마 안 되었으나, 보여준 성과를 생각했을 때 집중적으로 교육할 가치가 있다고 판단됩니다.", 1);
                break;

            case 23:
                FadeBoi.gameObject.SetActive(true);
                break;


            case 24:

                ChangeLocation(0);

                NPC_1.gameObject.SetActive(false);

                MainBG_1.gameObject.SetActive(false);
                MainBG_2.gameObject.SetActive(true);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("임시 사무실 내부……", 1);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);

                break;

            case 25:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("들리십니까, 관리자님?", 1);
                break;


            case 26:
                ForStory_FMod.instance.Signal_connect();
                //[통신이 연결되는 효과음] 컷신 텍스트가 출력과 동시에 들리도록 설정
                break;

            case 27:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("계획대로 적들을 유인하시느라 고생하셨습니다. 이번 역할은 상당히 위험했지만 다행히 잘 버텨 주셨습니다.", 1);
                break;

            case 28:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("예상보다 많은 적들이 모였지만 어째 선지 상부의 지원이 있어서 일부 적은 저희 쪽에서 처리하기로 했습니다.	", 1);
                break;


            case 29:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("관리자님께서는 적들의 본대를 돌파해야 합니다. 적들 역시 철저히 대비를 했겠지만 성공하실 수 있을 거라 믿습니다.", 1);
                break;

            case 30:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그러면 돌아오시기 위한 길을 정리하고 대기하겠습니다. ", 1);
                break;

            case 31:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("무운을 빕니다…	", 1);
                break;

            case 32:
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);
                break;


            default:
                if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == true)
                {
                    SceneManager.LoadScene("BattleScene2_3");
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

    public void ChangeLocation(int i = 0 )
    {
        Vector3 position = Secretary.transform.localPosition;
        position.x = i;
        Secretary.transform.localPosition = position;
    }

    public void InputCountNum()
    {
        CountClick += 1;

        Debug.Log(CountClick);
    }

    private void Change_Alpha_Secretary(bool Alpha_Secretary)
    {


        if (Alpha_Secretary == true)
        {
            Secretary.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Normal_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Smile_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Surprise_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if (Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
            Normal_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
            Smile_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
            Surprise_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
        }
    }


        private void Change_Alpha_SNPC_1(bool Alpha_NPC_1)
    {
        if (Alpha_NPC_1 == true)
        {
            NPC_1.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);


        }

        if (Alpha_NPC_1 == false)
        {
            NPC_1.GetComponent<Image>().color = new Color(1, 1, 1);


        }
    }



}
