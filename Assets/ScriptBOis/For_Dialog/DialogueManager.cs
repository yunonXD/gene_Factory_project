using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour{

    [SerializeField] GameObject go_Dialogue_Bar;        //�ۺ� ���̾�α׹�
    [SerializeField] Text txt_Dialogue_name;            //�̸�
    [SerializeField] Text txt_Dialogue_string;          //��ȭ â
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
