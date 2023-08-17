using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeqManager : MonoBehaviour
{
    private void Awake()
    {
        Main_SoundManager.instance.PlayBGMForMiniGame(7);
    }
}
