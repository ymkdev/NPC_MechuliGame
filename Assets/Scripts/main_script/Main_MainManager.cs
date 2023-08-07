using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main_MainManager : MonoBehaviour
{
    public int gameIndex = -1;
    public GameObject[] DontDestroy_Objects;

    // Start is called before the first frame update
    void Awake()
    {

        foreach (GameObject obj in DontDestroy_Objects)
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
