using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public GameObject arrow;
    public CanvasGroup dialogueGroup;

    public Queue<string> sentences;

    public string currentSentence;

    public float typingSpeed = 0.1f;
    public bool isTyping;
    public int index;
    public bool getHint;
    public GameObject character;
    public Text NameText;
    public Sprite[] changeChar;

    public static DialogueManager instance;

    public Scene scene;

    private void Awake()
    {
        Debug.Log("instance 초기화");
        instance = this;
        Debug.Log("instance 초기화 완료");
        Debug.Log("큐 초기화");
        sentences = new Queue<string>();
        Debug.Log("큐 초기화 완료");

        scene = SceneManager.GetActiveScene();
    }

    public void Ondialogue(string[] lines)
    {
        sentences.Clear();
        foreach (string line in lines)
        {
            sentences.Enqueue(line); // 큐에 대사 넣기              
        }
        dialogueGroup.alpha = 1; //대화창 켜짐
        dialogueGroup.blocksRaycasts = true; // 마우스 이벤트 감지

        NextSentence();
    }

    public void NextSentence()
    {
        Debug.Log("다음 대사" + sentences.Count);
        // 큐 빌 때 까지 대사 불러오기
        if (sentences.Count != 0)
        {
            Debug.Log(sentences.Count);
            currentSentence = sentences.Dequeue();
            if ((scene.name).Equals("fly_MainScene")) //메인씬 캐릭터 이미지 교체
            {
                if (index % 2 == 1 || index > 4)
                {
                    Debug.Log(index + "바꾸기");
                    character.GetComponent<SpriteRenderer>().sprite = changeChar[1];
                    NameText.text = "개굴이";
                }
                else
                {
                    character.GetComponent<SpriteRenderer>().sprite = changeChar[0];
                    NameText.text = "츄츄";
                }

            }
            else if ((scene.name).Equals("ClearScene")) //클리어씬 힌트 혹득 true
            {
                Debug.Log("클리어씬"+index);
                if (index == 0)
                    getHint = true;
            }
             else if((scene.name.Equals("AfterClearScene")))
            {
                if (index == 1)
                {
                    character.GetComponent<SpriteRenderer>().sprite = changeChar[1];
                    NameText.text = "개굴이";
                }
                else
                {
                    character.GetComponent<SpriteRenderer>().sprite = changeChar[0];
                    NameText.text = "츄츄";
                }
               
            }
           index++;
           //코루틴
           isTyping = true;
           arrow.SetActive(false);
           StartCoroutine(Typing(currentSentence));
        }
        else
        {
            /*dialogueGroup.alpha = 0;
            dialogueGroup.blocksRaycasts = false;*/
            if ((scene.name).Equals("fly_MainScene"))
                SceneManager.LoadScene("fly_GameScene");
            else if ((scene.name).Equals("ClearScene"))
                SceneManager.LoadScene("TestScene");
        }
    }

    //타이핑효과 코루틴
    IEnumerator Typing(string line)
    {
        dialogueText.text = "";
        foreach (char letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed); //속도조절
        }
    }

    private void Update()
    {
        //dialogueText == currentSentence 이면 대사 한줄 끝
        if (dialogueText.text.Equals(currentSentence)) //메인씬에서 대화 끝나면 화살표 노출
        {
            if(!(scene.name).Equals("ClearScene"))
                arrow.SetActive(true);
            isTyping = false;
            Debug.Log("한줄 끝");
        }
    }

    /* public void OnPointerDown(PointerEventData eventData) // 터치시
     {
         if (!isTyping) //타이핑 효과 중엔 클릭 x
         {
             Debug.Log("다음 대사 호출");
             NextSentence();
         }
     }*/
}
