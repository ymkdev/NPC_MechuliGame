using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fly_SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Fly_SoundManager instance;
    public AudioClip[] audio_clips;
    AudioSource bgm_player;
    AudioSource sfx_player;

    public Slider bgm_slider;
    public Slider sfx_slider;

    public void Awake()
    {
        instance = this;
        bgm_player = GameObject.Find("BGM Player").GetComponent<AudioSource>();
        sfx_player = GameObject.Find("Sfx Player").GetComponent<AudioSource>();

        bgm_slider.onValueChanged.AddListener(ChangeBgmSound);
        sfx_slider.onValueChanged.AddListener(ChangeSfxSound);
    }
    
    public void PlaySound(string type)
    {
        int index = 0;

        switch (type) {
            case "CatchFiles_Catch":
                Debug.Log("파리 잡은 효과음 재생");
                index = 1; break;
        }

        sfx_player.clip = audio_clips[index];
        sfx_player.Play();
    }

    void ChangeBgmSound(float value)
    {
        bgm_player.volume = value;
    }

    void ChangeSfxSound(float value)
    {
        sfx_player.volume = value;
    }
}
