using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{


    public Sound[] sonidos;


    // Start is called before the first frame update
    void Awake()
    {

        foreach (Sound s in sonidos) {

            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(string name) {

       Sound s = Array.Find(sonidos, sound => sound.name == name);
        s.source.Play();
    } 

}
