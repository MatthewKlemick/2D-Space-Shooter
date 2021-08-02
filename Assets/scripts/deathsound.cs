using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathsound : MonoBehaviour
{
    AudioSource audio;

    void Start()
    {
       audio = GetComponent<AudioSource> (); 
    }

    void OnBecameVisible()
    {
        if (!audio.isPlaying)
        {
            audio.Play (); 
        }
        else 
        {
            audio.Stop ();
        }  
    }
    void OnBecameInvisible() 
    {
        audio.Stop ();
    }
}
