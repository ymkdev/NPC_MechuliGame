using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main_MainManager : MonoBehaviour
{
    public int gameIndex;
    public GameObject[] gameObjects;

    
    // Start is called before the first frame update
    void Awake()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        foreach (GameObject obj in gameObjects)
        {
            DontDestroyOnLoad(obj);
            Debug.Log(obj.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
