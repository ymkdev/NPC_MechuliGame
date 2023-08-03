using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public GameObject SoundPop;

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
        SoundPop.SetActive(true);
        Time.timeScale = 0;
    }
    public void OnBackClick()
    {
        SoundPop.SetActive(false);
        Time.timeScale = 1;
    }
}
