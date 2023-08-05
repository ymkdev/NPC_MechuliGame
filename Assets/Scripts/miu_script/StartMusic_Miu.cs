using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic_Miu : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backmusic;
    
    void Awake()
    {
        BackgroundMusic = GameObject.Find("BackGroundMusic");
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //������� �����ص�

        DontDestroyOnLoad(BackgroundMusic); //������� ��� ����ϰ�(���� ��ư�Ŵ������� ����)

    }
}
