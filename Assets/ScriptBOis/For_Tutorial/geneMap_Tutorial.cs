using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class geneMap_Tutorial : MonoBehaviour
{
    public GameObject PlayerData;           //세이브데이터
    public GameObject Tutorial;             //튜토리얼띄워줄부모객체
    public GameObject Indicator;            //화살표
    public GameObject[] GenemapBlocker;       //유전자 지도 클릭 가림막
    public Toggle[] geneSelect;

    public Text C_name;
    public Text C_Dialogue;

    private int Yeeter = 0;               //다이어로그 읽어올 세이브파일 받아올 인트값
    private GameObject obj;
    private GameObject obj1;
    private GameObject obj2;

    private int CountClick = 0;
    private GameObject Option;

    void Start()
    {
        Option = GameObject.Find("GameManager");


        //튜토리얼 진행을 위한 _Gene_Between3 판별
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {
            Tutorial.gameObject.SetActive(true);
            //esc 작동 스크립트 DEAD
            Option.GetComponent<Button_Editor>().enabled = false;

            //콘레빗 제외 모두 비활성화
            for (int i = 0; i < 8; i++){
                geneSelect[i].GetComponent<Toggle>().interactable = false;
                Debug.Log(geneSelect[i]);
            }
    

        }
        else
        {
            //esc 작동 스크립트 Alive
            Option.GetComponent<Button_Editor>().enabled = true;
            Tutorial.gameObject.SetActive(false);
            //다시 모두 활성화
            for (int i = 0; i < 8; i++)
            {
                geneSelect[i].GetComponent<Toggle>().interactable = true;
                Debug.Log(geneSelect[i]);
            }
            Destroy(this);      //안쓰면 삭제
        }


    }


    void Update()
    {
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;
    }

    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "포인트이만큼 세이브");
    }

    public void geneMapSceneTutorial()
    {

        Yeeter = Yeeter + 1;
        PointSaver();

        switch (Yeeter)
        {
            case 12:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("먼저, 주어진 포인트를 이용해 실험체를 해금해보도록 합시다.", 1);
                break;

            case 13:

                GenemapBlocker[0].gameObject.SetActive(true);
                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(-197f, -295f, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -90f);

                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("먼저 큰 지도를 클릭", 1);

                obj = GameObject.Find("BigIcon8_ForCheck"); 
                
                if (obj.GetComponent<Toggle>().isOn == true)
                {
                    Yeeter = Yeeter + 1;
                }

                break;


            case 14:
                GenemapBlocker[0].gameObject.SetActive(false);      //8번 아이콘 only

                Indicator.gameObject.SetActive(false);


                GenemapBlocker[1].gameObject.SetActive(true);       //다이어로그가림막

                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("관리자님은 유전자 지도에서 실험체를 만들어 내는 것이 가능합니다. ", 1);
                break;

            case 15:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("큰 지도에서는 실험체를 해금할 수 있습니다. ", 1);
                break;

            case 16:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("작은 지도는 다음 단계로 이어지기 위해 필요합니다. " +
                    "이 부분은 해금할 때가 되면 자세히 설명드리겠습니다. ", 1);
                break;

            case 17:
                GenemapBlocker[1].gameObject.SetActive(false);
                GenemapBlocker[2].gameObject.SetActive(true);      //오픈버튼 가림막

                Indicator.gameObject.SetActive(true);
                Indicator.gameObject.transform.localPosition = new Vector3(745, -381, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -90);


                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("선택한 지도를 해금하기 위해, OPEN 버튼을 클릭해봅시다. ", 1);

                break;



            case 18:


                StartCoroutine(CountAttackDelay());


                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText(" 이곳을 클릭해주세요. ", 1);
                break;


            case 19:

                GenemapBlocker[2].gameObject.SetActive(false);
                GenemapBlocker[0].gameObject.SetActive(true);

                Indicator.gameObject.transform.localPosition = new Vector3(-143, -312, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -120);

                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("실험체 버튼을 클릭하면 실험체 정보를 다시 볼 수 있습니다. ", 1);


                obj1 = GameObject.Find("BigIcon8_Toggle");

                if (obj1.GetComponent<Toggle>().isOn == true)
                {
                    Yeeter = Yeeter + 1;
                }
                break;


            case 20:
                GenemapBlocker[0].gameObject.SetActive(true);


                Indicator.gameObject.transform.localPosition = new Vector3(-413, -291, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, -30);


                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("실험체 왼쪽의 ‘정보’ 버튼을 클릭하면 실험체 정보를 다시 볼 수 있습니다. ", 1);

                obj2 = GameObject.Find("unlocked_8_Intel");

                if (obj2.GetComponent<Toggle>().isOn == true)
                {
                    Yeeter = Yeeter + 1;
                }
                break;


            case 21:
                GenemapBlocker[0].gameObject.SetActive(false);
                GenemapBlocker[3].gameObject.SetActive(true);

                Indicator.gameObject.transform.localPosition = new Vector3(-632, -5, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 130);

                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("실험체 왼쪽의 ‘정보’ 버튼을 클릭하면 실험체 정보를 다시 볼 수 있습니다. ", 1);

                break;



            case 22:
                GenemapBlocker[3].gameObject.SetActive(false);
                GenemapBlocker[4].gameObject.SetActive(false);
                Tutorial.gameObject.SetActive(false);



                break;

            case 23:
                GenemapBlocker[4].gameObject.SetActive(false);
                GenemapBlocker[5].gameObject.SetActive(true);

                Tutorial.gameObject.SetActive(true);
                GenemapBlocker[3].gameObject.SetActive(false);

                Indicator.gameObject.transform.localPosition = new Vector3(-706, -444, 0);
                Indicator.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("생명체를 획득했으니 전투 훈련으로 넘어가겠습니다. ", 1);


                break;


            default:
                break;
        }


    }

    IEnumerator CountAttackDelay()
    {
        Debug.Log("18으로 넘어옴");
        Tutorial.gameObject.SetActive(false);
        Debug.Log("코루틴시작");
        yield return new WaitForSeconds(7.5f);
        Tutorial.gameObject.SetActive(true);

    }






}
