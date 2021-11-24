using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_2_After : MonoBehaviour
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
    public GameObject NPC_1;            //NPC1
    public GameObject NPC_2;            //NPC2
    public GameObject SelectQ;          //선택창
    public Text _Select_text1;          //선택창에 나올 텍스트1
    public Text _Select_text2;          //선택창에 나올 텍스트2
    public Button SelectQ_B_1;          //선택창에 있는 상호작용 버튼
    public Button SelectQ_B_2;          //선택창에 있는 상호작용 버튼
    public GameObject FadeBoi;          //페이드 인 아웃 시킬 검은 화면
    public GameObject UI_Dialoue;

    private Animator animator;
    private bool Alpha_Secretary = false;
    private bool Alpha_NPC_1 = false;
    private float Timer = 0;

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


    //제목 구조신호

    //.setDelay(?);
    public void ForStory_2_2()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("관리자가 생명체 소탕작전이 시작한 시각, 공장 내부", 1);
                break;


            case 2:
                NPC_1.gameObject.SetActive(true);
                _name.text = "????";
                _index.DOText("", 1);
                _index.DOText("저기 있잖아, 내가 언제까지 기다려 줘야 되는 거야? 이제 슬슬 말할 마음이 생겼어? ", 1);
                break;

            case 3:
                NPC_1.gameObject.SetActive(false);
                _name.text = "인질";
                _index.DOText("", 1);
                _index.DOText("모릅니다! 진짜로 아무것도 모릅니다! ", 1);

                break;

            case 4:
                NPC_1.gameObject.SetActive(true);
                _name.text = "????";
                _index.DOText("", 1);
                _index.DOText("ETI 제조 공단 주요 장소 위치를 말해 달라고! 아무리 나도 알려주지 않으면 화낼 거야!", 1);
                break;

            case 5:
                NPC_1.gameObject.SetActive(false);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("괴물은 자신의 무기로 인질 중 한 명의 다리를 찔렀다.", 1);
                break;


            case 6:
                //해당 컷신에서 텍스트가 전부 나오고 나서 날카로운 것으로 찌르는 효과음이 나온다.
                break;

            case 7:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("인질은 비명을 지르며 고통스러워했다.", 1);
                break;


            case 8:
                _name.text = "인질";
                _index.DOText("", 1);
                _index.DOText("정말로 위치를 모릅니다, 제발 목숨만은 살려주십시오!", 1);
                break;

            case 9:
                NPC_1.gameObject.SetActive(true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText(".....", 1);
                break;

            case 10:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("흥, 알려주기 싫으면 말고, 모비디우스 이제 가자!", 1);
                break;

            case 11:

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("좀 더 놀고 싶지만 오늘은 여기까지만 밖에 있는 친구들이 더 이상 여기에 있는 건 위험하다고 하니까 이제 돌아가자.", 1);
                break;

            case 12:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("다음에도 또 놀아줘 ETI", 1);
                break;

            case 13:

                FadeBoi.gameObject.SetActive(true);
                break;

            case 14:
                MainBG_1.gameObject.SetActive(false);
                MainBG_2.gameObject.SetActive(true);
                NPC_1.gameObject.SetActive(false);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);
                _name.text = "";
                _index.DOText("", 1);
                break;


            case 15:
                Secretary.gameObject.SetActive(true);

                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("고생하셨습니다, 관리자님.", 1);
                break;

            case 16:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("공장 내부에 있던 생존자들의 증언을 토대로 놈들의 목적을 알게 되었습니다.", 1);
                break;


            case 17:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("현재 적들을 유인하기 위한 공세에 들어갈 예정입니다. 이번 작전은 저번 임무 이상으로 위험할 것으로 예상됩니다.", 1);
                break;

            case 18:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그러나 성공한다면 현재 형세를 역전시킬 수 있기 때문에 위험을 감수하더라도 작전 실행을 결정했습니다.", 1);
                break;

            case 19:

                Vector3 position = Secretary.transform.localPosition;
                position.x = 200;
                Secretary.transform.localPosition = position;

                NPC_2.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("연결됐군…자네가 그 관리자 군? 반갑네.", 1);
                break;

            case 20:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("제가 소개를 드리겠습니다. 이분은…", 1);
                break;

            case 21:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("내 이름은 라프니크라고 하네, ETI 제조 공단의 최고 경영자 직을 맡고 있네.", 1);
                break;

            case 22:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("라프니크님은 ETI 제조 공단을 설립하신 분입니다.", 1);
                break;

            case 23:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("조합 기술을 바탕으로 실험체를 만들어 괴물들과 싸우기 위한 시스템을 만들고 기업 단위로 운영을 하시는 것 모두 라프니크님의 공헌입니다.", 1);
                break;

            case 24:
                    ScreenLock.gameObject.SetActive(true);
                    SelectQ.gameObject.SetActive(true);
                    _Select_text1.text = "뵙게 되어 영광입니다.";
                    _Select_text2.text = "라프니크님께서 이곳에는 무슨 일로?";

                if (select1 == true || select2 == true){
                    CountClick += 1;
                    select1 = false;
                    select2 = false;
                    Debug.Log("넘어왔음.");
                }
                break;

                

            case 25:

                ScreenLock.gameObject.SetActive(false);
                SelectQ.gameObject.SetActive(false);
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("긴말은 필요 없으니 용건부터 말하겠네.", 1);
                break;

            case 26:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("자네에게 적들의 우두머리를 유인하기 위한 미끼 역할을 부탁하고 싶네.", 1);
                break;

            case 27:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("현재 우리 상황이 좋은 상황이라고 할 수 없네.", 1);
                break;

            case 28:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("그러니 현재 상황을 역전하기 위한 대규모 공세가 필요하네.", 1);
                break;

            case 29:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("놈들을 유인해 끌어들인 다음, 적들을 일망타진한다면 우리가 승기를 잡을 수 있다네.", 1);
                break;

            case 30:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("자네에게 위험이 찾아오더라도 자네라면 이겨낼 거라고 믿고 있네, 부탁하네 이번 위기를 넘겨낼 수 있도록 나를 도와주게나.", 1);
                break;


            case 31:
                ScreenLock.gameObject.SetActive(true);
                SelectQ.gameObject.SetActive(true);
                _Select_text1.text = "믿고 맡겨 주십시오.";
                _Select_text2.text = "힘들겠지만, 최선을 다하겠습니다.";

                if (select1 == true || select2 == true)
                {
                    Debug.Log("넘어옴 31번");
                    //CountClick += 1;
                }
                break;

            case 32:
                ScreenLock.gameObject.SetActive(false);
                SelectQ.gameObject.SetActive(false);

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("기대하고 있겠네.", 1);

                break;


            case 33:
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);

                break;

            default:
                //_index.DOText("", 1);
                _index.text = "대화 마무리. 여기서 창 종료 여기서 씬 변경.";
                break;


        }
    }




    public void InputCountNum()
    {
        CountClick += 1;

        Debug.Log(CountClick);
    }

    private void Change_Alpha_Secretary(bool Alpha_Secretary)
    {


        if(Alpha_Secretary == true)
        {
            Secretary.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if(Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
        }


        //if (Alpha_Secretary == true) {      //알파 온
        //    Color color_Secretary = Secretary_image.color;
        //    for (float i = 1.0f; i >= 0.6f; i -= 0.01f)
        //    {
        //        color_Secretary.r = i;
        //        Secretary_image.color = color_Secretary;
        //    }
        //}

        //else if(Alpha_Secretary == false){  //알파 오프
        //    Color color_Secretary = Secretary_image.color;
        //    for (float i = 0.6f; i >= 1.0f; i += 0.01f)
        //    {
        //        color_Secretary.a = i;
        //        Secretary_image.color = color_Secretary;
        //    }
        //}
    }

    private void Change_Alpha_SNPC_1(bool Alpha_NPC_1)
    {
        if(Alpha_NPC_1 == true)
        {
            NPC_1.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Normal_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
        }

        if(Alpha_NPC_1 == false)
        {
            NPC_1.GetComponent<Image>().color = new Color(1, 1, 1);
            Normal_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }
    }





}
