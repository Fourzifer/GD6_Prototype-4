using UnityEngine.Audio;
using System;
using UnityEngine;

public class Audio_Manager : MonoBehaviour {

    public Sound[] sounds;

    public static Audio_Manager instance;

    
    // Start is called before the first frame update
    void Awake() {

        if (instance == null) 
        instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
 
        DontDestroyOnLoad(gameObject);


        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start ()
    {
    Play ("Mystic");
    }

    public void Play (string name)

    {
   Sound s = Array.Find(sounds, sounds => sounds.name == name );
   if (s == null)
   return;
   s.source.Play();
    }

}
