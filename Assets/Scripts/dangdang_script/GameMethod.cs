using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMethod : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

            SceneManager.LoadScene("dangdang_MainScene");

            //SceneManager.LoadScene("MainScene");


    }
}
