using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class MantiScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int grade;
    public int HP;
    public int Power;
    public int Defense;
    public int Agility;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void attack()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "attack_2", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 1.0f);
    }

    public void damage()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "damage", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 1.0f);
    }

    public void skill()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "skill_2", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 2f);
    }

    public void wait_2()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "wait_2", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 2f);
    }

    public void walk()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "walk_1", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 1f);
    }
    public void walk_2()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "walk_2", true);
        Invoke("ResetWait_1", 0.5f);
    }
    public void walk_3()
    {
        Debug.Log("걷기3번");
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "walk_2", true);
    }

    public void ResetWait_1()
    {
        Debug.Log("리셋웨이트");
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "wait_1", true);
    }
}

