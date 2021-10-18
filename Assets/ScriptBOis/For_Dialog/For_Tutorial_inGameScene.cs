using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_inGameScene : MonoBehaviour
{

    private int Clicker_Check = 0;      // 버튼 클릭 횟수로 판단 함. 시간 없어서 이렇게 만들어야함.


    public Text Name;
    public Text dialog;

    public GameObject BlockScrean_1;      //가장 뒤에 있는 클릭 방지 시스템
    public GameObject BlockScrean_2;      //유전자 지도를 위한 마스크

    public GameObject ArrowForGene;         //유전자 지도 가리키는 화살표

    public GameObject Checker;





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (Clicker_Check)
        {
            case 1:
                {
                    Name.text = "???";
                    dialog.text = "좋은 아침입니다. 관리자님.";

                }
                break;


            case 2:
                {
                    dialog.text = "ETI 제조 공단 사무실에 처음 오신 건데, 기분은 어떠십니까?";
                }
                break;

            case 3:
                {
                    dialog.text = "관리자님께서 ETI 제조 공단에 취직하신 것을 정말 축하드립니다.";
                }
                break;

            case 4:
                {
                    Name.text = "마리아";
                    dialog.text = "우선 제 소개를 드리자면, 제 이름은 마리아라고 합니다." +
                        " 관리자님의 개인 비서입니다.;";
                }
                break;
            case 5:
                {
                    dialog.text = "앞으로 마리아라고 부르시면 됩니다. 그러면 앞으로 관리자님으로 부르겠습니다.";

                }
                break;

            case 6:
                {
                    dialog.text = "오늘부터 관리자님은 ETI 제조 공단의 구역을 관리하는 관리자입니다.";

                }
                break;

            case 7:
                {
                    dialog.text = "관리자님께서 이 일을 잘 해낼 수 있을까 걱정이 되신다고요?";

                }
                break;

            case 8:
                {
                    dialog.text = "안심하세요, ETI 제조 공단은 언제나 엄격한 선별 과정을 거쳐 관리자를 선발합니다.";

                }
                break;

            case 9:
                {
                    dialog.text = "그런 엄격한 과정을 전부 통과하셨으니, 관리자님은 분명 문제없으실 겁니다.";

                }
                break;

            case 10:
                {
                    dialog.text = "그리고 다음 훈련에서는 관리자님이 일에 익숙해질 수 있도록 제가 도움을 드릴 예정입니다.";

                }
                break;

            case 11:
                {
                    Checker.gameObject.SetActive(false);
                    dialog.text = "자, 일단 유전자 지도로 전환해보도록 하죠.";
                    BlockScrean_1.gameObject.SetActive(false);
                    BlockScrean_2.gameObject.SetActive(true);
                    ArrowForGene.gameObject.SetActive(true);
                }
                break;

        }

    }



    public void Clicker_Count_Num()
    {
        Clicker_Check += 1;
        Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
    }
}

