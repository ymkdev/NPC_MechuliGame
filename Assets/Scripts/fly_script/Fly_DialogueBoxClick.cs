using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Fly_DialogueBoxClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) // 터치시
    {
        /*if (!Fly_DialogueManager.instance.isTyping) //타이핑 효과 중엔 클릭 x
        {
            if(Fly_DialogueManager.instance.getHint)

            Debug.Log("다음 대사 호출");
            Fly_DialogueManager.instance.NextSentence();
        }*/
        if (!Fly_DialogueManager.instance.isChoice)
        {
            Debug.Log("박스 클릭");
            Fly_DialogueManager.instance.NextSentence();
        }

    }

    public void OKBtnClick()
    {
        Fly_DialogueManager.instance.NextSentence();
    }
}
