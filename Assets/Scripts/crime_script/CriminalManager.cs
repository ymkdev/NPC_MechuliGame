using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriminalManager : MonoBehaviour
{
    private void Awake()
    {
        Main_SoundManager.instance.PlayBGMForMiniGame(8);
    }
}
