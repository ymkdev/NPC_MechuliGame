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
    public Text txtName;
    public Text txtSentence;
    public static int cnt = 0; 
    Queue<string> sentences = new Queue<string>();
    Queue<string> names = new Queue<string>();


    public void Begin(Dialog info)
    {
        //cnt = 0;
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

    public void Next()
    {
        Debug.Log(cnt);
        cnt = cnt + 1;

        if (cnt == 3 || cnt == 9)
        {
            chuchu.SetActive(true);
            boogie.SetActive(false);
        }
        else
        {
            boogie.SetActive(true);
            chuchu.SetActive(false);
        }  
        
      if(sentences.Count == 0 && names.Count == 0)
        {
            End();
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


    public void End()
    {
        if (cnt == 8) // before game start
        {
            Debug.Log("1st Dialog End");
            SceneManager.LoadScene("Seq_Level1");
        }
        
        /*if (cnt == 10) // before hint
        {
            Debug.Log("2nd Dialog End");
            SceneManager.LoadScene("Hint");
        }*/
        
    }
    void Start()
    {
        
    }
}
