using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AllDialogue : MonoBehaviour
{
    public string[] sentences;
    private Scene scene;
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("All Dialogue 스크립트 실행");

        scene = SceneManager.GetActiveScene();
        if ((scene.name).Equals("fly_MainScene"))
        {
            sentences = new string[] { "여긴 왜 이렇게 파리가 많아….", "(개굴이가 뛰쳐나온다)", "개굴아 무슨 일이야??",
            "집에 파리가 너무 많아ㅠㅠㅠ\n나 좀 도와주라", "(맞다 개굴이는 파리를 무서워하는\n특이한 개구리였지..)",
            "화면 속 랜덤으로 나타나는 파리를\n제한 시간 내에 목표 점수만큼\n잡으면 돼!","1라운드는 5점, 2라운드는 8점,\n" +
            "3라운드는 10점이 목표 점수니\n기억하자"};
        }
        else if ((scene.name).Equals("ClearScene"))
        {
            sentences = new string[] { "살았다… 정말 고마워 !!!"};
        }
        else if ((scene.name.Equals("AfterClearScene")))
        {
            sentences = new string[] { "힌트를 얻었다!", "은혜 꼭 갚을게!!" };
        }

        DialogueManager.instance.Ondialogue(sentences);
        Debug.Log("전달완료");
    }

    // Update is called once per frame
    void Update()
    {
    }
}