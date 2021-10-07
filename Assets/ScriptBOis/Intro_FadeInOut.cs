using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro_FadeInOut : MonoBehaviour{ 

    float timer = 0;

    void Update(){

    timer += Time.deltaTime;
        if (timer > 5){
            SceneManager.LoadScene("FirstScene");
        }
    }
}
