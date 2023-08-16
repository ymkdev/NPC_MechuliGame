using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmap_setIndex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = -1;
        Main_SoundManager.instance.PlayBGMForMiniGame(0);
    }

}
