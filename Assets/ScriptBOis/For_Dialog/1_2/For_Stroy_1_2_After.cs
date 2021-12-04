using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_2_After : MonoBehaviour
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
    public GameObject PlayerData;
    public GameObject MainBG_2;
    public GameObject FadeBoi;          //페이드 인 아웃 시킬 검은 화면
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //선택창
    public Button SelectQ_B_1;          //선택창에 있는 상호작용 버튼
    public Button SelectQ_B_2;          //선택창에 있는 상호작용 버튼
    public Text _Select_text1;          //선택창에 나올 텍스트1
    public Text _Select_text2;          //선택창에 나올 텍스트2

    bool select1 = false;
    bool select2 = false;


    private Animator animator;

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


    //제목 모의훈련 후


    public void ForStory_2_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("훈련을 종료하고, 훈련 결과를 분석한 기록을 정리해 마리아에게 전달했다.", 1);
                break;


            case 2:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("본부로부터의 분석 결과를 기다리는 중, 잠시 후…", 1);
                ForStory_FMod.instance.Printer();

                //[인쇄기에서 종이가 출력될 때 발생하는 효과음] 컷신 텍스트가 출력과 동시에 들리도록 설정
                break;

            case 3:
                Secretary.gameObject.SetActive(true);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("고생하셨습니다, 관리자님.", 1);
                break;

            case 4:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("적의 수치가 올라갔음에도 문제없이 통과하셨습니다.", 1);
                break;

            case 5:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("이 정도라면 저희 쪽에서 문제가 발생하더라도 대응할 수 있을 것으로 판단됩니다.", 1);
                break;

            case 6:

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그러나, 적들이 어떠한 비장의 수를 가지고 있을지 모릅니다. 어떤 상황에서도 침착하게 대처하십시오.", 1);
                break;

            case 7:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그럼 다음 훈련에 뵙도록 하겠습니다.", 1);
                break;

            case 8:

                FadeBoi.gameObject.SetActive(true);

                break;


            case 9:

                Secretary.gameObject.SetActive(false);
                _name.text = "";
                _index.DOText("", 1);
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);

                MainBG_2.gameObject.SetActive(true);

                break;



            case 10:
                
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("ETI 제조 공단 관리 구역 밖", 1);
                break;

            case 11:

                NPC_1.gameObject.SetActive(true);
                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("간사한 술수를 부리는군요, ETI 제조 공단.", 1);
                break;

            case 12:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("그러나, 당신들의 행동은 당신들의 멸망의 순간을 늦추기만 할 뿐입니다.", 1);
                break;

            case 13:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("얌전히 멸망을 기다리면 그분께 편히 보내 드리는 것을…", 1);
                break;

            case 14:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("다시 한번 더 말해주겠습니다, 어리석은 자들이여.", 1);
                break;


            case 15:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("어떠한 작전을 세우더라도 당신들의 멸망은 필연적입니다.", 1);
                break;

            case 16:

                _name.text = "";
                _index.DOText("???", 1);
                _index.DOText("", 1);
                _index.DOText("최대한 발버둥을 해보십시오 ETI 제조 공단..", 1);
                break;

            case 17:
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);
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

}
