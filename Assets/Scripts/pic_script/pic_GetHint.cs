using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pic_GetHint : MonoBehaviour
{
    public GameObject Hint; // 힌트 이미지
    public GameObject HintEnv; //힌트봉투 이미지
    public Button btnHint; // 힌트 보기 버튼

    public void ShowHint()
    {
        HintEnv.gameObject.SetActive(false);
        Hint.gameObject.SetActive(true);
    }

    public void ShowHintEnv()
    {
        HintEnv.gameObject.SetActive(true);
    }
}

