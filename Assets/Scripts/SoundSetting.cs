using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSetting : MonoBehaviour
{
    public AudioSource musicsource;

    public AudioSource effectsource;
    public AudioSource effectsource2;

    public void SetMusicVolume(float volume){
        musicsource.volume = volume;
    }

    public void SetEffectVolume(float volume){
        effectsource.volume = volume;
        effectsource2.volume = volume;
    }
}
