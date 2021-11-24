using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_3 : MonoBehaviour
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


    //제목 거점 수호 전

    //.setDelay(?);

    public void ForStory_3_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                Secretary.gameObject.SetActive(true);
                Normal_eyes.gameObject.SetActive(false);
                Surprise_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("관리자님, 긴급 상황입니다. 적군의 생명체가 저희를 향해 접근 중입니다.", 1);
                break;


            case 2:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("고로 현재의 목표는, 전력을 다해 적의 진격을 저지하는 것입니다.", 1);
                break;

            case 3:
                Normal_eyes.gameObject.SetActive(true);
                Surprise_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("관리자님, 이번 임무의 처리 대상은 바로 이 괴물입니다.", 1);
                break;

            case 4:

                NPC_1.gameObject.SetActive(true);

                Vector3 position = Secretary.transform.localPosition;
                position.x = 400;
                Secretary.transform.localPosition = position;

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("이 괴물의 정보를 잘 기억해두십시오.", 1);
                break;

            //[모니터를 킬 때 발생하는 효과음] 컷신 텍스트가 출력이 끝날 때 들리도록 설정

            case 5:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("이 녀석의 이름은 바포니스니르. 본부의 정보를 대조해 본 결과," +
                    " 해당 괴물은 다른 괴물들을 이끄는 것이 가능한 간부급 개체입니다.", 1);
                break;

            case 6:

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("이번 임무에서 해당 개체와 조우할 경우 전투, 포박 후 정보를 얻는 것입니다.", 1);
                break;

            case 7:

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그동안의 시시한 전투와는 다르게, 이번 전투는 매우 강력한 괴물을 상대해야 합니다.", 1);
                break;

            case 8:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("하지만 관리자님이시라면 이런 위기도 잘 넘기실 거라고 믿고 있습니다.", 1);
                break;


            case 9:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("작전을 시작합니다. 행운을 빕니다. 관리자님..", 1);
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

}
