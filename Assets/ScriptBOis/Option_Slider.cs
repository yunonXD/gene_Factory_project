using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_Slider : MonoBehaviour
{

    FMOD.Studio.Bus BGM;
    FMOD.Studio.Bus SFX;
    FMOD.Studio.Bus Master;

    float BGMVolume = 0.5f;
    float SFXVolume = 0.5f;
    float MasterVolume = 1f;

    private void Awake()
    {
        BGM = FMODUnity.RuntimeManager.GetBus("bus:/Master/Music");
        SFX = FMODUnity.RuntimeManager.GetBus("bus:/Master/SFX");
        Master = FMODUnity.RuntimeManager.GetBus("bus:/Master/");
    }



    void Update()
    {

        BGM.setVolume(BGMVolume);
        SFX.setVolume(SFXVolume);
        Master.setVolume(MasterVolume);

    }


    public void MasterVolumeLevel (float newMasterVolume)
    {
        MasterVolume = newMasterVolume;
    }

    public void BGMVolumeLevel (float newBGMVolume)
    {
        BGMVolume = newBGMVolume;
    }

    public void SFXVolumeLevel(float newSFXVolume)
    {
        SFXVolume = newSFXVolume;
    }




}
