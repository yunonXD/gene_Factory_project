using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_Stage_1_0 : MonoBehaviour
{
    private bool SkillChecker = false;

    private float waitgene = 0;
    private int Clicker_Check = 0;      // 버튼 클릭 횟수로 판단 함. 시간 없어서 이렇게 만들어야함.
    public Text dialog;
    public GameObject BlackScrean;
    public GameObject Checker;
    public GameObject Arrow;
    public GameObject For_Story;

    public Button SKILL;

    public Image skill_Amount;
    public Image skill_Amount_Dummy;
    public GameObject MissionClear;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        switch (Clicker_Check)
        {
            case 1:
                {
                    dialog.text = "잘 들리십니까. 관리자님?";
                }
                break;


            case 2:
                {
                    dialog.text = "모의 훈련의 준비가 완료되었으니, 언제든지 훈련을 시작하는 것이 가능합니다.";
                }
                break;

            case 3:
                {
                    dialog.text = "그럼 훈련을 시작하도록 하겠습니다.";
                }
                break;

            case 4:
                {

                    
                    dialog.text = "전투는 기본적으로 순서에 따라 차례대로 공격을 진행합니다.";
                   
                    BlackScrean.gameObject.SetActive(false);
                    Time.timeScale = 1;
                    waitgene += Time.deltaTime;
                    if (waitgene >= 5)
                    {
                        Time.timeScale = 0;
                    }


                }
                break;

            case 5:
                {
                    Time.timeScale = 1;
                    dialog.text = "공격/피격시 25퍼센트의 스킬게이지를 획득하고 " +
                        "\n 100퍼센트가 될시 스킬아이콘이 활성화 됩니다.";

                }
                break;

            case 6:
                {
                    Time.timeScale = 0;
                    Checker.gameObject.SetActive(false);
                    BlackScrean.gameObject.SetActive(true);
                    Arrow.gameObject.SetActive(true);
                    dialog.text = "스킬 버튼을 누를 시 해당 실험체의 스킬이 실행됩니다.";
                    skill_Amount_Dummy.gameObject.SetActive(true);

                    skill_Amount.fillAmount = 1;
                    SKILL.gameObject.SetActive(true);
                    if (SkillChecker == true)
                    {
                        SKILL.gameObject.SetActive(false);
                        skill_Amount_Dummy.gameObject.SetActive(false);
                        BlackScrean.gameObject.SetActive(false);
                        Arrow.gameObject.SetActive(false);
                        For_Story.gameObject.SetActive(false);
                        Time.timeScale = 1;
                    }
                }
                break;



        }

    }


    public void Clicker_Count_Num()
    {
        Clicker_Check += 1;
        Debug.Log("클리커 작동하는지 확인중 : " + Clicker_Check);
    }


    public void Skill_Check()
    {
        SkillChecker = true;
    }

}
