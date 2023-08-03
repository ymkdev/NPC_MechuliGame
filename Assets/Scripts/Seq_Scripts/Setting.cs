using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public GameObject SettingPop;

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
        SettingPop.SetActive(true);
        Time.timeScale = 0;
    }
    public void OnBackClick()
    {
        SettingPop.SetActive(false);
        Time.timeScale = 1;
    }

}
