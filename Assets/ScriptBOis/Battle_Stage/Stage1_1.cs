using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class Stage1_1 : MonoBehaviour
{

    public GameObject player;       //플레이어 캐릭터
    public GameObject enemy;        //적 캐릭터 붉은 머시
    private int enemyDamage;        //적이 아군에게 주는 피해량
    private int playerDamage;       //아군이 적에게 주는 피해량
    public Image Player_Hpbar;      //아군캐릭터 HP바 동기화
    public Image Enemy_HPbar;       //적군캐릭터 Hp바 동기화
    public Image Skiil_Bar;         //스킬게이지 동기화
    private float Player_HPMax;     //아군캐릭터 Hp바 백분율 처리용 변수
    private float Enemy_HPMax;      //적군캐릭터 Hp바 백분율 처리용 변수
    float time = -3.0f;                 //프레임별 딜레이용 time 변수
    private bool OrderAttack;      //true : 아군공격차례, false : 적 공격차례   
    private float skill;
    public GameObject SkillIcon;
    private bool SkillAttack = false;       //스킬공격여부
    private bool isdead = false;
    public Camera MainCamera;
    public Image BlackPanel;
    public GameObject EnemyDamageText;
    public GameObject PlayerDamageText;
    public GameObject Skilleffect;
    public GameObject MissionFail;      
    public GameObject MissionClear;
    public GameObject SaveData;
    private bool CameraRoundR = false;
    private bool CameraRoundL = false;


    // public GameObject boss;

    void Start()
    {
        //MainCamera.GetComponent<CameraShake>().AttackCameraShake(1.5f, 5);
        //기본셋팅
        enemyDamage = enemy.GetComponent<EnemyMush>().Power - player.GetComponent<MushScript>().Defense;
        playerDamage = player.GetComponent<MushScript>().Power - enemy.GetComponent<EnemyMush>().Defense;
        Player_HPMax = player.GetComponent<MushScript>().HP;
        Enemy_HPMax = enemy.GetComponent<EnemyMush>().HP;

        if (player.GetComponent<MushScript>().Agility > enemy.GetComponent<EnemyMush>().Agility) //적의 민첩이 아군민첩보다 높을경우 적 공격시전
        {
            OrderAttack = true;
        }
         else
        {
            OrderAttack = false;
        }
        //암전효과 검은색 패널 페이드 아웃
        BlackPanel.DOFade(0, 2.0f);
        //등장 구현필요
        //이동 스파인 수정요청필요.
        Invoke("characterstartmove", 3.0f);
    }
    void characterstartmove()
    {
        player.GetComponent<MushScript>().wait_2();
    }

    // Update is called once per frame
    void Update()
    {

        if(CameraRoundR == true)
        {
            MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 10), 0.5f);
            MainCamera.transform.DOLocalMoveZ(100, 0.5f);
            MainCamera.transform.DOLocalMoveZ(-12.5f, 0.5f);
            MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
 
        }

        if(CameraRoundL == true)
        {
            MainCamera.transform.DOLocalRotate(new Vector3(0, 0, -10), 0.5f);
            MainCamera.transform.DOLocalMoveZ(100, 0.5f);
            MainCamera.transform.DOLocalMoveZ(-12.5f, 0.5f);
            MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
        }


        if (time < 2.0f || isdead == true) 
        {
            time += Time.deltaTime;
        }
        else
        {
            if(skill == 1.0f) //스킬게이지 체크 1.0 == 스킬충전완료
            {
                SkillIcon.SetActive(true);      //스킬 충전완료시 활성화
            }
            else
            {
                SkillIcon.SetActive(false);     //미충전시 비활성화
            }

            if(OrderAttack == true)
            {

                if(SkillAttack == true)
                {
                    SkiilAttack();
                    Invoke("ResetDamageText", 1.5f);
                }
                else
                {
                    //player.transform.DOLocalMoveX(660, 0.1f);
                    enemy.transform.DOLocalMoveX(560, 0.1f);
                    PlayerAttack();
                    CameraRoundR = true;

                    Invoke("ResetDamageText", 0.7f);

                }
                OrderAttack = false;
                skill = skill + 0.25f; //스킬게이지추가
            }

            else if(OrderAttack == false)
            {
                EnemyAttack();
                CameraRoundL = true;
                Invoke("ResetDamageText", 1.0f);
                OrderAttack = true;
                skill = skill + 0.25f; //스킬게이지추가
            }
            time = 0;
        }


        Player_Hpbar.fillAmount = player.GetComponent<MushScript>().HP / Player_HPMax;
        Enemy_HPbar.fillAmount = enemy.GetComponent<EnemyMush>().HP / Enemy_HPMax;
        Skiil_Bar.fillAmount = skill;
        if(skill >= 1)
        {
            SkillIcon.SetActive(true);
        }


        if (enemy.GetComponent<EnemyMush>().HP <= 0)  //적 사망
        {
            //Invoke("StageClear", 2.0f);

        }


        if (player.GetComponent<MushScript>().HP <= 0) //아군 캐릭터 사망
        {
            isdead = true;
            GameOver();
        }

    }


    void StageClear()
    {
        ResetDamageText();
        time = 0;
        enemy.SetActive(false);
        isdead = true;
        Invoke("Clearsave", 5f);
        MissionClear.SetActive(true);
    }

    void Clearsave()
    {
        SaveData.GetComponent<SaveDataManager>()._ResearchPoint = SaveData.GetComponent<SaveDataManager>()._ResearchPoint + 3; //클리어 보상 +3
        SaveData.GetComponent<SaveDataManager>().Save();
        SceneManager.LoadScene("inGameScene");
    }

    void failsave()
    {
        SceneManager.LoadScene("inGameScene");
    }

    void GameOver()
    {
        if (time < 1.0f)
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0;
            player.SetActive(false);
            Invoke("failsave", 5f);
            ResetDamageText();

        }
        time += Time.deltaTime;
        MissionFail.SetActive(true);
    }

    void PlayerAttack()
    {
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        player.GetComponent<MushScript>().attack();
        player.transform.DOLocalMoveX(200,0.3f).SetEase(Ease.OutBack); //이동 속도 관련 //공격이동 0.3
        enemy.GetComponent<EnemyMush>().damage(); //피격모션
        enemy.GetComponent<EnemyMush>().HP = enemy.GetComponent<EnemyMush>().HP - playerDamage; //공격시 대미지 계산 후 적군 캐릭터 HP 감소
        PlayerDamageText.GetComponent<DamageScript>().damage(0,4);               

        Invoke("resetposition", 1.0f); // 1.0초 뒤에 원위치 진행    
        Invoke("CameraReset", 1f);
    }
    void resetposition()
    {
        player.transform.DOLocalMoveX(-660, 0.5f).SetEase(Ease.OutQuad);
        enemy.transform.DOLocalMoveX(860, 0.5f).SetEase(Ease.OutQuad);
    }

    void SkiilAttack()
    {
        //스킬 이펙트시간 부여후 스킬 연출 함수 작성필요
        player.GetComponent<MushScript>().skill();
        enemy.GetComponent<EnemyMush>().damage();
        Skilleffect.SetActive(true);
        enemy.GetComponent<EnemyMush>().HP = enemy.GetComponent<EnemyMush>().HP - playerDamage; //공격시 대미지 계산 후 적군 캐릭터 HP 감소
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // 스킬계수
        isdead = true;

        Invoke("CameraReset", 1f);
    }

    void EnemyAttack()
    {
        Skilleffect.SetActive(false);
        player.GetComponent<MushScript>().damage();
        enemy.GetComponent<EnemyMush>().attack_1();
        player.GetComponent<MushScript>().HP = player.GetComponent<MushScript>().HP - enemyDamage; //피격시 대미지 계산후 아군 캐릭터 HP 감소
        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        Invoke("CameraReset", 1f);
    }

    public void usedSkill()
    {
        skill = 0f;
        SkillAttack = true;
        SkillIcon.SetActive(false);
    }

    void CameraReset()
    {
       // MainCamera.transform.position = new Vector3(0.5f, 1, -13);
        //MainCamera.transform.eulerAngles = Vector3.forward * 0f;
        CameraRoundL = false;
        CameraRoundR = false;

    }

    void ResetDamageText()
    {
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        EnemyDamageText.GetComponent<DamageScript>().Reset();
    }

    void SkilleffectOff()
    {
        Skilleffect.gameObject.SetActive(false);
    }


}
