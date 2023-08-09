using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pic_GoToMain : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Time.timeScale = 1.0F;
            SceneManager.LoadScene("MainMap_1");
        }
    }
}
