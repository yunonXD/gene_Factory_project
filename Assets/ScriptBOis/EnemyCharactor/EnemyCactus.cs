using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;


public class EnemyCactus : MonoBehaviour
{

    public int grade = 0;
    public int HP = 8;
    public int Power = 3;
    public int Defense = 2;
    public int Agility = 1;


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
        skeletonAnimation.AnimationState.AddAnimation(0, "wait", true, 2f);
    }

    public void damage()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "demage", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait", true, 1f);
    }
}
