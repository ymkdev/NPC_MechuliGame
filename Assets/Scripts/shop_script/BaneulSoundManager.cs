using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaneulSoundManager : MonoBehaviour
{
    public AudioSource bgm;

    public void Awake()
    {
        var baneulsoundManagers = FindObjectsOfType<BaneulSoundManager>();
        
        if (baneulsoundManagers.Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);

        // 인덱스 설정
        GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = 3;

    }
    void Start()
    {
        bgm.Play();
    }
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        // 신이름이 MainMap_1이면 사운드 오브젝트 파괴
        /* if (currentSceneName != "BaneulTalk" 
             && currentSceneName != "BaneulEndTalk1" 
             && currentSceneName != "ShopGameScene" 
             && currentSceneName != "ShoppingGetHint"
              && currentSceneName != "ShoppingHintScene"
               && currentSceneName != "ShopRuleScene")
             Destroy(gameObject); */
        if (scene.name == "MainMap_1")
        {
            Debug.Log("파괴되어야함");
            Destroy(gameObject);
        }
    }
}
