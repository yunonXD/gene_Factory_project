using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Editor : MonoBehaviour{

    public void SceneChange_inGame(){

        SceneManager.LoadScene("inGameScene");
    }

    public void SceneChange_gene(){
        SceneManager.LoadScene("geneMap");
    }

    public void SceneChange_BattleSelect(){
        SceneManager.LoadScene("BattleSelectScene");
    }


    public void OnApplicationQuit(){
        Debug.Log("ÇØÄ¡¿ü³ª?");
    }

}
