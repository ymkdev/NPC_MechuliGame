﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fly_SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Fly_SoundManager instance;
    public AudioSource bgm_player;
    public GameObject soundM;

    public void Start()
    {
        soundM = GameObject.Find("Fly_SoundManager");
        bgm_player.Play();
        DontDestroyOnLoad(soundM);
    }

    public void Update()
    {
        if (GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex != 2)
        {
            Debug.Log("배경 음악 중지");
            Destroy(soundM);
        }
    }
}
