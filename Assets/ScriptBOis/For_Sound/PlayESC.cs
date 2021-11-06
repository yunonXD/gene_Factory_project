using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class PlayESC : MonoBehaviour
{

    [SerializeField]
    [EventRef]
    public string soundEvent = null;

    public void PlayFESC()
    {
        if(soundEvent != null)
        {
            RuntimeManager.PlayOneShot(soundEvent);
        }
    }

}
