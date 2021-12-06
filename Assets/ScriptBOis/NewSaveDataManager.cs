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

        data.Name = "이선동";
        data.Stage1_1 = false;
        data.Stage1_2 = false;
        data.Stage1_3 = false;
        data.Stage1_4 = false;
        data.Stage2_1 = false;
        data.Stage2_2 = false;
        data.Stage2_3 = false;
        data.Stage2_4 = false;
        data.Creature_Mush = false;
        data.Creature_ConRabbit = false;
        data.Creature_Fran = false;
        data.Creature_Nymph = false;
        data.Creature_Manticore = false;
        data.Creature_Temp_1 = false;
        data.Creature_Mobidic = false;
        data.Creature_TangGreece = false;
        data.Creature_Temp_2 = false;
        data.Gene_Between_1 = false;
        data.Gene_Between_2 = false;
        data.Gene_Between_3 = false;
        data.Gene_Between_4 = false;
        data.Gene_Between_5 = false;
        data.Gene_Between_6 = false;
        data.Gene_Between_7 = false;
        data.Gene_Between_8 = false;
        data.ResearchPoint = 3;
        data.DialgueCounter = 0;


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
