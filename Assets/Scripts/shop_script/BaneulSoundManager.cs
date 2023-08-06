using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaneulSoundManager : MonoBehaviour
{
    public AudioSource bgm;

    public void Awake()
    {
        var soundManagers = FindObjectsOfType<BaneulSoundManager>();
        
        if (soundManagers.Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
      
    }
    void Start()
    {
        bgm.Play();
    }
    void Update()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        // 신이름이 MainMap_1이면 사운드 오브젝트 파괴
        if (currentSceneName == "MainMap_1")
            Destroy(gameObject);
    }
}
