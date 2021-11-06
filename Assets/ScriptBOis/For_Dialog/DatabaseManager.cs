using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour{

    public static DatabaseManager instance;

    [SerializeField] string csv_FileName;

    Dictionary<int, Dialogue> dialogueDic = new Dictionary<int, Dialogue>();     //인덱스, 데이터 역할

    public static bool isFinish = false;        //파싱된 데이터 저장 유무 판단


    private void Awake(){
        if(instance == null){
            instance = this;
            DialogueParser theparser = GetComponent<DialogueParser>();
            Dialogue[] dialogues = theparser.parser(csv_FileName);
            for(int i =0; i < dialogues.Length; i++){
                dialogueDic.Add(i + 1, dialogues[i]);
            }
            isFinish = true;
        }
        
    }

    public Dialogue[] GetDialogues(int _StartNum, int _EndNum){
        List<Dialogue> dialogueList = new List<Dialogue>();

        for( int i = 0; i <= _EndNum - _StartNum; i++){
            dialogueList.Add(dialogueDic[_StartNum + i]);
        }
        return dialogueList.ToArray();
    }
}
