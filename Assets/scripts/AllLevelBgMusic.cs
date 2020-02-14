using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLevelBgMusic : MonoBehaviour
{

    public AudioSource level1BGmusic;

    public float Musicvolume = 5f;

    void Start()
    {
        level1BGmusic.volume = Musicvolume;
        level1BGmusic.Play();
    }

    
}
