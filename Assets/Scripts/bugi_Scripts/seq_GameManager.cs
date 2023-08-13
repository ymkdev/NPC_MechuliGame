using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seq_GameManager : MonoBehaviour
{
   void Awake()
    {
        GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = 6;
    }
}
