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
    public Sprite [] RuleImageArray;
    public GameObject RuleImage;
    public int idx;
    public GameObject[] HintImageArray;
    public string[] names = { "SampleScene_Mieu", "pic_Gamescene", "fly_GameScene", "ShopGameScene",
    "dangdang_MainScene", "dangdang_MainScene 1", "dangdang_MainScene 2", "tori_Game", "Seq_Level1", "Seq_Level2"};

    // Start is called before the first frame update

    private void Awake()
    {
        foreach (GameObject box in Box)
            box.SetActive(false);

        foreach (GameObject hintObject in HintImageArray)
        {
            hintObject.SetActive(false);
        }
    }

    private void Update()
    {
        idx = GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex;
        if (idx != -1)
            RuleImage.GetComponent<Image>().sprite = RuleImageArray[idx];
    }

    public void HintBtnClick()
    {
        TimePause();
        Debug.Log("힌트 버튼 클릭");
        Box[0].SetActive(true);
        Debug.Log(Box[0]);

        int stageClear = Main_MainManager.Instance.stageClear;

        print(stageClear);
        
        switch (stageClear)
        {
            case 1:
                ShowHint(0);
                break;
            case 2:
                ShowHint(1);
                break;
            case 3:
                ShowHint(2);
                break;
            case 4:
                ShowHint(3);
                break;
            case 5:
                ShowHint(4);
                break;
            case 6:
                ShowHint(5);
                break;
            case 7:
                ShowHint(6);
                break;
            default:
                break;
        }
    }

    private void ShowHint(int hintIndex)
    {
        for (int i = 0; i <= hintIndex; i++)
        {
            HintImageArray[i].SetActive(true);
        }
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
        if (!SceneCheck() || !isGameScene())
            return;

        Debug.Log("이 게임 Lv1부터 다시 시작하기"+idx);
        Close();
 
        switch (idx)
        {
            case 0:
                //미유 낚시
                SceneManager.LoadScene("SampleScene_Mieu");
                break;
            case 1:
                //당근이 같은 그림
                SceneManager.LoadScene("pic_Methodscene");
                break;
            case 2: 
                //개굴이 파리 잡기
                SceneManager.LoadScene("fly_GameScene");
                break;
            case 3:
                //바늘이 장보기
                SceneManager.LoadScene("ShopRuleScene");
                break;
            case 4:
                //몽몽이 같은 댕댕
                SceneManager.LoadScene("dangdang_gameMethod");
                break;
            case 5:
                //토리 당근 홀짝
                SceneManager.LoadScene("tori_Game");
                break;
            case 6:
                //부기 순서 맞추기
                SceneManager.LoadScene("Seq_Level1");
                break;
        }
    }

    public void Setting_RuleClick()
    {
        if (!SceneCheck() || !isGameScene())
            return;
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
        if (RuleImage.activeSelf)
        {
            RuleImage.SetActive(false);
            return;
        }

        for (int i = 0; i < Box.Length; i++)
        {
            if (Box[i].activeSelf)
            {
                Box[i].SetActive(false);
                TimeStart();
                break;
            }
        }

    }

    public bool SceneCheck()
    {
        if (GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex != -1)
            return true;
        else
            return false;
    }
    
    public bool isGameScene()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        foreach (string name in names)
        {
            if (sceneName.Equals(name))
                return true;
        }
        return false;
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
