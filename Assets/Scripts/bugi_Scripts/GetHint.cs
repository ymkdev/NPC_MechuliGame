using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetHint : MonoBehaviour
{
    public GameObject envelope;
    public GameObject hintpaper;
    public GameObject get;

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

        if (clickObject.name == "Seq_GetBtn")
        {
            envelope.SetActive(true);
            get.SetActive(false);
        }

        if (clickObject.name == "Seq_EnvelopeBtn")
        {
            hintpaper.SetActive(true);
            Main_MainManager.Instance.ClearStage(7);
        }

        if (clickObject.name == "Seq_YesBtn")
        {
            SceneManager.LoadScene("Seq_EndDialog");
        }
    }
}
