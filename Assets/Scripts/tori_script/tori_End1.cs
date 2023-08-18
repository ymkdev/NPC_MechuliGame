using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class tori_End1 : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    public GameObject chuchu3;
    public GameObject tori;
    public Text ScriptText_name;
    public Text ScriptText_dialogue;
    public string[] dialogue
        = { "힌트를 얻었다!",
            "이제 어느 정도 힌트가 좀 모였지??",
        };
    public int dialogue_count = 0;

    public void OnPointerDown(PointerEventData data)
    {
        dialogue_count++;
        Debug.Log("dialogue: " + dialogue_count);

        if (dialogue_count == 2)
        {
            Debug.Log("대화 종료");
            SceneManager.LoadScene("MainMap_1");
        }

        ScriptText_dialogue.text = dialogue[dialogue_count];

        //토리 이미지 활성화
        if (dialogue_count == 1)
        {
            chuchu3.SetActive(false);
            tori.SetActive(true);
            ScriptText_name.text = "토리";
        }
    }
}
