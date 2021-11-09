using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_1 : MonoBehaviour
{
    public GameObject ScreenLock;       //버튼 못누르게 락 걸기

    private int CountClick = 0;
    public Text _index;                 //대화 내용
    public Text _name;                  //이름
    public GameObject Secretary;        //비서 스프라이트
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


    //.setDelay(?);
    public void ForStory_1_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("ETI 제조 공단 사무실에 도착했다.", 1);
                break;


            case 2:
                _name.text = "";
                _index.DOText("본래 예정된 계획에 따라, 다음 훈련을 진행할 계획이었으나…", 1);
                break;

            case 3:
                _name.text = "마리아";
                _index.DOText("송구합니다. 관리자님…", 1);
                Secretary.gameObject.SetActive(true);
                break;

            case 4:
                _name.text = "마리아";
                _index.DOText("기존의 계획에 차질이 발생하여, 현재 계획에 변동이 생겼습니다.", 1);
                break;

            case 5:
                    ScreenLock.gameObject.SetActive(true);
                    SelectQ.gameObject.SetActive(true);
                    _Select_text1.text = "변경이요?";
                    _Select_text2.text = "긴급 상황인가요?";

                    if (CountClick == 5 && select1 == true || select2 == true)
                    {
                        Debug.Log("넘어옴");
                        select1 = false;
                        select2 = false;
                        CountClick += 1;
                    } 
               
                break;

            case 6:
                SelectQ.gameObject.SetActive(false);
                ScreenLock.gameObject.SetActive(false);
                _name.text = "마리아";
                _index.DOText("본사에서 급히 도움을 요청하셨습니다...", 1);
                break;

            case 7:
                _name.text = "마리아";
                _index.DOText("상부의 명령으로 최근 제조 공단의 인근 지역에 괴물들이 습격을 당했습니다.", 1);
                break;

            case 8:
                _name.text = "마리아";
                _index.DOText("이러한 습격으로 공단의 높으신 분들이 예의주시하고 있는 상황입니다.", 1);
                break;

            case 9:
                _name.text = "마리아";
                _index.DOText("본사에서는 괴물들을 처리하는 것과 동시에 괴물들이 습격하는 이유를 파악하는 것이 임무입니다.", 1);
                break;
            case 10:
                _name.text = "마리아";
                _index.DOText("상부의 지시에 따라서, 관리자님의 도움이 필요합니다.", 1);
                break;

            case 11:
                _name.text = "마리아";
                _index.DOText(" 관리자님은 입사한지 얼마 안 되었고, 훈련 횟수도 부족하지만" +
                    " 현재 남는 인력과 시간이 부족하기 때문에 어쩔 수 없다고 판단했습니다.", 1);
                break;

            case 12:
                _name.text = "마리아";
                _index.DOText("그러나 관리자님의 훈련 성적을 고려해보았을 때 이번 임무를 충분히 완수할 수 있을것입니다.", 1);
                break;

            default:
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
