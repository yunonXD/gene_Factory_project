using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ManagerBGM : MonoBehaviour
{

    [SerializeField]
    private FMODUnity.StudioEventEmitter emitter;


    public class FmodExtensions
    {
        public static bool IsPlaying(FMOD.Studio.EventInstance instance)
        {
            FMOD.Studio.PLAYBACK_STATE state;
            instance.getPlaybackState(out state);
            return state != FMOD.Studio.PLAYBACK_STATE.STOPPED;
        }
    }



    private void Awake()
    {

        if (emitter.IsPlaying()) {
            return; }

        else if (!emitter.IsPlaying())
        {
            GetComponent<FMODUnity.StudioEventEmitter>().Play();
            DontDestroyOnLoad(this);
        }

    }
}
