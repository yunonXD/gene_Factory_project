using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_1_After : MonoBehaviour
{
    public GameObject ScreenLock;       //버튼 못누르게 락 걸기

    private int CountClick = 0;
    public Text _index;                 //대화 내용
    public Text _name;                  //이름
    public GameObject Secretary;        //비서 스프라이트
    public GameObject Normal_eyes;      //일반 표정
    public GameObject Close_eyes;       //닫은 눈
    public GameObject Smile_eyes;       //웃는 눈
    public GameObject Surprise_eyes;    //놀란 눈
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //선택창
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


    //제목 도박에는 상당한 대가가 따른다, 하이 리스크 하이 리턴(High Risk High Return) after

    //.setDelay(?);
    public void ForStory_2_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("...", 1);
                break;


            case 2:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("임무 완료 후, 마리아에게 보고 완료.", 1);
                break;

            case 3:
                FadeBoi.gameObject.SetActive(true);
                break;

            case 4:
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);

                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("", 1);
                break;

            case 5:

                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("본사로 복귀한 마리아…", 1);
                break;

            case 6:
                //[문을 열 때 들리는 효과음] 컷신 텍스트가 출력과 동시에 들리도록 설정
                break;

            case 7:
                Secretary.gameObject.SetActive(true);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("현재 상황이 생각보다 훨씬 더 심각합니다. ???님.", 1);
                break;


            case 8:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("관리자님의 조사에 따르면, 적들이 저희보다 먼저 움직임을 보았을 때 저희가 불리한 상황이라고 볼 수 있습니다.", 1);
                break;

            case 9:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("먼저 움직이고 있는 상황에서 저희가 한 수 뒤처져 있다고 할 수 있습니다.", 1);
                break;

            case 10:

                Vector3 position = Secretary.transform.localPosition;
                position.x = 200;
                Secretary.transform.localPosition = position;


                NPC_1.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("...", 1);
                break;

            case 11:

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("우리가 그들의 손바닥 위에 있는 것인가….", 1);
                break;

            case 12:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("아무래도 비장의 수를 꺼낼 순간인가?", 1);
                break;


            case 13:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("허나 그럴 경우…", 1);
                break;

            case 14:

                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("우리가 입는 피해 또한 어느 정도 발생하겠지.", 1);
                break;


            case 15:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("예, 제 예상으로는 저희 쪽 피해 역시 적지 않을 것으로 보입니다.", 1);
                break;

            case 16:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("도박을 하려면 어느 정도의 리스크를 감안해야 하는 법이지.", 1);
                break;


            case 17:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그러나 이번 일은 너무 위험도가 높습니다. 적어도 다른 경우를 고려해서 최대한 안전한 방법으로…", 1);
                break;

            case 18:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("호랑이를 잡기 위해서는 호랑이 굴로 들어갈 줄 알아야 하네.", 1);
                break;

            case 19:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("만약을 대비해, 현 시간부로 너의 작전을 잠시 중지하겠네, 마리아.", 1);
                break;

            case 20:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("그 관리자의 임무도 현재로선 진행할 필요가 없어.", 1);
                break;

            case 21:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("알겠습니다.", 1);
                break;

            case 22:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그러면……원래 관리자님이 맡고 있던 임무는 어떻게 처리하는 것이 좋겠습니까?", 1);
                break;

            case 23:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("그 문제는 내가 해결하도록 하지, 그 정도 문제를 해결하기 위한 인물은 찾기 쉬우니.", 1);
                break;


            case 24:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("그러고 보니 마리아, 그 관리자……낚시에 관심이 있는가?", 1);
                break;

            case 25:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);


                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("예?", 1);
                break;

            case 26:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그건……물어본 적은 없습니다만……", 1);
                break;

            case 27:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("???님, 설마……", 1);
                break;

            case 28:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("낚싯대가 있다고 물고기가 저절로 잡히지 않는 법이지, 물고기를 유인할 매력적인 미끼가 필요한 법이네.", 1);
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
            Surprise_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
            Normal_eyes.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if(Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
            Surprise_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
            Normal_eyes.GetComponent<Image>().color = new Color(1, 1, 1);
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
