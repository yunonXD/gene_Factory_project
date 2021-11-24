using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class inGameScene_FadeIn : MonoBehaviour
{
    public GameObject CameraBoi;
    public GameObject FadeIn;

    //private void FixedUpdate()
    //{
    //    Vector3 TargetPos = new Vector3(Target.transform.position.x, Target.transform.position.y, Target.transform.position.z);
    //    transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * 2f);
    //}

    public void BattleSelect()
    {
        PlayFModUI.instance.NPanalClick();
        transform.DOLocalMoveZ(-20, 2.0f).SetEase(Ease.OutCubic);
        transform.DOLocalMoveY(250, 1.5f).SetEase(Ease.InOutCubic);

        StartCoroutine("BattleSelectMoveCor");
    }

    public void GeneRecord()
    {
        PlayFModUI.instance.NPanalClick();
        transform.DOLocalMoveZ(-900, 0.2f).SetEase(Ease.OutCubic);
        //transform.DOLocalMoveX(-700, 1.0f).SetEase(Ease.OutCubic);
        StartCoroutine("GeneRecordMoveCor");
    }

    public void GeneSelect()
    {
        PlayFModUI.instance.NPanalClick();
        transform.DOLocalMoveZ(-900, 0.2f).SetEase(Ease.OutCubic);
        //transform.DOLocalMoveX(700, 1.0f).SetEase(Ease.OutCubic);
        StartCoroutine("GeneSelectMoveCor");
    }





    IEnumerator BattleSelectMoveCor()
    {
        yield return new WaitForSeconds(1.4f);
        FadeIn.gameObject.SetActive(true);              //1.4 초 대기 후 페이드 인 출력

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("BattleSelectScene");    //페이드 인이 동시에 진행하는 동안 1.5 초 (실질적적으로 0.1초) 후에 씬 전환
    }

    IEnumerator GeneRecordMoveCor()
    {

        yield return new WaitForSeconds(0.5f);
        FadeIn.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("RecordMemoryScene");
    }

    IEnumerator GeneSelectMoveCor()
    {

        yield return new WaitForSeconds(0.5f);
        FadeIn.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("geneMap");
    }





}
