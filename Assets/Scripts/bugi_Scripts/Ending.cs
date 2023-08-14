using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ending : MonoBehaviour
{
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
        if (CriminalClick.rslt == true)
        {
            End_Success.SetActive(true);
            End_Fail.SetActive(false);
            if (!(End1.activeSelf) && !(End2.activeSelf) && !(End3.activeSelf))
                GameObject.Find("SoundManager").GetComponent<Main_SoundManager>().PlaySound("Success");
        }
        else if (CriminalClick.rslt == false)
        {
            End_Success.SetActive(false);
            End_Fail.SetActive(true);
            if (!(End1.activeSelf) && !(End2.activeSelf) && !(End3.activeSelf))
                GameObject.Find("SoundManager").GetComponent<Main_SoundManager>().PlaySound("Fail");
        }
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
    public void OnClick()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        // crime success
        if (clickObject.name == "GoToEndBtn")
        {
            End_Success.SetActive(false);
            //NextBtn.SetActive(false); // nextbtn 
            End1.SetActive(true);
            End_Success.SetActive(false);

        }
        // crime fail
        if (clickObject.name == "End_RetryBtn") // retry
        {
            SceneManager.LoadScene("StartScene"); // Go to Start
        }
        else if (clickObject.name == "End_EndBtn")
        {
            End_Fail.SetActive(false);
            /*RetryBtn.SetActive(false); // retrybtn
            EndBtn.SetActive(false); // endbtn*/
            End1.SetActive(true);
            End_Fail.SetActive(false);
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
            SceneManager.LoadScene("StartScene"); // Go to Start 
        }
    }
}
