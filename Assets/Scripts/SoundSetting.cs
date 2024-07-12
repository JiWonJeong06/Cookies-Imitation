using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSetting : MonoBehaviour
{
    public AudioSource musicsource;
    public AudioSource Jumpsource;
    public AudioSource Slidesource;
    public void SetMusicVolume(float volume){
        musicsource.volume = volume;
        musicsource.Play();
    }

    public void SetEffectVolume(float volume){
        if(Jumpsource.volume >= 0 ) {
            musicsource.Stop();
        }
        Jumpsource.volume = volume;
        Slidesource.volume = volume;
        Jumpsource.Play();
    }
}
