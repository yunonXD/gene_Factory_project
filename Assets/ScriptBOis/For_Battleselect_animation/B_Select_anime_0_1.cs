using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_Select_anime_0_1 : MonoBehaviour
{

    Animator B_select_Animator;
    public GameObject PlayerData;


    void Update()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == false)        //1_4 ∞° ∆©≈Ù∏ÆæÛ¿”!!
        {
            B_select_Animator.SetBool("Check_Stage", true);
            B_select_Animator.SetBool("Disable", false);
        }

        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true)        
        {
            B_select_Animator.SetBool("Check_Stage", false);
            B_select_Animator.SetBool("Disable", true);
            this.GetComponent<Button>().interactable = false;
        }
    }


    private void Awake()
    {
        B_select_Animator = GetComponent<Animator>();
    }



}
