using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Main_UIClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Btn;
    public GameObject [] Box;
    public GameObject RuleImage;
    public int idx;

    // Start is called before the first frame update

    private void Awake()
    {
        foreach (GameObject box in Box)
            box.SetActive(false);

    }

    private void Update()
    {
        idx = GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex;
    }
    public void HintBtnClick()
    {
        
    }

    public void SettingBtnClick()
    {
        TimePause();
        Debug.Log("설정 버튼 클릭");
        Box[1].SetActive(true);
        Debug.Log(Box[1]);
    }

    public void Setting_ToMainClick()
    {
        Debug.Log("메인으로 버튼 클릭");
        //MainMap으로이동
        Close();
        SceneManager.LoadScene("MainMap_1");

    }

    public void Setting_RetryClick()
    {

        Debug.Log("이 게임 Lv1부터 다시 시작하기"+idx);
        Close();
        string currentScene = SceneManager.GetActiveScene().name;
        
        if (idx == 0)
        {
            Debug.Log("현재 씬 unload");
            SceneManager.UnloadSceneAsync(currentScene);
            SceneManager.LoadScene("SampleScene_Mieu");

        }
        else if (idx == 2)
            SceneManager.LoadScene("fly_GameScene");
        //SceneManager.LoadScene($"GameScene_{idx}");
    }

    public void Setting_RuleClick()
    {
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
        TimeStart();
        if (Box[0].activeSelf)
            Box[0].SetActive(false);
        else if (RuleImage.activeSelf)
            RuleImage.SetActive(false);
        else if (Box[1].activeSelf)
            Box[1].SetActive(false);
        else if (Box[2].activeSelf)
            Box[2].SetActive(false);
    }
    
    public void TimePause()
    {
        Time.timeScale = 0;
    }

    public void TimeStart()
    {
        Time.timeScale = 1;
    }
}
