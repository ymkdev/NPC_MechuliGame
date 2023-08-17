using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToriManager : MonoBehaviour
{
    private void Awake()
    {
        Main_SoundManager.instance.PlayBGMForMiniGame(6);
    }
}
