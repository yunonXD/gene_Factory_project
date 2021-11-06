using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Dialogue
{
	[Tooltip("캐릭터 이름")]
	public string name;

	[Tooltip("대사")]
	public string[] context;

}

[System.Serializable]
public class DialogueSystem
{
	public string name;		//무슨 이벤트인지 . ex. 사무실인지 전투씬인지

	public Vector2 line;
	public Dialogue[] dialogues;
}