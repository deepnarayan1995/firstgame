using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this scripts contains all sound effects of Dodge Em All

public class AudioManager : MonoBehaviour
{
    float EffectVolume = 0.2f;

    public AudioSource collisionSound, energyGain, energyLow, gameOver;

    public AudioSource Healthgain, HealthCritical;

    public AudioSource NormalButtonClick, QuitButtonClick;

    public AudioClip introTransition2, endingTransition;
    public AudioSource iaudio;

    public void PlayIntroTransition()
    {
        iaudio.PlayOneShot(introTransition2);
    }

    public void PlayEndingTransition()
    {
        iaudio.PlayOneShot(endingTransition);
    }
    


    public void PlayQuit()
    {
        QuitButtonClick.volume = 0.5f;
        QuitButtonClick.Play();
    }

    public void PlayButton()
    {
        NormalButtonClick.volume = 1f;
        NormalButtonClick.Play();
    }

    public void PlayHealthGain()
    {
        Healthgain.volume = EffectVolume;
        Healthgain.Play();
    }

    public void PlayCollision()
    {
        collisionSound.volume = EffectVolume;
        collisionSound.Play();
    }
    public void PlayEnergy()
    {
        energyGain.volume = EffectVolume;
        energyGain.Play();
    }

    public void PlayGameover()
    {
        gameOver.volume = EffectVolume;
        gameOver.Play();
    }
}
