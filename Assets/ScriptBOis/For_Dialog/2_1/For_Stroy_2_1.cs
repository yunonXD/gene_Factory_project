using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_2_1 : MonoBehaviour
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


    //제목 도박에는 상당한 대가가 따른다, 하이 리스크 하이 리턴(High Risk High Return)

    //.setDelay(?);


    public void ForStory_2_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("ETI 제조 공단 관리자 사무실", 1);
                break;


            case 2:
                Secretary.gameObject.SetActive(true);

                Normal_eyes.gameObject.SetActive(false);
                Smile_eyes.gameObject.SetActive(true);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("저번 임무는 예상 이상으로 위험한 상황이었습니다. 큰 피해 없이 무사히 마무리된 것이 천만다행입니다.", 1);
                break;

            case 3:
                Normal_eyes.gameObject.SetActive(true);
                Smile_eyes.gameObject.SetActive(false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("적군의 간부급 생명체를 포박했지만 놈들이 추가적인 계획이 있다는 사실밖에 알아내지 못했습니다.", 1);
                break;

            case 4:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("놈들의 공격은 끝나지 않았기 때문에 관리자님께 추가 임무를 부탁드리겠습니다.", 1);
                break;


            case 5:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("최근 위험 지역에서 벗어나지 않던 괴물들이 발견된다는 목격 정보입니다. " +
                    "위험 지역에 이상이 발생한 건지 파악해 주시길 바랍니다.",1);
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
