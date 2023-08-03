using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgm;
    /* public GameObject[] musics;*/
    public GameObject BackgroundMusic;


    public void SetMusicVolume(float volume)
    {
        bgm.volume = volume;
    }

    void Awake()
    {
       
        var objs = FindObjectsOfType<SoundManager>();
        if(objs.Length == 1)
        {
            Debug.Log("³ª¿È");
            DontDestroyOnLoad(gameObject);
           
        }
        else
        {
            Destroy(gameObject);
        }
    }
 
}
