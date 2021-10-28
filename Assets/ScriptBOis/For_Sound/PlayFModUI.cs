using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class PlayFModUI : MonoBehaviour
{

    [SerializeField]
    [EventRef]
    public string soundEvent = null;

    public void PlaySoundEvent()
    {
        if(soundEvent != null)
        {
            RuntimeManager.PlayOneShot(soundEvent);
        }
    }

}
