using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class Enemy_Silme : MonoBehaviour
{
    public int grade = 1;
    public int HP = 5;
    public int Power = 3;
    public int Defense = 2;
    public int Agility = 1;

    private MeshRenderer _renderer;
    private MaterialPropertyBlock _block;
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
        skeletonAnimation.AnimationState.AddAnimation(0, "wait", true, 1f);
    }

    public void damage()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "demage", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait", true, 1f);
    }


    public void wait()
    {
        var skeletonAnimation = GetComponent<SkeletonAnimation>();
        skeletonAnimation.AnimationState.SetAnimation(0, "wait", true);
        skeletonAnimation.AnimationState.AddAnimation(0, "wait", true, 1f);
    }

    public void FadeOut()
    {
        _renderer = GetComponent<MeshRenderer>();
        _block = new MaterialPropertyBlock();

        _renderer.SetPropertyBlock(_block);

        int id = Shader.PropertyToID("_Black");

        _block.SetColor(id, Color.red);
        _renderer.SetPropertyBlock(_block);
    }

}
