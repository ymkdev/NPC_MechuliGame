using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    public bool Hint_Gaegul = false;
    public MainManager main_manager;

    public float bgm_vol;
    public float sfx_vol;

    // Start is called before the first frame update
    private void Awake()
    {
        foreach (GameObject obj in gameObjects)
        {
            DontDestroyOnLoad(obj);
            Debug.Log(obj.name);
        }

    }

}
