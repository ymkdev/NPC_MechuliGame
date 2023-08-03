using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Setting set;
    public GameObject s;
    public GameObject s2;

    public float GameTime1 = 25;
    public float GameTime2 = 20;
    public float GameTime3 = 15;
    public int point;
    public Image[] UIseaweed;
    public TMP_Text UITimer;
    public TMP_Text UITimer2;
    public TMP_Text UITimer3;
    public GameObject[] Stages;
    public int stageIndex;
    public GameObject Story;
    public GameObject UISuccess;
    public GameObject UISuccessOk;
    public GameObject UIFail;
    public GameObject UIFailOk;
    public GameObject UISFBackground;
    public Image[] Level;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject reButton1;
    public GameObject reButton2;
    public GameObject reButton3;

    public void NextStage() //다음 스테이지로 넘어가기
    {
        if (stageIndex < Stages.Length - 1)
        {
            UISuccess.SetActive(false); //성공 관련 ui 가리기
           //UISuccessOk.SetActive(false);
            //UISFBackground.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            s.SetActive(false);
            s2.SetActive(false);

            Stages[stageIndex].SetActive(false);
            stageIndex++;
            Time.timeScale = 1;
            Stages[stageIndex].SetActive(true);           
        }
        else
        {
            stageIndex++;
            Time.timeScale = 0;
            Debug.Log("게임 클리어!");
        }
        point = 0;
    }
    public void ReturnStage() 
    {
        SceneManager.LoadScene("GameOver_Mieu"); //실패 화면으로 이동
    }

    public void NextHint()
    {
        UISuccess.SetActive(false); 
        //UISuccessOk.SetActive(false);
        //UISFBackground.SetActive(false);
        button3.SetActive(false);
        Stages[stageIndex].SetActive(false);

        SceneManager.LoadScene("Hint_Mieu"); //힌트창으로 이동
    }


// Update is called once per frame
    public void Update()
    {
        if (stageIndex == 0) //1라운드
        {
            if ((int)GameTime1 == 0) //1라운드 실패
            {
                SceneManager.LoadScene("GameOver_Mieu"); //실패 화면으로 전환
            }
            else //시간 흐르게...
            {
                GameTime1 -= Time.deltaTime;
                //Debug.Log((int)GameTime1);
                UITimer.text = "" + (int)GameTime1;
            }
        }
        if (stageIndex == 1) //2라운드
        {
            if ((int)GameTime2 == 0) //2라운드 실패
            {
                SceneManager.LoadScene("GameOver_Mieu"); //실패 화면으로 전환          
            }
            else
            {
                GameTime2 -= Time.deltaTime;
                //Debug.Log((int)GameTime1);
                UITimer2.text = "" + (int)GameTime2;
            }
        }
        if (stageIndex == 2) //3라운드
        {
            if ((int)GameTime3 == 0) //3라운드 실패
            {
                SceneManager.LoadScene("GameOver_Mieu"); //실패 화면으로 전환               
            }
            else
            {
                GameTime3 -= Time.deltaTime;
                //Debug.Log((int)GameTime1);
                UITimer3.text = "" + (int)GameTime3;
            }
        }
    }
}
    public float currentTime = 0.0f;
    private bool isTimerRunning = false;

    public float startTime = 5;
    public int score = 0;
    public int check = 0;
    public int stageIndex;
    public bool flag = true;

    public GameObject[] Stages;
    public Sprite[] Levels;

    public GameObject Next;
    public GameObject Success;
    public GameObject Rule;
    public GameObject Canvas;

    public float setTime;
    public Text countdownText;
    public Text scoreText;
    public GameObject level;


    void Awake()
    {
        currentTime = 0.0f;
        isTimerRunning = false;
    }
    void Start()
    {
        Rule.SetActive(true);
        isTimerRunning = true;

        Next.SetActive(false);
        countdownText.text = "남은 시간 : " + Mathf.Round(setTime).ToString() + "초";
        scoreText.text = "점수 : " + score.ToString();
        level.GetComponent<Image>().sprite = Levels[stageIndex];

        Next.SetActive(false);
        Success.SetActive(false);
        Stages[0].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       if (isTimerRunning)
        {
            Debug.Log("게임 경과 시간 :"+Time.time);
            Debug.Log("current Time: "+currentTime);
            currentTime += Time.deltaTime;
            if (currentTime >= startTime)
            {
                Rule.SetActive(false);
                Canvas.SetActive(true);
                Stages[0].SetActive(true);
                // 타이머 종료
                isTimerRunning = false;
            }
        }

        if (setTime > 0)
            setTime -= Time.deltaTime;
        else if (setTime <= 0)
        {
            SceneManager.LoadScene("FailScene");
            stageIndex = 0;
        }
        countdownText.text = "남은 시간 : " + Mathf.Round(setTime).ToString() + "초";
        scoreText.text = "점수 : " + score.ToString();
        level.GetComponent<Image>().sprite = Levels[stageIndex];

        if (flag)
        {
            if (stageIndex == 0)
                check = 1;
            else if (stageIndex == 1)
                check = 2;
            else if (stageIndex == 2)
                check = 3;

            if (check == score)
            {
                flag = false;
                Time.timeScale = 0;
                Next.SetActive(true);
                Success.SetActive(true);
            }
        }
    }

    public void NextStage()
    {
        Debug.Log("NextStage함수 실행");
        Next.SetActive(false);
        Success.SetActive(false);
        flag = true;
        score = 0;

        Time.timeScale = 1;

        if (stageIndex < Stages.Length - 1)
        {
            Stages[stageIndex].SetActive(false);
            stageIndex++;
            Stages[stageIndex].SetActive(true);

            if (stageIndex == 1)
                setTime = 20.0f;
            else if (stageIndex == 2)
                setTime = 10.0f;

            //stageText.text = "Level" + (stageIndex + 1).ToString();
            Debug.Log("현재 스테이지 : " + (stageIndex + 1));
        }
        else //Game Clear1
        {
            Debug.Log("게임 클리어");
            SceneManager.LoadScene("ClearScene");
        }

    }
}
