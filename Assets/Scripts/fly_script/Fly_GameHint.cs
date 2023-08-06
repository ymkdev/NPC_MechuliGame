using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fly_GameHint : MonoBehaviour
{
    public GameObject HintCard;
    public GameObject HintImage;
 //   public GameManager gameManager;
    bool isClick = false;

    // Start is called before the first frame update
    void Start()
    {
        HintCard.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (this.gameObject == HintCard)
        {
            if (isClick == false)
            {
                isClick = true;
                Debug.Log("힌트 카드 클릭");
                HintImage.SetActive(true);
            }
            else
            {
                //HintCard.SetActive(false);
                GameObject.Find("MainManager").GetComponent<Fly_MainManager>().Hint_Gaegul = true;
                SceneManager.LoadScene("AfterClearScene");
            }
        }
        
        if (this.gameObject == HintImage)
        {
            Debug.Log("힌트 이미지 클릭");
            HintImage.SetActive(false);
            HintCard.SetActive(true);
        }
    }//817
}
