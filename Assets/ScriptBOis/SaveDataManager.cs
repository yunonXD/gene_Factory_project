using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


[System.Serializable]
public class Data
{
    public string Name;
    public bool Stage1_1;
    public bool Stage1_2;
    public bool Stage1_3;
    public bool Stage1_4;
    public bool Stage2_1;
    public bool Stage2_2;
    public bool Stage2_3;
    public bool Stage2_4;
    public bool Creature_Mush;
    public bool Creature_ConRabbit;
    public bool Creature_Fran;
    public bool Creature_Nymph;
    public bool Creature_Manticore;
    public bool Creature_Temp_1;
    public bool Creature_Mobidic;
    public bool Creature_TangGreece;
    public bool Creature_Temp_2;
    public int ResearchPoint;

}



public class SaveDataManager : MonoBehaviour
{
    public string _Name;
    public bool _Stage1_1;
    public bool _Stage1_2;
    public bool _Stage1_3;
    public bool _Stage1_4;
    public bool _Stage2_1;
    public bool _Stage2_2;
    public bool _Stage2_3;
    public bool _Stage2_4;
    public bool _Creature_Mush;
    public bool _Creature_ConRabbit;
    public bool _Creature_Fran;
    public bool _Creature_Nymph;
    public bool _Creature_Manticore;
    public bool _Creature_Temp_1;
    public bool _Creature_Mobidic;
    public bool _Creature_TangGreece;
    public bool _Creature_Temp_2;
    public int _ResearchPoint;

    void Start()
    {
        string str2 = File.ReadAllText(Application.dataPath + "/SaveData.json");
        Data playerData = JsonUtility.FromJson<Data>(str2);
        Debug.Log("세이브 데이터 로드");
        _Name = playerData.Name;
        _Stage1_1 = playerData.Stage1_1;
        _Stage1_2 = playerData.Stage1_2;
        _Stage1_3 = playerData.Stage1_3;
        _Stage1_4 = playerData.Stage1_4;
        _Stage2_1 = playerData.Stage2_1;
        _Stage2_2 = playerData.Stage2_2;
        _Stage2_3 = playerData.Stage2_3;
        _Stage2_4 = playerData.Stage2_4;
        _Creature_Mush = playerData.Creature_Mush;
        _Creature_ConRabbit = playerData.Creature_ConRabbit;
        _Creature_Fran = playerData.Creature_Fran;
        _Creature_Nymph = playerData.Creature_Nymph;
        _Creature_Manticore = playerData.Creature_Manticore;
        _Creature_Temp_1 = playerData.Creature_Temp_1;
        _Creature_Mobidic = playerData.Creature_Mobidic;
        _Creature_TangGreece = playerData.Creature_TangGreece;
        _Creature_Temp_2 = playerData.Creature_Temp_2;
        _ResearchPoint = playerData.ResearchPoint;

}

    public void Save()
    {
        Debug.Log("데이터 세이브 하였습니다.");
        Data savedata = new Data();
        savedata.Name = _Name;
        savedata.Stage1_1 = _Stage1_1;
        savedata.Stage1_2 = _Stage1_2;
        savedata.Stage1_3 = _Stage1_3;
        savedata.Stage1_4 = _Stage1_4;
        savedata.Stage2_1 = _Stage2_1;
        savedata.Stage2_2 = _Stage2_2;
        savedata.Stage2_3 = _Stage2_3;
        savedata.Stage2_4 = _Stage2_4;
        savedata.Creature_Mush = _Creature_Mush;
        savedata.Creature_ConRabbit = _Creature_ConRabbit;
        savedata.Creature_Fran = _Creature_Fran;
        savedata.Creature_Nymph = _Creature_Nymph;
        savedata.Creature_Manticore = _Creature_Manticore;
        savedata.Creature_Temp_1 = _Creature_Temp_1;
        savedata.Creature_Mobidic = _Creature_Mobidic;
        savedata.Creature_TangGreece = _Creature_TangGreece;
        savedata.Creature_Temp_2 = _Creature_Temp_2;
        savedata.ResearchPoint = _ResearchPoint;

        File.WriteAllText(Application.dataPath + "/SaveData.json", JsonUtility.ToJson(savedata));
    }

    public void StageClear1_2()
    {
        
    }
}
     





