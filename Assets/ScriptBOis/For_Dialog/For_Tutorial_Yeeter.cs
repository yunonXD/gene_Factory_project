using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_Yeeter : MonoBehaviour
{
    private int Clicker_Check = 0;      // 버튼 클릭 횟수로 판단 함. 시간 없어서 이렇게 만들어야함.
    private bool ISON = false;                  //언락버튼 눌렸는지 아닌지 확인해야함.

    public GameObject For_Story;        //스토리창

    public GameObject Clicker;          //화면 클릭하면 숫자 올라가는 카운터
    public Text dialog;                 //텍스트 출력용 다이어로그

    public GameObject BlackScreen1;     //unknown을 위한 가림막
    public GameObject Arrow_1;          //unknown을 가리킬 화살표
    public Toggle BigIcon7_ForCheck;    //unknow 토글

    public GameObject BlackScreen2;     //Open을 위한 가림막

    public Toggle BigIcon7_Toggle;
    public GameObject Arrow_2;          //gene 가리킬 화살표
    public Toggle unlocked_7_Intel; //인텔

    public GameObject Arrow_3;          //intel 을 가리킬

    public Toggle BigIcon7_Intel_Sus;

    public GameObject Arrow_4;          //big intel 을 가리킬

    public GameObject Arrow_5;          //exit을 가리킬

    public GameObject Screen_For;


    public GameObject BlackScreen3;     //EXIT을 위한 가림막


    //임시용 스크립트. 이건 사용할 예정이 없음.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // 와 살다살다 이걸 이렇게 만들어보네 ㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋ 미치겠네 진짜
        switch (Clicker_Check)
        {
            case 0:
                {
                    dialog.text = "먼저, 주어진 포인트를 이용해 실험체를 해금해보도록 합시다.";
                }
                break;

            case 1:
                {
                    dialog.text = "먼저 큰 지도를 클릭.";
                    BlackScreen1.gameObject.SetActive(true);
                    Arrow_1.gameObject.SetActive(true);
                    Clicker.gameObject.SetActive(false);

                    if (BigIcon7_ForCheck.isOn)
                    {
                        Clicker.gameObject.SetActive(true);
                        
                    }

                }
                break;


            case 2:
                {

                    BlackScreen1.gameObject.SetActive(false);
                    Arrow_1.gameObject.SetActive(false);
                    dialog.text = "관리자님은 유전자 지도에서 실험체를 만들어 내는 것이 가능합니다.";

                }
                break;

            case 3:
                {

                    dialog.text = "큰 지도에서는 실험체를 해금할 수 있습니다.";

                }
                break;

            case 4:
                {

                    dialog.text = "작은 지도는 다음 단계로 이어지기 위해 필요합니다." +
                        " 이 부분은 해금할 때가 되면 자세히 설명드리겠습니다. ";

                }
                break;
            case 5:
                {
                    Clicker.gameObject.SetActive(false);
                    dialog.text = "선택한 지도를 해금하기 위해, OPEN 버튼을 클릭해봅시다. ";
                    BlackScreen2.gameObject.SetActive(true);


                    if (ISON == true)
                    {

                        Debug.Log("실행됨");
                        For_Story.gameObject.SetActive(false);
                        BlackScreen2.gameObject.SetActive(false);
                        Clicker_Check += 1;
                    }


                }
                break;
            case 6:
                {
                    StartCoroutine("WaitForUnilockAnime");
 
                }
                break;

            case 7:
                {
                    StopCoroutine("WaitForUnilockAnime");
                    Clicker.gameObject.SetActive(false);
                    Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
                    dialog.text = "실험체 버튼을 클릭하면 실험체 정보를 다시 볼 수 있습니다.";
                    BlackScreen2.gameObject.SetActive(true);
                    Arrow_2.gameObject.SetActive(true);

                    if (BigIcon7_Toggle.isOn)
                    {
                        Arrow_2.gameObject.SetActive(false);
                        Arrow_3.gameObject.SetActive(true);

                        if (unlocked_7_Intel.isOn)
                        {
                            Arrow_3.gameObject.SetActive(false);
                            Arrow_4.gameObject.SetActive(true);
                            if (BigIcon7_Intel_Sus.isOn)
                            {
                                Arrow_4.gameObject.SetActive(false);
                                    Clicker_Check = 8;
                            }
                        }
                    }

                }
                break;



            case 8:
                {
                    StartCoroutine("ScreanWait");


                }
                break;





            case 9:
                {
                    StopCoroutine("ScreanWait");
                    Clicker.gameObject.SetActive(false);
                    BlackScreen2.gameObject.SetActive(false);
                    BlackScreen3.gameObject.SetActive(true);
                    Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
                    dialog.text = "생명체를 획득했으니 전투 훈련으로 넘어가겠습니다.";
                    Arrow_5.gameObject.SetActive(true);

                }
                break;







        }




    }


    public void UnlockButton_Checker()
    {
        ISON = true;
    }


    IEnumerator WaitForUnilockAnime()
    {
        yield return new WaitForSeconds(9.0f);
        For_Story.gameObject.SetActive(true);
        Clicker.gameObject.SetActive(true);
    }

    IEnumerator ScreanWait()
    {
        yield return new WaitForSeconds(4.0f);
        Clicker.gameObject.SetActive(true);

    }


    public void Clicker_Count_Num()
    {
        Clicker_Check += 1;
        Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
    }






}
