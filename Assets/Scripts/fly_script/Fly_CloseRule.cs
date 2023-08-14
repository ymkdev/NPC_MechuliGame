using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_CloseRule : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameManager;

    public void OnMouseDown()
    {
        Debug.Log("게임 방법 클릭");
        GameManager.GetComponent<Fly_GameManager>().GameStart();
    }
}
