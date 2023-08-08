using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seq_SoundManager : MonoBehaviour
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
       
        var objs = FindObjectsOfType<Fly_SoundManager>();
        if(objs.Length == 1)
        {
            Debug.Log("나옴");
            DontDestroyOnLoad(gameObject);
           
        }
        else
        {
            Destroy(gameObject);
        }
    }
 
}
