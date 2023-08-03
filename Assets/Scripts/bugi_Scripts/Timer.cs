using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float timer;
    //[SerializeField] float timer = 30.0f;
    //public static string countdownText;
    [SerializeField] Text countdownText;
    public static int timeFlag = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;

        timer = 30.0f;
        //Update();
        countdownText.text = timer.ToString();
        timeFlag = 0;
    }

    void Update()
    {
        if (timer > 0)
            timer -= Time.deltaTime;
        else 
        {
            Time.timeScale = 0.0f;
            //Debug.Log("timeflag is ON");

            timeFlag = 1;
            //Debug.Log(timeFlag);

            if (timeFlag == 1)
                Fail.failGoal = true;
            //Debug.Log(timer);

        }

        if (Finish.goal)
        {
            Time.timeScale = 0;
            countdownText.text = "End";
        }

        countdownText.text = Mathf.Round(timer).ToString(); 
        
    }
    
}
