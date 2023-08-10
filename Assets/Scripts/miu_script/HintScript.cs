using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScript : MonoBehaviour
{
    public GameObject Hint;
    public GameObject Story;
    public GameObject letterUnopen;
    public GameObject HintOpen;
    public GameObject StoryThanks;
    public CrimeMain cm;

    public GameObject TalkC1;
    public GameObject nameC;
    public GameObject ChuChu;
    public GameObject TalkM;
    public GameObject nameM;
    public GameObject Meaw;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void Awake()
    {
        cm.MgameIndex = 1;
        //GameObject.Find("CrimeMain").GetComponent<CrimeMain>().MgameIndex = 1;
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
                //if (click_obj.name == "Talk")
                //{
                    //Story.SetActive(false);
                    //Hint.SetActive(true);
                    //Debug.Log(click_obj.name);
                //}
                if (click_obj.name == "letterHint") //���� ������ Ŭ�� -> ��ȭâ���� �Ѿ��
                {
                    
                    HintOpen.SetActive(false);
                    StoryThanks.SetActive(true);
                    Debug.Log(click_obj.name);
                }
                if (click_obj.name == "letterUnopen") //������ ����
                {
                    Hint.SetActive(false);
                    HintOpen.SetActive(true);
                    Debug.Log(click_obj.name);
                }
                if (click_obj.name == "TalkC1")
                {
                    TalkC1.SetActive(false);
                    nameC.SetActive(false);
                    ChuChu.SetActive(false); //���� ��ȭâ �����

                    TalkM.SetActive(true);
                    nameM.SetActive(true);
                    Meaw.SetActive(true);
                }
            }
        }
    }

    public void letterClick()
    {
        letterUnopen.SetActive(true); //��ư Ŭ������ ���� ����
    }
 
}
