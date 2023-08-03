using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Btn;
    public GameObject [] Box;
    public GameObject HintImage;
    public GameObject RuleImage;
    public GameObject [] Hint;

    // Start is called before the first frame update

    private void Awake()
    {
        // Debug.Log(GameObject.Find("MainManager").GetComponent<MainManager>().Hint_Gaegul);
        foreach (GameObject box in Box)
            box.SetActive(false);

    }
    public void HintBtnClick()
    {
        Debug.Log("힌트 버튼 클릭");
        Box[0].SetActive(true);
        Debug.Log(Box[0]);
        if (GameObject.Find("MainManager").GetComponent<MainManager>().Hint_Gaegul == true)
        {
            foreach(GameObject obj in Hint) //힌트 획득 한 후에 클릭 시 힌트들 보이게
            {
                obj.SetActive(true);
            }
        }
    }
    public void SettingBtnClick()
    {
        Debug.Log("설정 버튼 클릭");
        Box[1].SetActive(true);
        Debug.Log(Box[1]);
    }

    public void Setting_ToMainClick()
    {
        Debug.Log("메인으로 버튼 클릭");
        //MainScene으로이동
        Close();
        SceneManager.LoadScene("TestScene");

    }

    public void Setting_RetryClick()
    {
        Debug.Log("이 게임 Lv1부터 다시 시작하기");
        Close();
        SceneManager.LoadScene("GameScene");
    }

    public void Setting_RuleClick()
    {
        RuleImage.SetActive(true);
        Debug.Log("게임 방법 보여짐");
        

    }

    public void SoundBtnClick()
    {
        Debug.Log("소리 버튼 클릭");
        Box[2].SetActive(true);
        Debug.Log(Box[2]);
    }
    public void Close()
    {
        if (Box[0].activeSelf)
            Box[0].SetActive(false);
        else if (RuleImage.activeSelf)
            RuleImage.SetActive(false);
        else if (Box[1].activeSelf)
            Box[1].SetActive(false);
        else if (Box[2].activeSelf)
            Box[2].SetActive(false);
    }

    public void ShowHint()
    {
        Debug.Log("버튼 클릭");
        HintImage.SetActive(true); //AfterclearScene
        Debug.Log("힌트 보여짐");
    }
    
}
