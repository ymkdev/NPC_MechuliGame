using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultFail : MonoBehaviour
{
    //public GameObject success; //UI오브젝트들을 활성/비활성화 성공
    public GameObject failed; //실패
    //int result;

    // Update is called once per frame
    void Update()
    {
        
        if (Fail.failGoal)
        {
            failed.SetActive(true); //UI오브젝트 활성화
            //result = Mathf.FloorToInt(Timer.timer);
        }

    }


}
