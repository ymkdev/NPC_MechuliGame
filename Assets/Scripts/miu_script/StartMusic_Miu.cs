using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MainMap_1")
        {
            
            Destroy(gameObject);
        }
        if (scene.name == "startCrime")
        {
            
            Destroy(gameObject);
        }
    }
}
