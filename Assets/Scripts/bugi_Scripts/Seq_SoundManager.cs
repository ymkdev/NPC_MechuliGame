using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Seq_SoundManager : MonoBehaviour
{
    public AudioSource bgm;
    /* public GameObject[] musics;*/
   // public GameObject BackgroundMusic;
    public static Seq_SoundManager instance;

    /*public void SetMusicVolume(float volume)
    {
        bgm.volume = volume;
    }*/

    /*void Awake()
    {
       
        var objs = FindObjectsOfType<Seq_SoundManager>();
        if (objs.Length == 1)
        {
            //Debug.Log("나옴");
            DontDestroyOnLoad(BackgroundMusic);

        }
        else if (SceneManager.GetActiveScene().name == "Seq_Hint")
        {
            Destroy(bgm);
        }
      *//*  if (SceneManager.GetActiveScene().name == "Seq_Hint")
        {
            Destroy(bgm);
        }
        else
        {
            DontDestroyOnLoad(bgm);
        }*//*

    }*/
    public void Start()
    {
        bgm.Play();
        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "startCrime")
        //if(GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex != 6) X
        {
            Destroy(gameObject);
        }
    }
}
