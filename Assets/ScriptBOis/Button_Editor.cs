using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Editor : MonoBehaviour{

    public GameObject Optionpage;

    public void SceneChange_inGame(){

        SceneManager.LoadScene("inGameScene");
    }

    public void SceneChange_gene(){
        SceneManager.LoadScene("geneMap");
    }

    public void SceneChange_BattleSelect(){
        SceneManager.LoadScene("BattleSelectScene");
    }

    public void SceneChange_Title()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void OptionSetActive()
    {
        Optionpage.SetActive(false);
    }

    public void OnApplicationQuit(){
        Application.Quit();
        Debug.Log("ÇØÄ¡¿ü³ª?");
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Optionpage.SetActive(true);
        }
    }
}
