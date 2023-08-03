using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2score : MonoBehaviour
{
    public static int count = 0;

    public SpriteRenderer ren1;
    public SpriteRenderer ren2;
    public SpriteRenderer ren3;
    public SpriteRenderer ren4;
    public SpriteRenderer ren5;
    public SpriteRenderer ren6;
    public SpriteRenderer ren7;
    public SpriteRenderer ren8;
    public SpriteRenderer ren9;
    public SpriteRenderer ren10;

    public GameObject given1;
    public GameObject given2;
    public GameObject given3;
    public GameObject given4;
    public GameObject given5;
    public GameObject given6;
    public GameObject given7;
    public GameObject given8;
    public GameObject given9;
    public GameObject given10;


    public void OnClickButton()
    {  
        //Debug.Log(gameObject.name + " Clicked");
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;

        if (clickObject.name == "2_bt1")
        {
            Debug.Log("bt1 Clicked");
            if (count == 4)
            {
                count++;
                Debug.Log(count);
                ren5.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }

            if (count == 8)
            {
                count++;
                Debug.Log(count);
                ren9.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }
        else if (clickObject.name == "2_bt2")
        {
            Debug.Log("bt2 Clicked");
            if (count == 2)
            {
                count++;
                Debug.Log(count);
                ren3.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }

            if (count == 9)
            {
                count++;
                Debug.Log(count);
                ren10.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }
        else if (clickObject.name == "2_bt3")
        {
            Debug.Log("bt3 Clicked");
            if (count == 1)
            {
                count++;
                Debug.Log(count);
                ren2.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }

            if (count == 3)
            {
                count++;
                Debug.Log(count);
                ren4.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }
        else if (clickObject.name == "2_bt4")
        {
            Debug.Log("bt4 Clicked");
            if (count == 0)
            {
                count++;
                Debug.Log(count);
                //ren1.color = new Color(1f, 1f, 1f, 0);
                ren1.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }

            if (count == 6)
            {
                count++;
                Debug.Log(count);
                ren7.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }
        else if (clickObject.name == "2_bt5")
        {
            Debug.Log("bt5 Clicked");
            if (count == 5)
            {
                count++;
                Debug.Log(count);
                ren6.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }

            if (count == 7)
            {
                count++;
                Debug.Log(count);
                ren8.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }

        if (count == 10)
        {
            Debug.Log("Finished!!");                                                                                                                                                                                                                                                                                                                                                                                  
            Finish.goal = true;
            Time.timeScale = 1;
            if(clickObject.name == "Finish")
                SceneManager.LoadScene("Seq_Hint");

        }
        else if (Timer.timeFlag == 1 /*&& count != 10*/) 
        {
            //Timer.timer = 0.0f;
            //Time.timeScale = 0.0f;
            Debug.Log("Fail");
            Fail.failGoal = true;

            if (clickObject.name == "Retry")
            {
                Retry();
                Debug.Log("Retry");
            }
        }   
    }


    public static void Retry()
    {
        Fail.failGoal = false;
        //count = 0;
        SceneManager.LoadScene("Seq_Level1");
        Timer.timer = 30.0f;
    }


    void Start()
    {
        count = 0;
        //Countdown.setTime = 30.0f;
        Fail.failGoal = false;
        Timer.timer = 30.5f;
        Time.timeScale = 1;
        //Time.timeScale = 1;
        ren1 = given1.GetComponent<SpriteRenderer>();
        ren2 = given2.GetComponent<SpriteRenderer>();
        ren3 = given3.GetComponent<SpriteRenderer>();
        ren4 = given4.GetComponent<SpriteRenderer>();
        ren5 = given5.GetComponent<SpriteRenderer>();
        ren6 = given6.GetComponent<SpriteRenderer>();
        ren7 = given7.GetComponent<SpriteRenderer>();
        ren8 = given8.GetComponent<SpriteRenderer>();
        ren9 = given9.GetComponent<SpriteRenderer>();
        ren10 = given10.GetComponent<SpriteRenderer>();
    }
}