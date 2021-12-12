using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{


    public Sound[] sonidos;
    public static AudioManager instance;



    // Start is called before the first frame update
    void Awake()
    {

        //Para persistir entre escenas
        if (instance == null)
            instance = this;
        else {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);


        //Para configurar los valores de los sonidos
        foreach (Sound s in sonidos) {

            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Para comenzar con las 
    public void Play(string name) {

       Sound s = Array.Find(sonidos, sound => sound.name == name);

        s.source.Play();
    }

    public void Stop(string name)
    {

        Sound s = Array.Find(sonidos, sound => sound.name == name);

        s.source.Stop();
    }

}
