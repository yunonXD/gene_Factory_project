using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ForStory_FMod : MonoBehaviour
{
    public static ForStory_FMod instance;

    [SerializeField]
    [EventRef]
    public string Story_Monitor_On = null;

    [SerializeField]
    [EventRef]
    public string Story_Clock_Sound = null;

    [SerializeField]
    [EventRef]
    public string Story_Printer = null;

    [SerializeField]
    [EventRef]
    public string Story_Signal_off = null;

    [SerializeField]
    [EventRef]
    public string Story_Signal_connect = null;

    [SerializeField]
    [EventRef]
    public string Story_DoorOpen = null;

    [SerializeField]
    [EventRef]
    public string Story_Pen_Sound = null;


    [SerializeField]
    [EventRef]
    public string Story_Stab_Sound = null;

    [SerializeField]
    [EventRef]
    public string Story_Door_knock = null;


    private void Awake()
    {
        instance = this;
    }



    public void Monitor_On()
    {
        if (Story_Monitor_On != null)
        {

            RuntimeManager.PlayOneShot(Story_Monitor_On);
        }
    }

    public void Clock_Sound()
    {
        if (Story_Clock_Sound != null)
        {

            RuntimeManager.PlayOneShot(Story_Clock_Sound);
        }



    }
    public void Printer()
    {
        if (Story_Printer != null)
        {

            RuntimeManager.PlayOneShot(Story_Printer);
        }



    }

    public void Signal_off()
    {
        if (Story_Signal_off != null)
        {

            RuntimeManager.PlayOneShot(Story_Signal_off);
        }

    }

    public void Signal_connect()
    {
        if(Story_Signal_connect != null)
        {

            RuntimeManager.PlayOneShot(Story_Signal_connect);
        }
    }



    public void DoorOpen()
    {
        if (Story_DoorOpen != null)
        {
            RuntimeManager.PlayOneShot(Story_DoorOpen);
        }

    }

    public void Pen_Sound()
    {
        if (Story_Pen_Sound != null)
        {

            RuntimeManager.PlayOneShot(Story_Pen_Sound);
        }

    }

    public void Stab_Sound()
    {
        if (Story_Stab_Sound != null)
        {

            RuntimeManager.PlayOneShot(Story_Stab_Sound);
        }

    }

    public void Door_knock()
    {
        if (Story_Door_knock != null)
        {


            RuntimeManager.PlayOneShot(Story_Door_knock);
        }

    }



    public void StopMusic_all()
    {
        //BG_Main_Static.Stop();
    }

}
