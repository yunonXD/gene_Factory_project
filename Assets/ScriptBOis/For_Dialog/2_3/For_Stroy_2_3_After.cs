using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_3_After : MonoBehaviour
{
    public GameObject ScreenLock;       //버튼 못누르게 락 걸기

    private int CountClick = 0;
    public Text _index;                 //대화 내용
    public Text _name;                  //이름
    public GameObject MainBG_1;          //기본 메인 BG
    public GameObject MainBG_2;         //바뀔 메인 BG
    public GameObject MainBG_3;         //바뀔 메인2 BG

    public GameObject Secretary;        //비서 스프라이트
    public GameObject Normal_eyes;      //일반 표정
    public GameObject Close_eyes;       //닫은 눈
    public GameObject Smile_eyes;       //웃는 눈
    public GameObject Surprise_eyes;    //놀란 눈
    public GameObject PlayerData;
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //선택창
    public Text _Select_text1;          //선택창에 나올 텍스트1
    public Text _Select_text2;          //선택창에 나올 텍스트2
    public Button SelectQ_B_1;          //선택창에 있는 상호작용 버튼
    public Button SelectQ_B_2;          //선택창에 있는 상호작용 버튼
    public GameObject FadeBoi;          //페이드 인 아웃 시킬 검은 화면
    public GameObject UI_Dialoue;
    public GameObject MoveBlackScreen;


    private Animator animator;

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
                _index.DOText("모비디우스 처치 작전으로부터 얼마 후, ETI 제조 공단 사장실 문 앞", 1);
                break;


            case 2:
                //‘똑똑똑’이라는 컷신 텍스트가 나올 때 문을 두드려서 발생하는 효과음이 나온다.

                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("똑똑똑", 1);
                break;

            case 3:
                NPC_1.gameObject.SetActive(false);
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("들어오게.", 1);

                break;

            case 4:

                MoveBlackScreen.gameObject.SetActive(true);
                MoveBlackScreen.GetComponent<MoveBlackScreen>().MoveR_TO_L();

                break;

            case 5:
                MainBG_1.gameObject.SetActive(false);
                MainBG_2.gameObject.SetActive(true);
                MoveBlackScreen.GetComponent<MoveBlackScreen>().MoveR_TO_L_Num2();
                break;


            case 6:

                NPC_1.gameObject.SetActive(true);
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("왜 그러고 있나. 어서 앉게.", 1);

                break;

            case 7:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("자네의 지금까지의 기록을 봤네, 이게 정말 현실인지 도저히 믿기질 않는군.", 1);
                break;


            case 8:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("자네가 없었다면 우리 ETI 제조 공단은 이번 위험을 넘겨내지 못했을 것이네.", 1);
                break;

            case 9:
                ScreenLock.gameObject.SetActive(true);
                SelectQ.gameObject.SetActive(true);
                _Select_text1.text = "해야 할 일을 한 것뿐입니다.";
                _Select_text2.text = "과찬이십니다.";

                if (select1 == true || select2 == true)
                {
                    CountClick += 1;
                    select1 = false;
                    select2 = false;
                    Debug.Log("넘어왔음.");
                }
                break;


            case 10:
                ScreenLock.gameObject.SetActive(false);
                SelectQ.gameObject.SetActive(false);
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("허허, 겸손도 과하면 비아냥이 되기 마련이네.", 1);
                break;

            case 11:

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("이번 짐을 전부 신참인 자네에게 짊어지운 건 내 본의는 아니었네만, " +
                    "그만큼 우리도 절박한 상황임을 이해해 주면 고맙겠네. 그래도 훌륭하게 해내 주었어.", 1);
                break;

            case 12:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("그러나 우리는 이제 막 폭풍우를 벗어난 돛단배일세, 다른 일을 신경 쓸 겨를은 없다네.", 1);
                break;

            case 13:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("이번 임무에서 우리가 이렇게 살아남은 이유는, 자네의 공이 크다고 생각하네.", 1);

                break;

            case 14:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("내가 이렇게 살아있는 것도, 높으신 분들이 하기 싫은 일을 내가 대신할 수 있기 때문이라네.", 1);

                break;


            case 15:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("하지만 자넨 달라. 자넨 아직 젊고, 재능도 있지. 어딜 가서든 큰일을 이룰걸세.", 1);

                break;

            case 16:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("높으신 분들이 자네를 마음에 든 모양이야, 자네만 원한다면 여기보다 더 편한 곳에서 일할 수 있다네." +
                    " 퇴직금도 걱정 말게나, 아주 두둑이 줄 테니.", 1);

                break;


            case 17:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("자네만 원한다면, 이 회사를 그만두고 떠나서 그곳에서 편하게 일할 수 있어.", 1);
                break;

            case 18:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("죄책감 가질 필요 없네. 자넨 이미 우릴 위해 노력하지 않았는가. 이 죽음의 문턱에서 떠나, 행복한 삶을 살 자격이 충분해.", 1);
                break;

            case 19:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("떠나지 않겠다고? 앞으로 무슨 일이 있을진 그 누구도 예측할 수 없어. " +
                    "전쟁의 불씨가 다시 한번 타오르는 순간, 그땐 정말 다신 돌이킬 수 없을 걸세.", 1);
                break;

            case 20:
                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("아무렴, 지금 당장 결정할 필요는 없다네, 천천히 잘 생각해 보게.", 1);
                break;

            case 21:

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("자네의 생각이 그렇다면 더 이상 말리지는 않겠네, ETI에 자네 같은 사람을 두어, 정말 영광이네.", 1);
                break;

            case 22:

                _name.text = "라프니크";
                _index.DOText("", 1);
                _index.DOText("그럼 나중에 또 얘기하지.", 1);
                break;

            case 23:
                FadeBoi.gameObject.SetActive(true);

                break;

            case 24:
                MainBG_2.gameObject.SetActive(false);
                MainBG_3.gameObject.SetActive(true);

                NPC_1.gameObject.SetActive(false);
                _name.text = "";
                _index.DOText("", 1);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);

                break;

            case 25:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("ETI 제조 공단 사무실.", 1);

                break;

            case 26:
                Secretary.gameObject.SetActive(true);
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("무사히 돌아오셔서 다행입니다. 관리자님.", 1);
                break;

            case 27:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("바로 다음 임무가 들어왔습니다. 바로 임무를 실행하겠습니다.", 1);
                break;

            case 28:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("앞으로도 잘 부탁드립니다. 관리자님.", 1);
                break;

            case 29:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("[유전자 공장 END]", 1);
                break;

            case 30:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("플레이해 주셔서 감사합니다.", 1);
                break;


            default:
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
            Smile_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if(Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
            Smile_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
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
        }

        if(Alpha_NPC_1 == false)
        {
            NPC_1.GetComponent<Image>().color = new Color(1, 1, 1);
        }
    }





}
