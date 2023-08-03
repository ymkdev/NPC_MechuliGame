using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Retry : MonoBehaviour
{
    void Start()
    {
        //Fail.failGoal = false;
    }
    
    public static void OnClick()
    {
        Time.timeScale = 1;
        Timer.timer = 30.0f;
        Level1Score.count = 0; // 
        Level2score.count = 0; // spelling

        SceneManager.LoadScene("Seq_Level1");
    }

}
