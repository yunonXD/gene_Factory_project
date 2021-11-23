using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class MushScript : MonoBehaviour
{
    public int grade = 1;
    public int HP = 26;
    public int Power = 6;
    public int Defense = 2;
    public int Agility = 3;

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
        skeletonAnimation.AnimationState.SetAnimation(0, "attack", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 1f);
    }

    public void damage()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "damage", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 1f);
    }

    public void skill()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "skil", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 1f);
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
        skeletonAnimation.AnimationState.SetAnimation(0, "walk", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait_1", true, 1f);
    }


}


