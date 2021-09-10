using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_Icon_button : MonoBehaviour
{

    public GameObject Unlock_Effect;

    public Text Point_Check;
    int point = 10;

    public Toggle Bicon1, Bicon2, Bicon3, Bicon4, Bicon5, Bicon6, Bicon7, Bicon8, Bicon9;
    public Button B_Bicon7;
    public GameObject Bicon1Intel, Bicon2Intel, Bicon3Intel, Bicon4Intel, Bicon5Intel,
        Bicon6Intel, Bicon7Intel, Bicon8Intel, Bicon9Intel;



    public void Start()
    {
        Point_Check.text = "포인트 :" + point;    
    }


    //<< 훗날 추가할 요소들 고려해서 수정>>
    public void Bicon1Click()
    {
        if (Bicon1.isOn)
        {
            Bicon1Intel.gameObject.SetActive(true);
        }
        else
        {
            Bicon1Intel.gameObject.SetActive(false);
        }
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


    public void Bicon7Click()
    {
        if(point >=3)
        {
            B_Bicon7.gameObject.SetActive(false);
            Bicon7.gameObject.SetActive(true);
            Unlock_Effect.SetActive(true);
            point = point - 3;
            Point_Check.text = "포인트 :" + point;
            //Vector3 spawn = this.gameObject.transform.localPosition;
            //spawn.z = Unlock_Effect.gameObject.transform.localPosition.z;
            //Instantiate(Unlock_Effect, spawn, Quaternion.identity);
        }
        else
        {
            Debug.Log("포인트부족");
            return;
        }
    }


    public void BiconToggle7Click()
    {

        if (Bicon7.isOn)
        {
            Bicon7Intel.gameObject.SetActive(true);
        }
        else
        {
            Bicon7Intel.gameObject.SetActive(false);
        }
    }



    //IEnumerable WaitForDis()
    //{
    //    Unlock_Effect.SetActive(true);
    //    Debug.Log("Ezplode Enter");
    //    yield return new WaitForSeconds(2.0f);
    //    Bicon7.gameObject.SetActive(false);
    //    Debug.Log("Ezplode end");
    //}







}
