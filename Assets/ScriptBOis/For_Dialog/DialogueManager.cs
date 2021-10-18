using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

	public Text nameText;
	public Text dialogueText;
	public Button dialogueBox_1;
	public GameObject BlackScrean;
	public GameObject Arrow_for_Click;
	public Button dialogueBox_2;

	private Queue<string> sentences;

	// Use this for initialization
	void Start()
	{
		sentences = new Queue<string>();
	}

	public void StartDialogue(Dialogue dialogue)
	{

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{
		Debug.Log(sentences.Count);
		if (sentences.Count == 0)
		{
			EndDialogue();

			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));


		if (sentences.Count == 0 && nameText.text == "마리아")		//메인메뉴창
		{
			dialogueBox_2.gameObject.SetActive(false);
			Arrow_for_Click.gameObject.SetActive(true);
			BlackScrean.gameObject.SetActive(true);

			return;
		}
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));


	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		dialogueBox_1.gameObject.SetActive(false);
		dialogueText.text = "";
	}

}