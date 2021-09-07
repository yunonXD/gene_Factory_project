using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;



public class FadeIn_Out : MonoBehaviour
{

    public string Scene;
    //public Image black;
    //public Animator anim;


    //override public void OnStateExit(Animator animaor, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    if(Scene.Length > 0)
    //    {
    //        SceneManager.LoadScene("mainScene");
    //    }
    //    else
    //    {
    //        SceneManager.LoadScene("IntroScene");
    //    }
    //}



    // Start is called before the first frame update
    void Start()
    {
        //Fading();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //IEnumerable Fading()
    //{
    //    anim.SetBool("Fade", true);
    //    yield return new WaitUntil(() => black.color.a == 1);
    //    SceneManager.LoadScene("IntroScene");
    //    //EditorSceneManager.LoadScene("IntroScene");
    //}


}
