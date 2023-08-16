using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pic_MainManager : MonoBehaviour
{
    //public GameObject[] gameObjects;
    public pic_MainManager main_manager;

    private void Awake()
    {
        GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = 1;
        Main_SoundManager.instance.PlayBGMForMiniGame(2);
    }
}
