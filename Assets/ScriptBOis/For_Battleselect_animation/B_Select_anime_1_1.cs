using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Select_anime_1_1 : MonoBehaviour
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
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true && PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == false)        //1_4 ∞° ∆©≈Ù∏ÆæÛ¿”!!
        {
            B_select_Animator.SetBool("Check_Stage", true);
        }
    }


    private void Awake()
    {
        B_select_Animator = GetComponent<Animator>();
    }



}
