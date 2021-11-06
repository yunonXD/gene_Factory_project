using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour{
    public GameObject DataManager;
    [SerializeField] DialogueSystem dialogue;
    

    public Dialogue[] GetDialogues(){
        dialogue.dialogues = DatabaseManager.instance.GetDialogues((int)dialogue.line.x, (int)dialogue.line.y);
        //데이터 매니저에 저장되어 있는 대사들을 이곳에 끌어옴
        return dialogue.dialogues;
    }

    public void ShowDia()
    {
        //DataManager.gameObject.GetComponent<DialogueManager>().ShowDialogue(GetDialogues());
    }

}
