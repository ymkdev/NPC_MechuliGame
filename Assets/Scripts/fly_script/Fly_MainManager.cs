using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_MainManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    public bool Hint_Gaegul = false;
    public Fly_MainManager main_manager;

    public float bgm_vol;
    public float sfx_vol;


    // Start is called before the first frame update
    private void Awake()
    {
        //GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = 2; -> 모두 연결 후 주석 해제
        /*foreach (GameObject obj in gameObjects)
        {
            DontDestroyOnLoad(obj);
            Debug.Log(obj.name);
        }*/

    }

}
