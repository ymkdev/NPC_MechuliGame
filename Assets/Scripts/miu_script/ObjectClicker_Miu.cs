using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectClicker_Miu : MonoBehaviour
{
   public GameManagerM gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                if(click_obj.name != "Success" && click_obj.name != "SuccessOk" && click_obj.name != "Fail" && click_obj.name != "FailOk" && click_obj.name != "SFBackGround") //������ ��������
                {
                    Debug.Log(click_obj.name);
                    click_obj.SetActive(false); //������Ʈ ��Ȱ��ȭ
                    //Destroy(click_obj);
                    gameManager.point += 1; //����Ʈ ȹ��
                }
               
                if (gameManager.stageIndex == 0 && gameManager.point >= 15 && gameManager.GameTime1 > 0.0f) //1���� ����
                {
                    gameManager.Stages[0].SetActive(false);
                    gameManager.s.SetActive(true);
                    //gameManager.button1.SetActive(true); //��ư ����
                    //gameManager.UISuccess.SetActive(true); //success�߰� Ȯ��
                    //gameManager.UISFBackground.SetActive(true);
                    Time.timeScale = 0;                   
                }

                if (gameManager.stageIndex == 1 && gameManager.point >= 20 && gameManager.GameTime1 > 0.0f) //2���� ����
                {
                    gameManager.Stages[1].SetActive(false);
                    gameManager.s2.SetActive(true);
                   // gameManager.button2.SetActive(true); //��ư ����
                    //gameManager.UISuccess.SetActive(true); //success�߰� Ȯ��
                    //gameManager.UISFBackground.SetActive(true);
                    Time.timeScale = 0;        
                }
                if (gameManager.stageIndex == 2 && gameManager.point >= 30 && gameManager.GameTime1 > 0.0f) //3���� ����
                {
                    gameManager.button3.SetActive(true); //��ư ����
                    gameManager.UISuccess.SetActive(true); //success�߰� Ȯ��
                    //gameManager.UISFBackground.SetActive(true);
                    Time.timeScale = 0;                    
                }
            }
        }
    }
}
