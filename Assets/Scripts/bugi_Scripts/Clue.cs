using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public GameObject CluePop;
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
        CluePop.SetActive(true);
    }
    public void OnBackClick()
    {
        CluePop.SetActive(false);
    }
}
