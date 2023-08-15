using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ending : MonoBehaviour
{
    public int sceneCount = 0;
    public GameObject End_Success;
    public GameObject End_Fail;
    public GameObject End1;
    public GameObject End2;
    public GameObject End3;
    /*public GameObject RetryBtn;
    public GameObject EndBtn;
    public GameObject NextBtn;*/

    // Start is called before the first frame update
    void Start()
    {
        sceneCount = 0;

        if (CriminalClick.rslt == true)
        {
            sceneCount = sceneCount + 1;
            End_Success.SetActive(true);
            End_Fail.SetActive(false);
            if (!(End1.activeSelf) && !(End2.activeSelf) && !(End3.activeSelf))
                GameObject.Find("SoundManager").GetComponent<Main_SoundManager>().PlaySound("Success");
        }
        else //if (CriminalClick.rslt == false)
        {
            sceneCount = sceneCount + 1;
            End_Success.SetActive(false);
            End_Fail.SetActive(true);
            if (!(End1.activeSelf) && !(End2.activeSelf) && !(End3.activeSelf))
                GameObject.Find("SoundManager").GetComponent<Main_SoundManager>().PlaySound("Fail");
        }


        /*  if(sceneCount != 0)
          {
              End_Success.SetActive(false);
              End_Fail.SetActive(false);
          }*/

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(sceneCount);
        if (sceneCount > 1)
        {
            End_Success.SetActive(false);
            End_Fail.SetActive(false);
        }
    }
    public void OnClick()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        // crime success
        if (clickObject.name == "GoEndBtn")
        {
            //End_Success.SetActive(false);
            //NextBtn.SetActive(false); // nextbtn 
            End1.SetActive(true);
            End_Success.SetActive(false);
            sceneCount = sceneCount + 1;
        }
        // crime fail
        if (clickObject.name == "End_RetryBtn") // retry
        {
            GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().DestroyObj();
            SceneManager.LoadScene("StartScene"); // Go to Start
        }
        
        if (clickObject.name == "End_EndBtn")
        {
            //End_Fail.SetActive(true);
            /*RetryBtn.SetActive(false); // retrybtn
            EndBtn.SetActive(false); // endbtn*/
            sceneCount = sceneCount + 1;
            End1.SetActive(true);
            End_Fail.SetActive(false);
            //Debug.Log(End_Fail.activeSelf);
            //End_Success.SetActive(false);
        }

        // ending scene
        if (clickObject.name == "nextto2")
        {
            End2.SetActive(true);
            End1.SetActive(false);
        }
        else if (clickObject.name == "nextto3")
        {
            End3.SetActive(true);
            End2.SetActive(false);
        }
        else if (clickObject.name == "GoToStartBtn")
        {
            End3.SetActive(false);
            GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().DestroyObj();
            SceneManager.LoadScene("StartScene"); // Go to Start
        }
    }
}
