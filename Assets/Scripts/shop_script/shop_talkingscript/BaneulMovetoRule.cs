using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BaneulMovetoRule : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene("ShopRuleScene");
    }
}

