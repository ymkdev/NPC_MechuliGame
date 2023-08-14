using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    public GameObject chuchu;
    public GameObject boogie;
    public GameObject startBtn;
    public GameObject YBtn;
    public GameObject NBtn;
    public Text txtName;
    public Text txtSentence;
    public static int cnt = 0; 
    Queue<string> sentences = new Queue<string>();
    Queue<string> names = new Queue<string>();


    public void Begin(Dialog info)
    {
        Debug.Log(startBtn.activeSelf);
        startBtn.SetActive(false);
        //cnt = 0;
        //DialogTrigger.Trigger();
        sentences.Clear();
        names.Clear();

        //txtName.text = info.name;

        foreach(var sentence in info.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (var name in info.names)
        {
            names.Enqueue(name);
        }
        Next();
    }

    public void Next() // 
    {
        Debug.Log(cnt);
        cnt = cnt + 1;

        /*if(cnt == 1) // 그래 아니 버튼 구현 미완성으로 주석 처리
        {
            YBtn.SetActive(true);
            NBtn.SetActive(true);
        }*/
        if (cnt == 2)
        {
            YBtn.SetActive(false);
            NBtn.SetActive(false);
            chuchu.SetActive(true);
            boogie.SetActive(false);
        }
        else
        {
            boogie.SetActive(true);
            chuchu.SetActive(false);
        }  
        
      if(sentences.Count == 0 && names.Count == 0 && cnt == 6)
        {
            //End();

            Debug.Log("1st Dialog End");
            SceneManager.LoadScene("Seq_Level1");
            return;
        }
        if (sentences.Count == 0 && names.Count == 0 && cnt >=7)
        {
            //End();

            Debug.Log("2nd Dialog End");
            SceneManager.LoadScene("startCrime");
            return;
        }
        /*if (names.Count == 0)
        {
            End();
            return;
        }*/

        txtSentence.text = sentences.Dequeue();
        txtName.text = names.Dequeue();
    }

    /*public void End()
    {
        if (cnt == 8) // before game start
        {
            Debug.Log("1st Dialog End");
            SceneManager.LoadScene("Seq_Level1");
        }
        
        *//*if (cnt == 10) // 범인 잡기 씬으로 이동 구현
        {
            Debug.Log("2nd Dialog End");
            SceneManager.LoadScene("Hint");
        }*//*
        
    }
    void Start()
    {
        
    }*/
}
