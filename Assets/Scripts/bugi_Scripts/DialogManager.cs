using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
    //public bool s = true;
    Queue<string> sentences = new Queue<string>();
    Queue<string> names = new Queue<string>();
    public static DialogManager instance;

    public void Begin(Dialog info)
    {
        //Debug.Log("Trigger Begin");
        //Debug.Log(startBtn.activeSelf);
        startBtn.SetActive(false);
        //cnt = 0;
        //DialogTrigger.Trigger();
       /* sentences.Clear();
        names.Clear();*/

        //txtName.text = info.name;

        foreach (var sentence in info.sentences)
        {
            sentences.Enqueue(sentence);
            //Debug.Log(sentence);
        }
        foreach (var name in info.names)
        {
            names.Enqueue(name);
            //Debug.Log(name);
        }

        Next();
    }

    public void Next() // 
    {
        Debug.Log(cnt);
        cnt = cnt + 1;
        Debug.Log(cnt);

        if (cnt == 6) // 그래 아니 버튼 구현 미완성으로 주석 처리
        {
            YBtn.SetActive(true);
            NBtn.SetActive(true);

        }
        // picture
        if (cnt == 2)
        {
            /*YBtn.SetActive(false);
            NBtn.SetActive(false);*/
            chuchu.SetActive(true);
            boogie.SetActive(false);

        }
        else
        {
            boogie.SetActive(true);
            chuchu.SetActive(false);
        }  

        if(sentences.Count != 0 && names.Count != 0)
        {
            txtSentence.text = sentences.Dequeue();
            //Debug.Log(sentences.Dequeue());
            txtName.text = names.Dequeue();
            //Debug.Log(names.Dequeue());
        }

       /* if (sentences.Count == 0 && names.Count == 0 && cnt == 6)
        {
            //End();

            Debug.Log("1st Dialog End");
            SceneManager.LoadScene("Seq_Level1");
            return;
        }*/
        if (sentences.Count == 0 && names.Count == 0 && cnt >=8)
        {
            //End();

            Debug.Log("2nd Dialog End");
            SceneManager.LoadScene("startCrime");
            return;
        }

    }

    public void ClickYesBtn()
    {
        //Next();
        YBtn.SetActive(false);
        NBtn.SetActive(false);
        //Begin(info);

        //Next();

        SceneManager.LoadScene("Seq_Level1");
    }
    public void ClickNoBtn()
    {
        YBtn.SetActive(false);
        NBtn.SetActive(false);
        cnt = 0;
        SceneManager.LoadScene("MainMap_1");
    }
    public void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }
    
}
