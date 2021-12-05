using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ForBattle_FMod : MonoBehaviour
{
    public static ForBattle_FMod instance;

    [SerializeField]
    [EventRef]
    public string Normal_Attack_Hit_Effect = null;

    [SerializeField]
    [EventRef]
    public string Normal_Attack_Level_1 = null;

    [SerializeField]
    [EventRef]
    public string Normal_Attack_Level_2 = null;

    [SerializeField]
    [EventRef]
    public string Normal_Attack_Level_3_modibic = null;

    [SerializeField]
    [EventRef]
    public string Normal_Attack_Level_4_tangri = null;

    [SerializeField]
    [EventRef]
    public string Skill_Attack_ConRabbit = null;

    [SerializeField]
    [EventRef]
    public string Skill_Attack_Mush = null;


    [SerializeField]
    [EventRef]
    public string Skill_Attack_Fran = null;

    [SerializeField]
    [EventRef]
    public string Skill_Attack_Nymph = null;

    [SerializeField]
    [EventRef]
    public string Skill_Attack_Manticore = null;

    [SerializeField]
    [EventRef]
    public string Skill_Attack_Modibic = null;

    [SerializeField]
    [EventRef]
    public string Skill_Attack_TangGreece = null;

    [SerializeField]
    [EventRef]
    public string Batte_Failed = null;

    [SerializeField]
    [EventRef]
    public string Battle_Ready = null;

    [SerializeField]
    [EventRef]
    public string Battle_Skill_CutScene = null;

    [SerializeField]
    [EventRef]
    public string Skill_Turn_Ready = null;

    [SerializeField]
    [EventRef]
    public string Skill_TurnON = null;


    //FMOD.Studio.EventInstance MUClick = RuntimeManager.CreateInstance(Map_Unkown_Click);
    //MUClick.start();
    //MUClick.release();

    private void Awake()
    {
        instance = this;
    }


    //ForBattle_FMod.instance.normalHitEffect();  //레벨1공격
    public void normalHitEffect()
    {
        if (Normal_Attack_Hit_Effect != null)
        {

            RuntimeManager.PlayOneShot(Normal_Attack_Hit_Effect);
        }
    }

    public void Nattack_Lev_1()
    {
        if (Normal_Attack_Level_1 != null)
        {

            RuntimeManager.PlayOneShot(Normal_Attack_Level_1);
        }



    }
    public void Nattack_Lev_2()
    {
        if (Normal_Attack_Level_2 != null)
        {

            RuntimeManager.PlayOneShot(Normal_Attack_Level_2);
        }



    }

    public void Normal_Attack_modibic()
    {
        if (Normal_Attack_Level_3_modibic != null)
        {
            RuntimeManager.PlayOneShot(Normal_Attack_Level_3_modibic);
        }

    }

    public void Normal_Attack_tangri()
    {
        if(Normal_Attack_Level_4_tangri != null)
        {

            RuntimeManager.PlayOneShot(Normal_Attack_Level_4_tangri);
        }
    }



    public void SA_ConRabbit()
    {
        if (Skill_Attack_ConRabbit != null)
        {
            RuntimeManager.PlayOneShot(Skill_Attack_ConRabbit);
        }

    }

    public void SA_Mush()
    {
        if (Skill_Attack_Mush != null)
        {

            RuntimeManager.PlayOneShot(Skill_Attack_Mush);
        }

    }

    public void SA_Fran()
    {
        if (Skill_Attack_Fran != null)
        {

            RuntimeManager.PlayOneShot(Skill_Attack_Fran);
        }

    }

    public void SA_Nymph()
    {
        if (Skill_Attack_Nymph != null)
        {

            RuntimeManager.PlayOneShot(Skill_Attack_Nymph);
        }

    }

    public void SA_Manticore()
    {
        if (Skill_Attack_Manticore != null)
        {


            RuntimeManager.PlayOneShot(Skill_Attack_Manticore);
        }

    }

    public void SA_Modibic()
    {
        if (Skill_Attack_Modibic != null)
        {

            RuntimeManager.PlayOneShot(Skill_Attack_Modibic);
            

        }
    }
    public void SA_TangGreece()
    {
        if (Skill_Attack_TangGreece != null)
        {

            RuntimeManager.PlayOneShot(Skill_Attack_TangGreece);


        }
    }

    public void BattleFailed()      //전투 실패
    {
        if (Batte_Failed != null)
        {

            RuntimeManager.PlayOneShot(Batte_Failed);

        }
    }

    public void BattleReady()       //전투 시작
    {
        if (Battle_Ready != null)
        {

            RuntimeManager.PlayOneShot(Battle_Ready);

        }
    }
    
    public void BattleCutScene()        //스킬 사용시 나오는 컷신
    {
        if (Battle_Skill_CutScene != null)
        {

            RuntimeManager.PlayOneShot(Battle_Skill_CutScene);

        }
    }
    public void SkillReady()       //스킬 준비 완료
    {
        if (Skill_Turn_Ready != null)
        {

            RuntimeManager.PlayOneShot(Skill_Turn_Ready);

        }
    }

    public void SkillTurnON()       //스킬 아이콘 클릭
    {
        if (Skill_TurnON != null)
        {

            RuntimeManager.PlayOneShot(Skill_TurnON);

        }
    }


    public void StopMusic_all()
    {
        //BG_Main_Static.Stop();
    }


    private void Start()
    {
    }




}
