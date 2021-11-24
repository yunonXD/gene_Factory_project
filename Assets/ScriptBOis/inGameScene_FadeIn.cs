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
        FadeIn.gameObject.SetActive(true);              //1.4 �� ��� �� ���̵� �� ���

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("BattleSelectScene");    //���̵� ���� ���ÿ� �����ϴ� ���� 1.5 �� (������������ 0.1��) �Ŀ� �� ��ȯ
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
