using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class For_Tutorial_Final : MonoBehaviour
{
    private int Clicker_Check = 0;      // 버튼 클릭 횟수로 판단 함. 시간 없어서 이렇게 만들어야함.
    public GameObject Checker;
    public Text dialog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (Clicker_Check)
        {
            case 0:
                {
                    dialog.text = "이번 훈련으로 앞으로의 할 일이 무엇인지 깨달으셨나요?";
                }
                break;

            case 1:
                {
                    dialog.text = "ETI 제조 공단은 세계의 안전을 되찾기 위해 만들어진 제조 회사입니다.";
                }
                break;

            case 2:
                {
                    dialog.text = "현재 ETI 제조 공단에게 가장 큰 위협은 바로 지구상에 존재하는 괴물들입니다.";
                }
                break;
            case 3:
                {
                    dialog.text = "그렇기 때문에 관리자님이 하셔야 되는 업무는 생명체를 관리하고" +
                        " 적대하는 괴물들과 맞서 싸워야 합니다.";
                }
                break;

            case 4:
                {
                    dialog.text = "그러면 이번 작전은 여기서 끝내겠습니다.수고하셨습니다.";

                }
                break;

            case 5:
                {
                    dialog.text = "한번더 클릭하실 경우 본 게임으로 새로 시작합니다.";

                }
                break;

            case 6:
                {
                    SceneManager.LoadScene("FirstScene");

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
