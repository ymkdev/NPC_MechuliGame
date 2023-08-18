using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tori_End : MonoBehaviour
{
    public GameObject hintTori;
    public GameObject hintGetBtn;
    public GameObject hintBox;
    public GameObject toriHint;

    //»˘∆Æ »πµÊ πˆ∆∞ ≈¨∏ØΩ√
    public void HintGetButtonClick()
    {
        hintTori.SetActive(false);
        hintBox.SetActive(true);
    }

    //»˘∆Æ ∫¿≈ı ≈¨∏ØΩ√
    public void HintBoxClick()
    {
        toriHint.SetActive(true);
    }

    //»˘∆Æ ≈¨∏ØΩ√
    public void ToriHintClick()
    {
        hintGetBtn.SetActive(false);
        hintBox.SetActive(false);
        toriHint.SetActive(false);
        SceneManager.LoadScene("tori_End1");
    }
}
