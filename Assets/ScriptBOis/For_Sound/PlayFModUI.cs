using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class PlayFModUI : MonoBehaviour
{
    public static PlayFModUI instance;

    [SerializeField]
    [EventRef]
    public string BG_Main_Static = null;

    [SerializeField]
    [EventRef]
    public string BG_Story_Pumping = null;

    [SerializeField]
    [EventRef]
    public string BG_Story_Recog = null;

    [SerializeField]
    [EventRef]
    public string BG_Battle_Ready = null;

    [SerializeField]
    [EventRef]
    public string BG_Battle_Normal = null;

    [SerializeField]
    [EventRef]
    public string Normal_Button_Click = null;

    [SerializeField]
    [EventRef]
    public string Normal_Panal_Click = null;


    [SerializeField]
    [EventRef]
    public string Normal_Keypad_Mouce_On = null;

    [SerializeField]
    [EventRef]
    public string Map_Unkown_Click = null;

    [SerializeField]
    [EventRef]
    public string Map_Unlock_Effect_On = null;

    [SerializeField]
    [EventRef]
    public string Document = null;


    private void Awake()
    {
        instance = this;
    }



    public void NPanalClick()
    {
        if (Normal_Panal_Click != null)
        {

            RuntimeManager.PlayOneShot(Normal_Panal_Click);
        }
    }

    public void NbuttonClick()
    {
        if (Normal_Button_Click != null)
        {
            //FMOD.Studio.EventInstance NBClick = RuntimeManager.CreateInstance(Normal_Button_Click);
            //NBClick.start();
            //NBClick.release();
            RuntimeManager.PlayOneShot(Normal_Button_Click);
        }



    }
    public void NKeypadMouse()
    {
        if (Normal_Keypad_Mouce_On != null)
        {
            //FMOD.Studio.EventInstance NKMouce = RuntimeManager.CreateInstance(Normal_Keypad_Mouce_On);
            //NKMouce.start();
            //NKMouce.release();

            RuntimeManager.PlayOneShot(Normal_Keypad_Mouce_On);
        }



    }

    public void NUnknownClick()
    {
        if (Map_Unkown_Click != null)
        {
            //FMOD.Studio.EventInstance MUClick = RuntimeManager.CreateInstance(Map_Unkown_Click);
            //MUClick.start();
            //MUClick.release();

            RuntimeManager.PlayOneShot(Map_Unkown_Click);
        }

    }

    public void GeneDocument()
    {
        if(Document != null)
        {

            RuntimeManager.PlayOneShot(Document);
        }
    }



    public void PlayBGM_Static()
    {
        if (BG_Main_Static != null)
        {
            RuntimeManager.PlayOneShot(BG_Main_Static);
        }

    }

    public void PlayBGM_Story_Pumping()
    {
        if (BG_Story_Pumping != null)
        {

            RuntimeManager.PlayOneShot(BG_Story_Pumping);
        }

    }

    public void PlayBGM_Battle_Recog()
    {
        if (BG_Story_Recog != null)
        {

            RuntimeManager.PlayOneShot(BG_Story_Recog);
        }

    }

    public void PlayBGM_Battle_Ready()
    {
        if (BG_Battle_Ready != null)
        {


            RuntimeManager.PlayOneShot(BG_Battle_Ready);
        }

    }

    public void PlayBGM_Battle_Normal()
    {
        if (BG_Battle_Normal != null)
        {


            RuntimeManager.PlayOneShot(BG_Battle_Normal);
        }

    }

    public void Play_Unlock_Effect()
    {
        if (Map_Unlock_Effect_On != null)
        {

            RuntimeManager.PlayOneShot(Map_Unlock_Effect_On);
            

        }
    }



    public void StopMusic_all()
    {
        //BG_Main_Static.Stop();
    }


    private void Start()
    {
    }




}
