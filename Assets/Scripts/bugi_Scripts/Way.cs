using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Way : MonoBehaviour
{
    public GameObject WayPop;

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
        WayPop.SetActive(false);
        GameWay.tf = true;
        Time.timeScale = 0;
    }
}
