using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class NewSaveDataManager : MonoBehaviour
{

    public void newGame()
    {
        Data data = new Data();

        data.name = "이선동";
        data.stage1_1 = false;
        data.stage1_2 = false;
        data.gryphon = false;
        data.point = 10;

     

        File.WriteAllText(Application.dataPath + "/SaveData.json", JsonUtility.ToJson(data));
        Debug.Log("세이브 데이터 생성");
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
