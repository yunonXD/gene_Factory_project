using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_Icon_button : MonoBehaviour
{
    public GameObject panel;


    public Toggle Bicon1, Bicon2, Bicon3, Bicon4, Bicon5, Bicon6, Bicon7, Bicon8, Bicon9;
    public GameObject Bicon1Intel, Bicon2Intel, Bicon3Intel, Bicon4Intel, Bicon5Intel,
        Bicon6Intel, Bicon7Intel, Bicon8Intel, Bicon9Intel;

    public void Bigicon_Map(){
     panel.SetActive(true);
         
    }

    void Start(){
        
    }

    void Update(){
        
    }

    public void Bicon2Click()
    {
        if (Bicon2.isOn){
            Bicon2Intel.gameObject.SetActive(true);
        }
        else
        {
            Bicon2Intel.gameObject.SetActive(false);
        }
    }


}
