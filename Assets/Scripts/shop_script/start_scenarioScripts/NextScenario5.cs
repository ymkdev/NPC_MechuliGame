using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScenario5 : MonoBehaviour
{
    public void OnMouseDown()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        // 0.5초 동안 대기 (클릭 소리 들리도록)
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("StartGameRule");
    }
}