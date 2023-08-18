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
    public GameObject End2_1;
    public GameObject End2_2;
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
            if (!(End1.activeSelf) && !(End2_1.activeSelf) && !(End2_2.activeSelf) && !(End3.activeSelf))
            {
                GameObject.Find("SoundManager").GetComponent<Main_SoundManager>().PlaySound("Success");
                Main_SoundManager.instance.PlayBGMForMiniGame(10);
            }
        }
        else //if (CriminalClick.rslt == false)
        {
            sceneCount = sceneCount + 1;
            End_Success.SetActive(false);
            End_Fail.SetActive(true);
            if (!(End1.activeSelf) && !(End2_1.activeSelf) && !(End2_2.activeSelf) && !(End3.activeSelf))
            {
                GameObject.Find("SoundManager").GetComponent<Main_SoundManager>().PlaySound("Fail");
                Main_SoundManager.instance.PlayBGMForMiniGame(9);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(sceneCount);
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
            Main_SoundManager.instance.PlayBGMForMiniGame(11);
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
            Main_SoundManager.instance.PlayBGMForMiniGame(11);
        }

        // ending scene
        if (clickObject.name == "nextto2_1")
        {
            End2_1.SetActive(true);
            End1.SetActive(false);
        }
        else if (clickObject.name == "nextto2_2")
        {
            End2_2.SetActive(true);
            End2_1.SetActive(false);
        }
        else if (clickObject.name == "nextto3")
        {
            End3.SetActive(true);
            End2_2.SetActive(false);
        }
        else if (clickObject.name == "GoToStartBtn")
        {
            End3.SetActive(false);
            GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().DestroyObj();
            SceneManager.LoadScene("StartScene"); // Go to Start
        }
    }
}
