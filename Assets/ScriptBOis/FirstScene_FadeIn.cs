using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class FirstScene_FadeIn : MonoBehaviour
{
    public GameObject CameraBoi;
    public GameObject FadeIn;


    public void Continue()
    {
        PlayFModUI.instance.NPanalClick();
        transform.DOLocalMoveZ(-900, 0.2f).SetEase(Ease.OutCubic);
        StartCoroutine("ContinueCor");
    }


    public void Quit()
    {
        PlayFModUI.instance.NPanalClick();
        transform.DOLocalMoveZ(-900, 0.2f).SetEase(Ease.OutCubic);
        StartCoroutine("QuitCor");
    }



    IEnumerator ContinueCor()
    {
        yield return new WaitForSeconds(0.5f);
        FadeIn.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("inGameScene");
    }


    IEnumerator QuitCor()
    {

        yield return new WaitForSeconds(0.5f);
        FadeIn.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Application.Quit();
    }

}
