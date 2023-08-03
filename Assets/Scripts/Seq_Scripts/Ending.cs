using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ending : MonoBehaviour
{
    public GameObject End1;
    public GameObject End2;
    public GameObject End3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;

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
    }
}
