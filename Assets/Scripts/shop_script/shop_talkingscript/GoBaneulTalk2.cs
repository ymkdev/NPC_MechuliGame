using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBaneulTalk2 : MonoBehaviour
{
    public void OnMouseDown()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        // 0.5초 동안 대기 (클릭 소리 들리도록)
        yield return new WaitForSeconds(0.5f);


        //임시 설정.. 추후에 어디로 화면 넘길지 수정
        SceneManager.LoadScene("BaneulTalk2");
    }
}
