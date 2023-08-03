using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1Score : MonoBehaviour
{
    //public Text txt;
    //public GameManager gameManager;
    //Timer.timer = 30.0f;

    public AudioSource bgm;

    //public GameObject way; 

    public static int count = 0;
    public SpriteRenderer ren1;
    public SpriteRenderer ren2;
    public SpriteRenderer ren3;
    public SpriteRenderer ren4;
    public SpriteRenderer ren5;
    public SpriteRenderer ren6;
    public SpriteRenderer ren7;
    public SpriteRenderer ren8;

    public GameObject given1;
    public GameObject given2;
    public GameObject given3;
    public GameObject given4;
    public GameObject given5;
    public GameObject given6;
    public GameObject given7;
    public GameObject given8;

    public void OnClickButton()
    {
        //Debug.Log(gameObject.name + " Clicked");
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        
        if (clickObject.name == "1_bt1")
        {
            Debug.Log("bt1 Clicked");
            if (count == 5)
            {
                count++;
                Debug.Log(count);
                ren6.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }
        else if (clickObject.name == "1_bt2")
        {
            Debug.Log("bt2 Clicked");
            if (count == 1)
            {
                count++;
                Debug.Log(count);
                ren2.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }

            if(count == 7)
            {
                count++;
                Debug.Log(count);
                ren8.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }
        else if (clickObject.name == "1_bt3")
        {
            Debug.Log("bt3 Clicked");
            if (count == 0)
            {
                count++;
                Debug.Log(count);
                //given1.SetActive(false);
                ren1.color = new Color(80/255f, 80/255f, 80/255f, 1);
            }
        }
        else if (clickObject.name == "1_bt4")
        {
            Debug.Log("bt4 Clicked");
            if (count == 2)
            {
                count++;
                Debug.Log(count);
                ren3.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }

            if (count == 4)
            {
                count++;
                Debug.Log(count);
                ren5.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }
        else if (clickObject.name == "1_bt5")
        {
            Debug.Log("bt5 Clicked");
            if (count == 3)
            {
                count++;
                Debug.Log(count);
                ren4.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }

            if(count == 6)
            {
                count++;
                Debug.Log(count);
                ren7.color = new Color(80 / 255f, 80 / 255f, 80 / 255f, 1);
            }
        }

        if (count == 8)
        {

            Debug.Log("Finished!!");

            SceneManager.LoadScene("Seq_Level2");

        }else if (Timer.timeFlag == 1)
        {
            //Time.timeScale = 0.0f;
            Debug.Log("Failed");

            Fail.failGoal = true;
            //Retry 
            if (clickObject.name == "Retry")
            {
                Retry();
                Debug.Log("Retry");
            }

        }

    }
    public static void Retry() // 사용 안 함
    {
        Fail.failGoal = false;
        //DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Seq_Level1");
        //Destroy(bgm);
        //SoundManager.bgm.Stop();
        Timer.timer = 30.0f;
        //count = 0; 

    }
   
    void Start()
    {
        count = 0;
        GameWay.tf = true;
        Fail.failGoal = false;
        //Time.timeScale = 0.0f;
        Timer.timer = 30.5f; 
        ren1 = given1.GetComponent<SpriteRenderer>();
        ren2 = given2.GetComponent<SpriteRenderer>();
        ren3 = given3.GetComponent<SpriteRenderer>();
        ren4 = given4.GetComponent<SpriteRenderer>();
        ren5 = given5.GetComponent<SpriteRenderer>();
        ren6 = given6.GetComponent<SpriteRenderer>();
        ren7 = given7.GetComponent<SpriteRenderer>();
        ren8 = given8.GetComponent<SpriteRenderer>();

    }
  
}