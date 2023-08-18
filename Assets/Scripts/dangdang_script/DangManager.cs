using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangManager : MonoBehaviour
{
    private void Awake()
    {
        Main_SoundManager.instance.PlayBGMForMiniGame(5);
    }
}
