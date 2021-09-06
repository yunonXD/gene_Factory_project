using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MainScene_Button : MonoBehaviour
{

    public void SceneChange()
    {
        EditorSceneManager.LoadScene("inGameScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
