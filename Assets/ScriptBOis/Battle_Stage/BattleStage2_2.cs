using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class BattleStage2_2 : MonoBehaviour
{

    //모디빅 vs 만티

    public GameObject player;       //플레이어 캐릭터
    public GameObject enemy;        //Mob
    public GameObject Boss;         //Boss
    public GameObject enemy_blood_1;      //피격 피이펙트1
    public GameObject player_blood_1;
    public GameObject Boss_blood_1;
    public GameObject Mob_Name_Bar;
    public GameObject Boss_Name_Bar;
    public GameObject UICanvas;
    public Image MoveCloud;
    private new MeshRenderer renderer;
    private MaterialPropertyBlock _block;
    private int enemyDamage;        //적이 아군에게 주는 피해량
    private int _enemyDamage;        //적이 아군에게 주는 피해량
    private int playerDamage;       //아군이 적에게 주는 피해량
    private int _playerDamage;       //아군이 적에게 주는 피해량
    public Image Player_Hpbar;      //아군캐릭터 HP바 동기화Boss_HPMax
    public Image Enemy_HPbar;       //적군캐릭터 Hp바 동기화
    public Image Skiil_Bar;         //스킬게이지 동기화
    private float Player_HPMax;     //아군캐릭터 Hp바 백분율 처리용 변수
    private float Enemy_HPMax;      //적군캐릭터 Hp바 백분율 처리용 변수
    private float Boss_HPMax;
    float time = -3.0f;                 //프레임별 딜레이용 time 변수
    private bool OrderAttack = true;      //true : 아군공격차례, false : 적 공격차례   
    private float skill;
    public GameObject SkillIcon;
    private bool SkillAttack = false;       //스킬공격여부
    public Camera MainCamera;
    public Image BlackPanel;
    public Image Warning_Image;
    public Image MissionStartImage;
    public Image BackGround;
    public GameObject EnemyDamageText;
    public GameObject PlayerDamageText;
    public ParticleSystem Skilleffect_1;
    public ParticleSystem Skilleffect_2;
    public ParticleSystem Skuilleffect;
    public GameObject MissionFail;
    public GameObject MissionClear;
    public GameObject SaveData;
    private bool CameraRoundR = false;
    private bool CameraRoundL = false;
    private bool MobClear = false;
    public Image Battle_Cut_Back;
    public Image Battle_Cut_Face;
    public Image Battle_Cut_Front_1;
    public Image Battle_Cut_Front_2;
    public Image Battle_Cut_Emblem;
    public Image Battle_Cut_TextCase;
    public Text Battle_Cut_Text;
    public bool _SkillAttack = false;
    private bool BossUI = false;
    private bool _GameOver = false;
    private bool GameOverTrigger = true;

    // public GameObject boss;

    void Start()
    {
        ForBattle_FMod.instance.BattleReady();       //전투 시작 사운드
        time = -4;

        Color color = new Color(1f, 1f, 1f, 1f);
        player.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        color = new Color(0f, 0f, 0f, 0f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);

        if (player.GetComponent<MobydickScript>().Agility > enemy.GetComponent<Enemy_Silme>().Agility)
            OrderAttack = true;
        else
            OrderAttack = false;


        MoveCloud.transform.DOLocalMoveX(2000, 100.0f);                      //구름이동
        Skuilleffect.Stop();
        Skilleffect_1.Stop();                                                  //스킬이펙트 정지
        Skilleffect_2.Stop();
        //EnemyReset();                                                       //적 위치 및 
        enemyDamage = enemy.GetComponent<Enemy_Silme>().Power - player.GetComponent<MobydickScript>().Defense;            //적  공격대미지
        _enemyDamage = Boss.GetComponent<MantiScript>().Power - player.GetComponent<MobydickScript>().Defense;
        playerDamage = player.GetComponent<MobydickScript>().Power - enemy.GetComponent<Enemy_Silme>().Defense;           //플레이어 공격대미지
        _playerDamage = player.GetComponent<MobydickScript>().Power - Boss.GetComponent<MantiScript>().Defense;
        Player_HPMax = player.GetComponent<MobydickScript>().HP;
        Debug.Log(Player_HPMax);
        Enemy_HPMax = enemy.GetComponent<Enemy_Silme>().HP;
        Boss_HPMax = Boss.GetComponent<MantiScript>().HP;
        renderer = enemy.GetComponent<MeshRenderer>();
        _block = new MaterialPropertyBlock();
        renderer.SetPropertyBlock(_block);
        int id = Shader.PropertyToID("_Block");
        _block.SetColor(id, new Color(100, 100, 100, 0));

        Invoke("PanelFade", 2.5f);
        Invoke("MoveBackGround_Mob", 3.0f);
        Invoke("MovePlayer_Mob", 3.8f);
        Invoke("EnemyFadeIn", 5.0f); //그리고 1초뒤에 적 모브 페이드 인
        Invoke("Characterstartmove", 6.0f);
    }
    void PanelFade()
    {
        Debug.Log("판넬 페이드");
        BlackPanel.DOFade(0, 2.0f);  //검은색 패널 2초동안 페이드 아웃
        MissionStartImage.DOFade(0, 2.0f);  //검은색 패널 2초동안 페이드 아웃
    }
    void MovePlayer_Mob()     //잡몹 스테이지 시작시 플레이어 활성화,이동모션 및 이동
    {
        player.SetActive(true);
        player.GetComponent<MobydickScript>().walk();
        player.transform.DOLocalMoveX(-330, 1);             //#001
    }
    void MovePlayer_Boss()  //보스 스테이지 시작시 플레이어 이동모션 및 이동
    {
        player.GetComponent<MobydickScript>().walk();
    }
    void MoveBackGround_Mob() //잡몹 스테이지 시작시 뒷배경 이동
    {
        BackGround.transform.DOLocalMoveX(1270, 1);
    }
    void MoveBackGround_Boss() //보스 스테이지 시작시 뒷배경 이동
    {
        BackGround.transform.DOLocalMoveX(-940, 1);
    }
    void Characterstartmove_Boss()  //체크 1번
    {
        Debug.Log("사용여부 체크 1번");
        player.GetComponent<MobydickScript>().walk_3();
    }
    void EnemyFadeIn() //적 캐릭터 페이드인 
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        enemy.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        enemy.GetComponent<Renderer>().sharedMaterials[1].DOColor(color, "_Color", 1);
    }

    void EnemyReset()  //적 캐릭터(잡몹, 보스 페이드 아웃)
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        enemy.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
        //enemy.GetComponent<Renderer>().sharedMaterials[1].DOColor(color, "_Color", 0.2f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }


    void Update()
    {
        if (MobClear == false && _GameOver == false)  //잡몹 전투
        {

            Player_Hpbar.fillAmount = player.GetComponent<MobydickScript>().HP / Player_HPMax;
            Enemy_HPbar.fillAmount = enemy.GetComponent<Enemy_Silme>().HP / Enemy_HPMax;
            Skiil_Bar.fillAmount = skill;

            if (CameraRoundR == true)
            {
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 10), 0.5f);
                MainCamera.transform.DOLocalMoveZ(60, 0.5f);
                MainCamera.transform.DOLocalMoveZ(-13.3f, 0.5f);
                MainCamera.transform.DOLocalMoveX(70, 0.5f);
                MainCamera.transform.DOLocalMoveX(-0.8f, 0.5f);
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            }

            if (CameraRoundL == true)
            {
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, -10), 0.5f);
                MainCamera.transform.DOLocalMoveZ(60, 0.5f);
                MainCamera.transform.DOLocalMoveZ(-13.3f, 0.5f);
                MainCamera.transform.DOLocalMoveX(-70, 0.5f);
                MainCamera.transform.DOLocalMoveX(-0.8f, 0.5f);
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            }

            if (time < 2.0f)
            {
                time += Time.deltaTime;
            }
            else
            {
                if (skill == 1.0f) //스킬게이지 체크 1.0 == 스킬충전완료
                {
                    ForBattle_FMod.instance.SkillReady();
                    SkillIcon.SetActive(true);      //스킬 충전완료시 활성화
                }
                else
                {
                    SkillIcon.SetActive(false);     //미충전시 비활성화
                }

                if (OrderAttack == true)
                {

                    if (SkillAttack == true)
                    {

                        time = -7.0f;
                        Debug.Log("페이드인");
                        Battle_Cut_Back.DOFade(0.7f, 2.0f);

                        ForBattle_FMod.instance.BattleCutScene();  //스킬 사용시 나오는 컷신

                        Invoke("_Battle_Cut_Front", 3.0f);
                        Invoke("_Battle_Cut_Face", 3.0f);
                        Invoke("_Battle_Cut_Text", 3.0f);
                        Invoke("_Battle_Cut_Emblem", 3.2f);

                        Invoke("SkiilAttack_Mob", 4.0f);
                        Invoke("ResetDamageText", 5.5f);
                        SkillAttack = false;
                    }
                    else
                    {
                        Invoke("PlayerAttack_Mob", 0.3f);
                        Invoke("CameraR", 0.1f);
                        Invoke("ResetDamageText", 0.7f);

                    }
                    OrderAttack = false;
                    skill = skill + 0.25f; //스킬게이지추가
                }

                else if (OrderAttack == false)
                {
                    EnemyAttack_Mob();
                    Invoke("CameraL", 0.3f);
                    Invoke("ResetDamageText", 1.0f);
                    OrderAttack = true;
                    skill = skill + 0.25f; //스킬게이지추가
                }
                time = 0;
            }


        }

        else if (MobClear == true && _GameOver == false)        //보스 전투
        {
            if (BossUI == true)  //보스 체력바 이름 표시
            {
                Player_Hpbar.fillAmount = player.GetComponent<MobydickScript>().HP / Player_HPMax;
                Enemy_HPbar.fillAmount = Boss.GetComponent<MantiScript>().HP / Boss_HPMax;
                Skiil_Bar.fillAmount = skill;
            }


            if (CameraRoundR == true)
            {
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 10), 0.5f);
                MainCamera.transform.DOLocalMoveZ(60, 0.5f);
                MainCamera.transform.DOLocalMoveZ(-13.3f, 0.5f);
                MainCamera.transform.DOLocalMoveX(70, 0.5f);
                MainCamera.transform.DOLocalMoveX(-0.8f, 0.5f);
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            }

            if (CameraRoundL == true)
            {
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, -10), 0.5f);
                MainCamera.transform.DOLocalMoveZ(60, 0.5f);
                MainCamera.transform.DOLocalMoveZ(-13.3f, 0.5f);
                MainCamera.transform.DOLocalMoveX(-70, 0.5f);
                MainCamera.transform.DOLocalMoveX(-0.8f, 0.5f);
                MainCamera.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            }

            if (time < 2.0f)
            {
                time += Time.deltaTime;
            }
            else
            {
                if (skill == 1.0f) //스킬게이지 체크 1.0 == 스킬충전완료
                {
                    ForBattle_FMod.instance.SkillReady();       //스킬 준비 완료 사운드
                    SkillIcon.SetActive(true);      //스킬 충전완료시 활성화
                }
                else
                {
                    SkillIcon.SetActive(false);     //미충전시 비활성화
                }

                if (OrderAttack == true)
                {

                    if (SkillAttack == true)
                    {
                        _SkillAttack = true;
                        SkillAttack = false;
                    }
                    else
                    {
                        PlayerAttack_Boss();
                        CameraRoundR = true;
                        Invoke("ResetDamageText", 0.7f);

                    }
                    OrderAttack = false;
                    skill = skill + 0.25f; //스킬게이지추가
                }

                else if (OrderAttack == false)
                {
                    EnemyAttack_Boss();
                    CameraRoundL = true;
                    Invoke("ResetDamageText", 1.0f);
                    OrderAttack = true;
                    skill = skill + 0.25f; //스킬게이지추가
                }
                time = 0;
            }
        }

        if (_SkillAttack == true)
        {
            time = -6.5f;
            ForBattle_FMod.instance.BattleCutScene();  //스킬 사용시 나오는 컷신
            Debug.Log("보스 공격 스킬 이펙트 ");
            Boss.SetActive(false);
            player.SetActive(false);
            Battle_Cut_Back.DOFade(0.7f, 1.0f);
            Invoke("_Battle_Cut_Front", 1.0f);
            Invoke("_Battle_Cut_Face", 2.0f);
            Invoke("_Battle_Cut_Text", 2.5f);
            Invoke("_Battle_Cut_Emblem", 2.3f);
            Invoke("_Battle_Cut_Reset", 3.5f);
            Invoke("SkiilAttack_Boss", 4.0f);
            Invoke("ResetDamageText", 5.5f);
            _SkillAttack = false;

        }


        if (skill >= 1)
        {
            SkillIcon.SetActive(true);
        }


        if (enemy.GetComponent<Enemy_Silme>().HP <= 0 && MobClear == false)  //적 사망
        {
            MobClear = true;

            OrderAttack = true;


            Invoke("EnemyReset", 0.6f);
            Invoke("skeletonMark", 0.6f);
            Invoke("FadeInMoveBoss", 2.0f);
            Invoke("FadeOutMoveBoss", 5.0f);
            Invoke("BossStageResetPosition", 5.0f);
            Invoke("MoveBackGround_Boss", 7.0f);
            Invoke("MovePlayer_Mob", 7.5f);
            Invoke("BossFadeIn", 8.0f);

            time = -8.0f; //재 전투까지 총 소요시간 -5초 ~ 2초 = 7초간 딜레이 
        }




        if (player.GetComponent<MobydickScript>().HP <= 0) //아군 캐릭터 사망Characterstartmove_Boss
        {
            Invoke("OverSound", 2.0f);
            Invoke("GameOver", 2.0f);
        }

    }

    void OverSound()
    {
        if (GameOverTrigger == true)
        {
            ForBattle_FMod.instance.BattleFailed();  //전투 실패
            GameOverTrigger = false;
        }
    }

    void CharactorFadeOut()
    {
        Debug.Log("사용여부 체크 2");
        BossFadeIn();
    }
    void CameraR()  //카메라 회전R
    {
        Debug.Log("사용여부 체크 3");
        CameraRoundR = true;
    }
    void CameraL() //카메라 회전L
    {
        Debug.Log("사용여부 체크 3");
        CameraRoundL = true;
    }
    void BossFadeIn() //보스 페이드인 UI 변경
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        Boss.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
        BossUI = true;
        Mob_Name_Bar.SetActive(false);
        Boss_Name_Bar.SetActive(true);
    }

    void BossStageResetPosition() //보스스테이지 위치값 리셋   위치값 변경위치#1
    {
        BackGround.transform.DOLocalMoveX(-700, 0.5f);
        player.transform.DOLocalMoveX(-1266, 0.5f);
    }
    void FadeInMoveBoss()    //보스스테이지 경고 화면 연출 
    {
        Debug.Log("보스 페이드 검정화면");
        BlackPanel.DOFade(1, 1.0f); //검정화면화
        player.SetActive(false);
        Invoke("WarningFadeIn", 0);
        Invoke("WarningFadeOut", 0.75f);
        Invoke("WarningFadeIn", 1.5f);
        Invoke("WarningFadeOut", 2.25f);
    }
    void WarningFadeIn()  //워닝 페이드인
    {
        Warning_Image.DOFade(1, 0.75f);
    }
    void WarningFadeOut() //워닝 페이드 아웃
    {
        Warning_Image.DOFade(0, 0.75f);
    }

    void FadeOutMoveBoss()   //보스 페이드 아웃
    {
        BlackPanel.DOFade(0, 3.0f);   //투명화
        //Warning_Image.DOFade(0, 2.0f);
    }

    void StageClear()  //스테이지 승리 연출
    {
        player.transform.DOLocalMoveX(-750, 0.5f);
        ResetDamageText();
        time = 0;
        enemy.SetActive(false);
        Invoke("Clearsave", 5f);
        Invoke("ClearMotion", 1);
    }

    void ClearMotion() //스테이지 클리어 모션연출      위치값 변경 위치#2
    {
        Debug.Log("클리어모션");
        UICanvas.SetActive(false);
        player.transform.DOLocalMoveX(-620, 0.8f);
        MainCamera.transform.DOLocalMoveX(-75, 0.8f); //#003
        MainCamera.transform.DOLocalMoveZ(15, 0.8f);
        player.GetComponent<MobydickScript>().wait_2();
        ForBattle_FMod.instance.BattleEndGood();  //미션 클리어 사운드
        Invoke("_MissionClear", 2);
    }
    void _MissionClear()   //미션 클리어 화면 활성화
    {
        Debug.Log("미션클리어");
        MissionClear.SetActive(true);
    }

    void Clearsave()   //클리어후 세이브 데이터 입력 스테이지 클리어 체크 변경 #3
    {
        SaveData.GetComponent<SaveDataManager>()._ResearchPoint = SaveData.GetComponent<SaveDataManager>()._ResearchPoint + 3; //클리어 보상 +3
        SaveData.GetComponent<SaveDataManager>()._Gene_Between2 = false; //이녀석이 스토리 재생 후 전투창으로 이어주는 역할이라 사용후 꺼줘야함.
        SaveData.GetComponent<SaveDataManager>()._Stage2_2= true;
        SaveData.GetComponent<SaveDataManager>().Save();
        SceneManager.LoadScene("2_2_After");
    }

    void failsave()     //미션 실패 인게임으로 이동
    {
        SceneManager.LoadScene("inGameScene");
    }

    void GameOver()  //게임 패배 연출
    {
        if (time < 1.0f)
        {

            time += Time.deltaTime;
        }
        else
        {
            Color color = new Color(0f, 0f, 0f, 0f);
            player.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 1);
            time = 0;
            player.SetActive(false);
            Invoke("failsave", 5f);
            ResetDamageText();

        }
        time += Time.deltaTime;
        MissionFail.SetActive(true);
    }

    void PlayerAttack_Mob()
    {
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        //player.transform.DOLocalMoveX(310, 0.3f).SetEase(Ease.OutBack); //이동 속도 관련 //공격이동 0.3    //플레이어 공격이동  ##002
       //player.transform.DOLocalMoveY(105, 0.3f).SetEase(Ease.OutBack); //이동 속도 관련 //공격이동 0.3   //플레이어 공격이동  
        player.GetComponent<MobydickScript>().attack();
        enemy.GetComponent<Enemy_Silme>().damage(); //피격모션

        enemy_blood_1.SetActive(true);
        player_blood_1.SetActive(false);
        Skilleffect_2.Play();

        ForBattle_FMod.instance.Normal_Attack_modibic();        //모니비우스 공걱 사운드

        Invoke("Mob_Blood_1_Fadein", 0.1f);
        Invoke("Mob_Blood_2_Fadein", 0.2f);
        Invoke("Mob_Blood_1_FadeOut", 0.6f);
        Invoke("Mob_Blood_2_FadeOut", 0.8f);
        Invoke("_camera", 0.2f);
        Invoke("BloodReset", 1f);
        enemy.transform.DOLocalMoveX(705, 0.8f);    //적 피격 위치값 이동 #7
        enemy.GetComponent<Enemy_Silme>().HP = enemy.GetComponent<Enemy_Silme>().HP - playerDamage; //공격시 대미지 계산 후 적군 캐릭터 HP 감소
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);
        Invoke("resetposition", 1.0f); // 1.0초 뒤에 원위치 진행    
        Invoke("CameraReset", 1f);
    }

    void BloodReset()   //피 위치 리셋 #8
    {
        enemy_blood_1.transform.localPosition = new Vector3(1f, 4.3f, 0.1f);  //피 리셋 위치
    }
    void Mob_Blood_1_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        enemy_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);

    }
    void Boss_Blood_1_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        Boss_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Boss_Blood_1_FadeOut()
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        Boss_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Mob_Blood_1_FadeOut()
    {
        Debug.Log("적 피 페이드아웃");
        Color color = new Color(0f, 0f, 0f, 0f);
        enemy_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Player_Blood_1_Fadein()
    {
        Color color = new Color(1f, 1f, 1f, 1f);
        player_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }
    void Player_Blood_1_FadeOut()
    {
        Color color = new Color(0f, 0f, 0f, 0f);
        player_blood_1.GetComponent<Renderer>().sharedMaterials[0].DOColor(color, "_Color", 0.2f);
    }

    void PlayerAttack_Boss()
    {
        Boss_blood_1.SetActive(true);
        player_blood_1.SetActive(false);
        enemy_blood_1.SetActive(false);
        PlayerDamageText.GetComponent<DamageScript>().Reset();
        player.GetComponent<MobydickScript>().attack();
        //player.transform.DOLocalMoveX(310, 0.3f).SetEase(Ease.OutBack); //이동 속도 관련 //공격이동 0.3    #002
        //player.transform.DOLocalMoveY(105, 0.3f).SetEase(Ease.OutBack); //이동 속도 관련 //공격이동 0.3   #9
        Boss.GetComponent<MantiScript>().damage(); //피격모션
        Boss.GetComponent<MantiScript>().HP = Boss.GetComponent<MantiScript>().HP - _playerDamage; //공격시 대미지 계산 후 적군 캐릭터 HP 감소
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 4);

        ForBattle_FMod.instance.Normal_Attack_modibic();        //모니비우스 공걱 사운드

        Skilleffect_2.Play();
        Invoke("Boss_Blood_1_Fadein", 0.1f);
        Invoke("Boss_Blood_1_FadeOut", 0.6f);
        Invoke("_camera", 0.2f);
        Invoke("BloodReset", 1f);
        Boss.transform.DOLocalMoveX(1030, 0.8f);                 //#10
        //enemy.transform.DOLocalMoveX(705, 0.8f);                //#11
        Invoke("resetposition", 1.0f); // 1.0초 뒤에 원위치 진행    
        Invoke("CameraReset", 1f);

        if (Boss.GetComponent<MantiScript>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<MantiScript>().HP / Boss_HPMax;
            Invoke("EnemyReset", 0.6f);
            Invoke("skeletonMark", 0.6f);
            Invoke("StageClear", 2.0f);
            _GameOver = true;
        }
    }

    void resetposition() //#12 전체 위치값 초기화용
    {
        player.transform.DOLocalMoveX(-330, 0.5f).SetEase(Ease.OutQuad);    //#001
        player.transform.DOLocalMoveY(105, 0.5f).SetEase(Ease.OutQuad);
        enemy.transform.DOLocalMoveX(630, 0.5f).SetEase(Ease.OutQuad);
        Boss.transform.DOLocalMoveX(900, 0.5f).SetEase(Ease.OutQuad);       //#004
    }

    void _Battle_Cut_Front()
    {
        Debug.Log("앞배경");
        Battle_Cut_Front_1.transform.DOLocalMoveX(40.4f, 1f);
        Battle_Cut_Front_2.transform.DOLocalMoveX(40.4f, 1f);
    }
    void _Battle_Cut_Face()
    {
        Debug.Log("페이스");
        Battle_Cut_Face.transform.DOLocalMoveX(-47f, 1f);
        Battle_Cut_Emblem.transform.DOLocalMoveX(92.0f, 1f);
    }
    void _Battle_Cut_Reset()
    {
        Battle_Cut_Back.DOFade(0, 1.0f);
        Battle_Cut_Face.DOFade(0, 1.0f);
        Battle_Cut_Front_1.DOFade(0, 1.0f);
        Battle_Cut_Front_2.DOFade(0, 1.0f);
        Battle_Cut_Front_2.transform.DOLocalMoveX(40.3f, 1f);
        Battle_Cut_Emblem.DOFade(0, 1.0f);
        Battle_Cut_Text.DOFade(0, 1.0f);
        Battle_Cut_TextCase.DOFade(0, 1.0f);
    }
    void _Battle_Cut_Text()
    {
        Debug.Log("텍스트");
        Battle_Cut_Text.DOFade(1, 1f);
        Battle_Cut_TextCase.DOFade(1, 1.0f);
        //Battle_Cut_Emblem.DOFade(1, 0.7f);
    }
    void _Battle_Cut_Emblem()
    {
        Battle_Cut_Emblem.DOFade(1, 1.0f);
    }

    void SkiilAttack_Boss()
    {
        Boss_blood_1.SetActive(true);
        player_blood_1.SetActive(false);
        Boss.SetActive(true);
        player.SetActive(true);
        player.GetComponent<MobydickScript>().skill();
        Skilleffect_1.Play();
        //player.transform.DOLocalMoveX(-170, 0.6f); //스킬공격 모션X
     
        //player.transform.DOLocalMoveY(90, 0.6f); //스킬공격 모션Y
        Boss.GetComponent<MantiScript>().HP = Boss.GetComponent<MantiScript>().HP - (_playerDamage * 2); //공격시 대미지 계산 후 적군 캐릭터 HP 감소
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // 스킬계수

        ForBattle_FMod.instance.SA_Modibic();        //모니비우스 스킬 공격 사운드


        //Invoke("SkillSecondMove", 0.6f);
        //Invoke("SkillSecondMotion", 1.0f);
        //Invoke("SkillSecondEffect", 1.2f);
        Invoke("Boss_Blood_1_Fadein", 1.2f);
        Invoke("Boss_Blood_1_FadeOut", 1.7f);
        Invoke("_camera", 1.2f);
        Invoke("damegeBossSkill", 1.2f);
        Invoke("CameraReset", 1f);
        Invoke("SkilleffectOut", 2.0f);
        Boss.transform.DOLocalMoveX(1030, 0.8f);
        _SkillAttack = false;
        if (Boss.GetComponent<MantiScript>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<MantiScript>().HP / Boss_HPMax;
            Invoke("EnemyReset", 3.6f);
            Invoke("skeletonMark", 3.6f);
            Invoke("CameraReset_Boss", 3.6f);
            Invoke("StageClear", 5.0f);
            _GameOver = true;
        }
    }

    void SkillSecondMove()
    {
        player.transform.DOLocalMoveX(60, 0.3f); //스킬공격 모션X
        player.transform.DOLocalMoveY(105, 0.3f); //스킬공격 모션Y
    }
    void SkillSecondMotion()
    {
        Debug.Log("스킬2번 사용");
        player.GetComponent<MobydickScript>().skill();
    }
    void SkillSecondEffect()
    {
        Skilleffect_2.Play();
    }

    void damegeBossSkill() //보스 스킬연출
    {
        MainCamera.transform.DOLocalMoveX(24, 0.8f);
        MainCamera.transform.DOLocalMoveZ(11, 0.8f);
        Boss.transform.DOLocalMoveX(1100, 0.8f);
        enemy.transform.DOLocalMoveX(705, 0.8f);
        Boss.GetComponent<MantiScript>().damage();
        PlayerDamageText.GetComponent<DamageScript>().damage(1, 0); // 스킬계수
        ForBattle_FMod.instance.normalHitEffect();  // 스킬로 인한 힛 사운드
        Invoke("CameraReset_Boss", 1f);
    }
    void CameraReset_Boss() //보스 스테이지 카메라 리셋
    {
        Boss.transform.DOLocalMoveX(900, 0.8f);  //##004
        MainCamera.transform.DOLocalMoveX(-0.8f, 0.8f);
        MainCamera.transform.DOLocalMoveZ(-13.3f, 0.8f);
    }
    void SkilleffectOut() //스킬이펙트 종료
    {
        Skilleffect_1.Stop();
        Skilleffect_2.Stop();
        resetposition();
        player.GetComponent<MobydickScript>().ResetWait_1();
    }
    void EnemyAttack_Mob()  //#14
    {
        enemy_blood_1.SetActive(false);
        player_blood_1.SetActive(true);

        enemy.GetComponent<Enemy_Silme>().attack();
        enemy.transform.DOLocalMoveX(-250, 0.3f).SetEase(Ease.OutBack); //이동 속도 관련 //공격이동 0.3  
        Invoke("_camera", 0.2f);
        player.GetComponent<MobydickScript>().damage();
        player.GetComponent<MobydickScript>().HP = player.GetComponent<MobydickScript>().HP - enemyDamage; //피격시 대미지 계산후 아군 캐릭터 HP 감소
        player.transform.DOLocalMoveX(-735, 0.8f);

        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 1);

        ForBattle_FMod.instance.normalHitEffect();  //레벨1공격

        Debug.Log("Mob공격 ");
        Invoke("Player_Blood_1_Fadein", 0.1f);
        Invoke("Player_Blood_2_Fadein", 0.2f);
        Invoke("Player_Blood_1_FadeOut", 0.6f);
        Invoke("Player_Blood_2_FadeOut", 0.8f);
        Invoke("damegetest", 1.1f);
        Invoke("resetposition", 1.0f); // 1.0초 뒤에 원위치 진행    
        Invoke("CameraReset", 1f);
    }
    void EnemyAttack_Boss()
    {

        Boss_blood_1.SetActive(false);
        player_blood_1.SetActive(true);
        enemy_blood_1.SetActive(false);

        Skilleffect_1.Stop();
        Skilleffect_2.Stop();

        Boss.GetComponent<MantiScript>().attack();
        Boss.transform.DOLocalMoveX(90, 0.3f).SetEase(Ease.OutBack); //이동 속도 관련 //공격이동 0.3
        Invoke("_camera", 0.2f);
        player.GetComponent<MobydickScript>().damage();
        player.GetComponent<MobydickScript>().HP = player.GetComponent<MobydickScript>().HP - _enemyDamage; //피격시 대미지 계산후 아군 캐릭터 HP 감소
        player.transform.DOLocalMoveX(-735, 0.8f);


        EnemyDamageText.GetComponent<DamageScript>().damage(0, enemyDamage);
        PlayerDamageText.GetComponent<DamageScript>().damage(0, 1);

        ForBattle_FMod.instance.Nattack_Lev_2();  //보스 멘티코어 레벨 2 공격 사운드

        Invoke("Player_Blood_1_Fadein", 0.1f);
        Invoke("Player_Blood_2_Fadein", 0.2f);
        Invoke("Player_Blood_1_FadeOut", 0.6f);
        Invoke("Player_Blood_2_FadeOut", 0.8f);
        Invoke("damegetest", 1.1f);
        Invoke("resetposition", 1.0f); // 1.0초 뒤에 원위치 진행    
        Invoke("CameraReset", 1f);

        if (Boss.GetComponent<MantiScript>().HP <= 0)
        {
            Enemy_HPbar.fillAmount = Boss.GetComponent<MantiScript>().HP / Boss_HPMax;
            Invoke("EnemyReset", 0.6f);
            Invoke("skeletonMark", 0.6f);
            Invoke("StageClear", 2.0f);
        }
    }
    public void skeletonMark()
    {
        Debug.Log("해골이펙트 플레이");
        Skuilleffect.Play();
    }

    public void _camera()
    {
        MainCamera.GetComponent<CameraShake>().AttackCameraShake(0.5f, 3);
    }
    public void usedSkill()
    {
        ForBattle_FMod.instance.SkillTurnON();      //스킬 아이콘 클릭
        Debug.Log("usedSkill");
        skill = 0f;
        SkillAttack = true;
        SkillIcon.SetActive(false);
    }
    void CameraReset()
    {
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
        Skilleffect_1.gameObject.SetActive(false);
        Skilleffect_2.gameObject.SetActive(false);
    }


}
