using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{

    public GameObject success; //UI오브젝트들을 활성/비활성화 성공
 
    // Update is called once per frame
    void Update()
    {
        if (Finish.goal)
        {
            success.SetActive(true); //UI오브젝트 활성화
            //result = Mathf.FloorToInt(Timer.timer);
        }
       

    }


}