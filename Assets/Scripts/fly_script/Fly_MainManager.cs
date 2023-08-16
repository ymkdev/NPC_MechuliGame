using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_MainManager : MonoBehaviour
{
    //public GameObject[] gameObjects;
    public bool Hint_Gaegul = false;
    public Fly_MainManager main_manager;


    // Start is called before the first frame update
    private void Awake()
    {
        GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = 2;
        Main_SoundManager.instance.PlayBGMForMiniGame(3);
    }

}
