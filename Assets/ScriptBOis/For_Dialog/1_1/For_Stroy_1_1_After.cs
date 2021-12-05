using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_1_After : MonoBehaviour
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
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //선택창
    public Button SelectQ_B_1;          //선택창에 있는 상호작용 버튼
    public Button SelectQ_B_2;          //선택창에 있는 상호작용 버튼
    public Text _Select_text1;          //선택창에 나올 텍스트1
    public Text _Select_text2;          //선택창에 나올 텍스트2
    public GameObject MoveBlackScreen;
    public GameObject MoveBlackScreen_1;
    public GameObject MoveBlackScreen_2;
    public GameObject SpookyBG;


    bool select1 = false;
    bool select2 = false;

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


    // 제목 예상치 못한 기습 후

    //.setDelay(?);
    public void ForStory_1_1_After()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("…성공적으로 괴물들을 섬멸했고 공단 설비의 피해도 최소한으로 막아냈다.", 1);
                break;


            case 2:
                Secretary.gameObject.SetActive(true);
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("임무도 성공적이군요, 이번 성과는 상부에서도 좋게 평가하실 겁니다.", 1);
                break;

            case 3:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("음… 괴물들에 관해 아직 모르는 것이 있습니까?", 1);
                break;

            case 4:
                _name.text = "";
                ScreenLock.gameObject.SetActive(true);
                SelectQ.gameObject.SetActive(true);
                _Select_text1.text = "괴물들이 나타난 이유가 뭐죠?";
                _Select_text2.text = "ETI는 어쩌다 괴물들을 상대하게 된 건가요?";

                if (CountClick == 4 && select1 == true || select2 == true)
                {
                    Debug.Log("넘어옴");
                    select1 = false;
                    select2 = false;
                    CountClick += 1;
                }
                break;

            case 5:
                SelectQ.gameObject.SetActive(false);
                ScreenLock.gameObject.SetActive(false);

                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("…따지고 보면, 이번 모집의 경우 즉시 전력이 필요했기 때문에 선발 과정에서 촉박하게 진행됐으니", 1);
                break;

            case 6:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("아직 정보가 부족한 것도 당연합니다.", 1);
                break;


            case 7:
                MoveBlackScreen.gameObject.SetActive(true);
                MoveBlackScreen.GetComponent<MoveBlackScreen>().MoveR_TO_L();
                break;

            case 8:

                //[모니터를 킬 때 발생하는 효과음] 컷신 텍스트가 출력과 동시에 들리도록 설정
                ForStory_FMod.instance.Monitor_On();

                MoveBlackScreen.GetComponent<MoveBlackScreen>().MoveR_TO_L_Num2();
                SpookyBG.gameObject.SetActive(true);
                _name.text = "마리아";
                //_index.DOText("", 1);
                _index.text="현재 저희가 싸우고 있는 괴물들은 조합 기술 입자에 노출된 생명체를 말합니다.";
                break;


            case 9:
                MoveBlackScreen_1.gameObject.SetActive(true);
                MoveBlackScreen_1.GetComponent<MoveBlackScreen>().MoveR_TO_L();
                break;

            case 10:
                MoveBlackScreen_1.GetComponent<MoveBlackScreen>().MoveR_TO_L_Num2();
                _name.text = "마리아";
                _index.text="그중에서도 생명체가 조합되면서 강력한 힘을 가진 생명체는 개인 능력치가 매우 뛰어났습니다.";

                break;

            case 11:
                MoveBlackScreen_2.gameObject.SetActive(true);
                MoveBlackScreen_2.GetComponent<MoveBlackScreen>().MoveR_TO_L();

                break;

            case 12:
                MoveBlackScreen_2.GetComponent<MoveBlackScreen>().MoveR_TO_L_Num2();
                SpookyBG.gameObject.SetActive(false);
                _name.text = "마리아";
                //_index.DOText("", 1);
                _index.text="괴물들은, 기본적으로 인간들을 적대하며 인간들을 무차별로 공격했습니다.";
                break;

            case 13:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("괴물들의 공격으로 인해 인류는 한차례 위기를 겪었습니다.", 1);
                break;

            case 14:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText(" 저희 ETI 제조 공단은 조합 기술을 연구해 실험체를 만들어 대항하기 시작했고" +
                    " 점차 안정되어 가고 있었습니다.", 1);
                break;

            case 15:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그러나 괴물들 역시 변화하기 시작했고 변화한 괴물의 강력함으로 인해 ETI 제조 공단은" +
                    " 피해를 입고 다시 한번 위기를 겪게 되었습니다.", 1);
                break;


            case 16:
                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("피해를 입은 ETI 제조 공단은 부족한 관리자를 보충하기 위해 " +
                    "적임자를 급히 모집해 관리자 권한을 맡기게 된 것입니다.", 1);
                break;

            case 17:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그런고로, ETI 제조 공단에 입사하신 것을 다시 한번 환영합니다 관리자님.", 1);
                break;

            case 18:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("이후에 무슨 일이 일어나든, 적어도 이 순간에는 깊은 감사를 드립니다.", 1);
                break;


            case 19:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그럼 다음 임무에 대해 설명하겠습니다.", 1);
                break;

            case 20:
                

                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("삑…", 1);
                ForStory_FMod.instance.Signal_off();
                break;


            case 21:
                //Secretary.gameObject.SetActive(false);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("채널에서 본사의 통신 요청이 들어왔다.", 1);
                break;

            case 22:
                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("죄송합니다. 잠시만 기다려 주십시오…", 1);
                break;

            case 23:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("마리아가 몸을 돌려 본사와 연락을 취했다.", 1);
                break;


            case 24:


                //[시계 초침이 움직일 때 발생하는 효과음] 컷신 텍스트가 출력이 끝날 때 들리도록 설정
                ForStory_FMod.instance.Clock_Sound(); 

                break;


            case 25:
                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("예……알겠습니다. 제가 관리자님께 설명하겠습니다.", 1);
                break;

            case 26:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("방금 본사에서 연락을 받았습니다. 다른 지역에 문제가 발생하여 " +
                    "기존에 진행하려던 일정이 변경되었습니다.", 1);
                break;

            case 27:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("일정 변경으로 인해 오늘의 훈련은 여기까지입니다. " +
                    "저는 다음 훈련에 관한 정보를 정리하겠습니다. 수고하셨습니다 관리자님.", 1);
                break;


            default:

                if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between2 == false)
                {
                    SceneManager.LoadScene("inGameScene");
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


    public void InputCountNum()
    {
        CountClick += 1;

        Debug.Log(CountClick);
    }

}
