using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour{

    [SerializeField] GameObject go_Dialogue_Bar;        //퍼블릭 다이얼로그바
    [SerializeField] Text txt_Dialogue_name;            //이름
    [SerializeField] Text txt_Dialogue_string;          //대화 창
    Dialogue[] dialogues;

    //bool isDailogue = false;

    public void ShowDialogue()
    {
        //Dialogue[] p_dialogues
        txt_Dialogue_string.text = "";
        txt_Dialogue_name.text = "";
        //dialogues = p_dialogues;
        //SettingUI(true);
    }

    //void SettingUI(bool p_flag)
    //{
    //    go_Dialogue_Bar.SetActive(p_flag);
    //}

}
