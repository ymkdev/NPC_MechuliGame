﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Main_SoundManager instance;
    public AudioClip[] audio_clips;
    AudioSource sfx_player;
    public AudioClip[] bgm_clips;
    AudioSource bgm_player;
    public GameObject soundX;
    public GameObject bgmX;

    public Slider sfx_slider;
    public Slider bgm_slider;

    public void Awake()
    {
        instance = this;

        sfx_player = GameObject.Find("Sfx Player").GetComponent<AudioSource>();

        sfx_slider.onValueChanged.AddListener(ChangeSfxSound);

        bgm_player = GameObject.Find("Bgm Player").GetComponent<AudioSource>();

        bgm_slider.onValueChanged.AddListener(ChangeBgmSound);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            PlaySound("Click");
    }
    public void PlaySound(string type)
    {
        int index = 0;

        switch (type) {
            case "Click":
                Debug.Log("클릭 효과음 재생");
                index = 0; break;
            case "CatchFiles_Catch":
                Debug.Log("파리 잡은 효과음 재생");
                index = 1; break;
            case "Fail":
                Debug.Log("실패엔딩 효과음 재생");
                index = 2; break;
            case "Success":
                Debug.Log("성공엔딩 효과음 재생");
                index = 3; break;
        }

        sfx_player.clip = audio_clips[index];
        sfx_player.Play();
    }

    public void PlayBGMForMiniGame(int miniGameIndex)
    {
        if (miniGameIndex >= 0 && miniGameIndex < bgm_clips.Length)
        {
            bgm_player.clip = bgm_clips[miniGameIndex];
            bgm_player.Play();
            Debug.Log("minigameIndex : " + miniGameIndex);
        }
    }

    void ChangeBgmSound(float value)
    {
        bgm_player.volume = value;
        if (bgm_player.volume <= 0)
        {
            bgmX.SetActive(true);
        }
        else
            bgmX.SetActive(false);
    }

    void ChangeSfxSound(float value)
    {
        sfx_player.volume = value;
        if (sfx_player.volume <= 0)
        {
            soundX.SetActive(true);
        }
        else
            soundX.SetActive(false);
    }
}
