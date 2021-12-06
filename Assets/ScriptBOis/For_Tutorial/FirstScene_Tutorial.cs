using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstScene_Tutorial : MonoBehaviour
{
    public GameObject PlayerData;


    public Button option_Bitton;
    private Animator B0_animator;

    public Button Continue_Bitton;
    private Animator B1_animator;


    private void Awake() {
        B0_animator = option_Bitton.GetComponent<Animator>();
        B1_animator = Continue_Bitton.GetComponent<Animator>();
    }


    private void Start()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Gene_Between3 == false)
        {
            option_Bitton.GetComponent<Button>().interactable = false;
            B0_animator.SetTrigger("Disabled");

            Continue_Bitton.GetComponent<Button>().interactable = false;
            B1_animator.SetTrigger("Disabled");

        }
        else
        {
            option_Bitton.GetComponent<Button>().interactable = true;
            B0_animator.SetTrigger("Normal");

            Continue_Bitton.GetComponent<Button>().interactable = true;
            B1_animator.SetTrigger("Normal");
            Destroy(this);
        }
    }

    //튜토리얼 진행을 위한 _Gene_Between3 판별
    void Update()
    {

    }

}
