using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour{
    public GameObject DataManager;
    [SerializeField] DialogueSystem dialogue;
    

    public Dialogue[] GetDialogues(){
        dialogue.dialogues = DatabaseManager.instance.GetDialogues((int)dialogue.line.x, (int)dialogue.line.y);
        //������ �Ŵ����� ����Ǿ� �ִ� ������ �̰��� �����
        return dialogue.dialogues;
    }

    public void ShowDia()
    {
        //DataManager.gameObject.GetComponent<DialogueManager>().ShowDialogue(GetDialogues());
    }

}
