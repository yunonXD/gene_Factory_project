using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GeneMemory_Tutorial : MonoBehaviour
{
    
    public GameObject PlayerData;           //세이브데이터
    public GameObject Tutorial;             //튜토리얼띄워줄부모객체


    public Text C_name;
    public Text C_Dialogue;

    private int Yeeter = 0;
    private GameObject Option;


    void Start()
    {
        Tutorial.gameObject.SetActive(true);

        Option = GameObject.Find("GameManager");

        
    }


    void Update()
    {
        CheckGMTutorial();
        Yeeter = PlayerData.GetComponent<SaveDataManager>()._DialgueCounter;
    }


    void CheckGMTutorial()
    {
        //튜토리얼 진행을 위한 _Gene_Between3 판별
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {

            //esc 작동 스크립트 DEAD
            Option.GetComponent<Button_Editor>().enabled = false;

        }
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == true)
        {
            //esc 작동 스크립트 Alive
            Option.GetComponent<Button_Editor>().enabled = true;
            Tutorial.gameObject.SetActive(false);

            Destroy(Tutorial);
            Destroy(this);      //안쓰면 삭제
        }
    }

    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._DialgueCounter = Yeeter;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._DialgueCounter + "포인트이만큼 세이브");
    }


    public void gamememoryTutorial()
    {
        Yeeter = Yeeter + 1;
        PointSaver();

        switch (Yeeter)
        {
            case 36:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("이후 전투에서 승리하고 보신 스토리를 선택하시고 우측의 영상을 클릭하시면," +
                    " 여태까지의 기록을 확인할 수 있습니다.", 1);
                break;

            case 37:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("스토리를 다시 감상하고 싶으시다면 이곳으로 와주시면 됩니다.", 1);
                break;

            case 38:
                C_name.text = "마리아";
                C_Dialogue.DOText("", 1);
                C_Dialogue.DOText("그럼 다시 사무실로 이동하겠습니다.", 1);
                break;

            case 39:
                SceneManager.LoadScene("inGameScene");
                break;











        }
    }
}
