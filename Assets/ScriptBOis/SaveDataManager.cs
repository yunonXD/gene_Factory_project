using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


[System.Serializable]
public class Data
{
    public string name;
    public bool stage1_1;
    public bool stage1_2;
    public bool gryphon;
    public int point;

}



public class SaveDataManager : MonoBehaviour
{
    public string Name;
    public bool Stage1_1;
    public bool Stage1_2;
    public bool Gryphon;
    public int Point;

    void Start()
    {
        string str2 = File.ReadAllText(Application.dataPath + "/SaveData.json");
        Data playerData = JsonUtility.FromJson<Data>(str2);
        Debug.Log("세이브 데이터 로드");
        Name = playerData.name;
        Stage1_1 = playerData.stage1_1;
        Stage1_2 = playerData.stage1_2;
        Gryphon = playerData.gryphon;
        Point = playerData.point;

    }

    public void Save()
    {
        Debug.Log("데이터 세이브 하였습니다.");
        Data savedata = new Data();
        savedata.name = Name;
        savedata.stage1_1 = Stage1_1;
        savedata.stage1_2 = Stage1_2;
        savedata.gryphon = Gryphon;
        savedata.point = Point;
       
        File.WriteAllText(Application.dataPath + "/SaveData.json", JsonUtility.ToJson(savedata));
    }

    public void StageClear1_2()
    {
        Stage1_2 = true;
    }
}
     





