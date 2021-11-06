using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Dialogue
{
	[Tooltip("ĳ���� �̸�")]
	public string name;

	[Tooltip("���")]
	public string[] context;

}

[System.Serializable]
public class DialogueSystem
{
	public string name;		//���� �̺�Ʈ���� . ex. �繫������ ����������

	public Vector2 line;
	public Dialogue[] dialogues;
}