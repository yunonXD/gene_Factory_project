using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gene_Memory_Store : MonoBehaviour
{
    public GameObject PlayerData;
    public Button[] Gene_Memory_noUnlock;   //壕伸. 情喰 獣佃亀 戚硯精 業旭製 
    public Sprite[] Gene_Unlock_Sprite;     //情喰鞠嬢赤澗 什覗虞戚闘
    public Sprite[] Gene_BigIntel_Screen;   //奄系 適遣馬檎 蟹神澗 神献楕拭 笛 紫遭 什覗虞戚闘

    [Header("==努什闘==")]
    public Text Top_Title;                  //固 是拭 什塘軒 薦鯉
    public Text Day_Log;                    //酔著 舛左 奄系 獣析
    public Text Cut_SceneText;                 //焼掘 竺誤
    public Text ForStoryText;               //什塘軒 遭楳獣 蟹神澗 企鉢但 努什闘

    public GameObject IntelPage;            //神献楕拭 紫遭赤壱 昔土 但 蟹神澗暗

    private int Gene_Memory_Chacker = 0;        //政穿切 原陥 陥献 昔土但 句酔奄 是背 琶推廃 収切 拝雁
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            Gene_Memory_noUnlock[0].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[0];
            Gene_Memory_Chacker = 1;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            Gene_Memory_noUnlock[1].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[1];
            Gene_Memory_Chacker = 2;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            Gene_Memory_noUnlock[2].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[2];
            Gene_Memory_Chacker = 3;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            Gene_Memory_noUnlock[3].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[3];
            Gene_Memory_Chacker = 4;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            Gene_Memory_noUnlock[4].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[4];
            Gene_Memory_Chacker = 5;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            Gene_Memory_noUnlock[5].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[5];
            Gene_Memory_Chacker = 6;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            Gene_Memory_noUnlock[6].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[6];
            Gene_Memory_Chacker = 7;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            Gene_Memory_noUnlock[7].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[7];
            Gene_Memory_Chacker = 8;
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            Gene_Memory_noUnlock[8].gameObject.GetComponent<Image>().sprite = Gene_Unlock_Sprite[8];
            Gene_Memory_Chacker = 9;
        }

    }


    public void Gene_Button_1()
    {
        if (Gene_Memory_noUnlock[0] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
                IntelPage.gameObject.SetActive(true);

            //什覗虞戚闘 痕井
            Top_Title.text = "獄叱戚 弦精劾";
            Day_Log.text = "舛左 奄系 獣析 2210.00.23";
            Cut_SceneText.text = "獄叱戚 進聖 獄叱? 埴せせせせせせせせ... 耕照 ";

        }
    }
    public void Gene_Button_2()
    {
        if (Gene_Memory_noUnlock[1] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "塘晦亜 弦精 劾";
            Day_Log.text = "舛左 奄系 獣析 2210.00.24";
            Cut_SceneText.text = "醤 塘恩! ";
        }
    }

    public void Gene_Button_3()
    {
        if (Gene_Memory_noUnlock[2] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "覗櫛戚 弦精 劾";
            Day_Log.text = "舛左 奄系 獣析 2210.00.25";
            Cut_SceneText.text = "覗櫛覗櫛覗櫛覗櫛 ";
        }
    }
    public void Gene_Button_4()
    {
        if (Gene_Memory_noUnlock[3] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "還覗亜 弦精 劾";
            Day_Log.text = "舛左 奄系 獣析 2210.00.26";
            Cut_SceneText.text = "還? 覗?? ";
        }
    }
    public void Gene_Button_5()
    {
        if (Gene_Memory_noUnlock[4] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "暗重戚 弦精 劾";
            Day_Log.text = "舛左 奄系 獣析 2210.00.27";
            Cut_SceneText.text = "照括 貝 伍銅坪嬢醤 ";
        }
    }
    public void Gene_Button_6()
    {
        if (Gene_Memory_noUnlock[5] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "戚硯 耕舛????";
            Day_Log.text = "舛左 奄系 獣析 2210.00.28";
            Cut_SceneText.text = " 照括 貝 焼送 耕舛戚醤 蟹拭惟 戚硯聖 爽室推 ";
        }
    }
    public void Gene_Button_7()
    {
        if (Gene_Memory_noUnlock[6] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "乞巨昨戚 弦精 劾";
            Day_Log.text = "舛左 奄系 獣析 2210.00.29";
            Cut_SceneText.text = " 乞巨昨? 巨昨? De BIg?  ";
        }
    }
    public void Gene_Button_8()
    {
        if (Gene_Memory_noUnlock[7] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "伝球軒球亜 弦精 劾";
            Day_Log.text = "舛左 奄系 獣析 2210.00.30";
            Cut_SceneText.text = " 伝! 焦 益軒球 ばば ";
        }
    }
    public void Gene_Button_9()
    {
        if (Gene_Memory_noUnlock[8] == true && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            IntelPage.gameObject.SetActive(true);

            Top_Title.text = "戚硯 耕舛2";
            Day_Log.text = "舛左 奄系 獣析 2210.00.31";
            Cut_SceneText.text = "煽澗 戚硯 悪亀拭推. 戚硯聖 爽室推. ";
        }
    }






}
