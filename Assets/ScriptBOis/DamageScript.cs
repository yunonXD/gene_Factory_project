using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject damege_0;
    public GameObject damege_1;
    public GameObject damege_2;
    public GameObject damege_3;
    public GameObject damege_4;
    public GameObject damege_5;
    public GameObject damege_6;
    public GameObject damege_7;
    public GameObject damege_8;
    public GameObject damege_9;
    public GameObject damege_00;
    public GameObject damege_10;
    public GameObject damege_20;
    public GameObject damege_30;
    public GameObject damege_40;
    public GameObject damege_50;
    public GameObject damege_60;
    public GameObject damege_70;
    public GameObject damege_80;
    public GameObject damege_90;

    private bool movecount;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void damage(int j, int i)
    {

        switch (i)
        {
            case 0:
                {
                    damege_00.SetActive(true);
                    break;
                };
            case 1:
                {
                    damege_10.SetActive(true);
                    break;
                };
            case 2:
                {
                    damege_20.SetActive(true);
                    break;
                };
            case 3:
                {
                    damege_30.SetActive(true);
                    break;
                };
            case 4:
                {
                    damege_40.SetActive(true);
                    break;
                };
            case 5:
                {
                    damege_50.SetActive(true);
                    break;
                };
            case 6:
                {
                    damege_60.SetActive(true);
                    break;
                };
            case 7:
                {
                    damege_70.SetActive(true);
                    break;
                }
            case 8:
                {
                    damege_80.SetActive(true);
                    break;
                };
            case 9:
                {
                    damege_90.SetActive(true);
                    break;
                };
        };


        switch (j)
        {
            case 0:
                {
                    damege_0.SetActive(true);
                    break;
                };
            case 1:
                {
                    damege_1.SetActive(true);
                    break;
                };
            case 2:
                {
                    damege_2.SetActive(true);
                    break;
                };
            case 3:
                {
                    damege_3.SetActive(true);
                    break;
                };
            case 4:
                {
                    damege_4.SetActive(true);
                    break;
                };
            case 5:
                {
                    damege_5.SetActive(true);
                    break;
                };
            case 6:
                {
                    damege_6.SetActive(true);
                    break;
                };
            case 7:
                {
                    damege_7.SetActive(true);
                    break;
                }
            case 8:
                {
                    damege_8.SetActive(true);
                    break;
                };
            case 9:
                {
                    damege_9.SetActive(true);
                    break;
                };
        };
        
    }

    public void Reset()
    {
        damege_00.SetActive(false);
        damege_10.SetActive(false);
        damege_20.SetActive(false);
        damege_30.SetActive(false);
        damege_40.SetActive(false);
        damege_50.SetActive(false);
        damege_60.SetActive(false);
        damege_70.SetActive(false);
        damege_80.SetActive(false);
        damege_90.SetActive(false);
        damege_0.SetActive(false);
        damege_1.SetActive(false);
        damege_2.SetActive(false);
        damege_3.SetActive(false);
        damege_4.SetActive(false);
        damege_5.SetActive(false);
        damege_6.SetActive(false);
        damege_7.SetActive(false);
        damege_8.SetActive(false);
        damege_9.SetActive(false);




    }
}
    

