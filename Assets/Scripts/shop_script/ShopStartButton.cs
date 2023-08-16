using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopStartButton : MonoBehaviour
{
    public HomesDatabase homeDB;
    public void OnMouseDown()
    {
        //PlayerPrefs.SetInt("UnlockedHomesss", 0);
        for (int i = 0; i < 7; i++)
        {
            Homes home300 = homeDB.GetHomes(i);
            home300.homeFlag = 0;
            home300.homeFlag2 = 0;
            Debug.Log("초기화");

        }
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        // 0.5초 동안 대기
        yield return new WaitForSeconds(0.5f);

        //임시 설정.. 추후에 어디로 화면 넘길지 수정
        SceneManager.LoadScene("StartScenario");
    }
}

