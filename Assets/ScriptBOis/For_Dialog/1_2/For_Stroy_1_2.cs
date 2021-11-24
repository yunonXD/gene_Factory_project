using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_2 : MonoBehaviour
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


    //제목 모의훈련 전

    //.setDelay(?);


    //ScreenLock.gameObject.SetActive(true);
    //SelectQ.gameObject.SetActive(true);
    //_Select_text1.text = "변경이요?";
    //_Select_text2.text = "긴급 상황인가요?";

    //if (CountClick == 5 && select1 == true || select2 == true)
    //{
    //    Debug.Log("넘어옴");
    //    select1 = false;
    //    select2 = false;
    //    CountClick += 1;
    //} 

    //    SelectQ.gameObject.SetActive(false);

    //    ScreenLock.gameObject.SetActive(false);

    public void ForStory_1_2()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                Secretary.gameObject.SetActive(true);
                _name.text = "마리아";
                _index.DOText("안녕하십니까, 관리자님.", 1);
                break;


            case 2:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("앞으로의 실전에서 좋은 성과를 내기 위해서 필요한 훈련이라고 판단합니다.", 1);
                break;

            case 3:

                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("시간이 여유롭지 않은 상황이기 때문에 실전 경험을 쌓기 전에 실전을 대비한 훈련을 준비했습니다.", 1);
                break;

            case 4:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("부디 이번 훈련을 통해 실제 상황에서도 적응하고 유연하게 대처할 수 있기를 바랍니다.", 1);
                break;

            case 5:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("이번 전투는 현재 파악한 전투 데이터를 기준으로, 전장에 훈련용 적군을 배치했습니다.", 1);
                break;

            case 6:

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("다만 훈련을 위해 적군의 능력치를 올려 상황 판단 능력을 기르기 좋을 것입니다.", 1);
                break;

            case 7:

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("준비가 되셨다면 훈련을 시작하겠습니다.", 1);
                break;

            case 8:

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("이번 훈련을 통해 위기의 상황에서 관리자님의 상황 판단 능력을" +
                    " 입증하신다면 실전에서도 여유롭게 이겨 내실 겁니다.", 1);
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
