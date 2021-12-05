using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_Select_anime_2_3 : MonoBehaviour
{

    Animator B_select_Animator;
    public GameObject PlayerData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (
            PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == false)
        {
            B_select_Animator.SetBool("Check_Stage", true);
            B_select_Animator.SetBool("Disable", false);
        }

        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
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
