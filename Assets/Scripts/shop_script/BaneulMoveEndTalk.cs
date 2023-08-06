using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaneulMoveEndTalk : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click the hint!!!");
            SceneManager.LoadScene("BaneulEndTalk1");

        }
    }
}
