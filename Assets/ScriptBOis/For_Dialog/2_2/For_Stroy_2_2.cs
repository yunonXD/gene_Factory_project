using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_2 : MonoBehaviour
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


    //제목 구조신호

    //.setDelay(?);



    public void ForStory_2_2()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                Secretary.gameObject.SetActive(true);
                _name.text = "마리아";
                _index.DOText("관리자님, 새로운 임무가 도착했습니다.", 1);
                break;


            case 2:
                //[모니터를 킬 때 발생하는 효과음] 컷신 텍스트가 출력이 끝날 때 들리도록 설정
                break;

            case 3:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("숲 근처에 있던 ETI 제조 공단의 부속 공장에서 긴급 구조 신호를 받았습니다. ", 1);
                break;

            case 4:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("관리자님의 임무는 해당 공장의 정찰 및 생존자 확보, 해당 장소에서 일어난 일을 파악하는 것입니다.", 1);
                break;


            case 5:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("정보에 따르면, 공장 내부에 생존자가 남아있을 가능성이 높습니다. " +
                    "그렇기에 이번 임무는 인명구조를 최우선으로 하고 적기 개체로부터 공장을 지켜내야 합니다.", 1);
                break;

            case 6:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("공장 외부에 적들이 생존자들이 탈출하지 못하도록 포위하고 있어 적들을 유인해 각개격파하는 것이 효과적일 것으로 판단됩니다.", 1);
                break;

            case 7:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("만약 공장에 살아남은 생존자가 없을 경우 공장 내부의 데이터를 확보해야 합니다.", 1);
                break;

            case 8:
                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("그러면 저는 임무 완료 보고를 기다리고 있겠습니다.", 1);
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
