using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class HomesManager : MonoBehaviour
{
    public HomesDatabase homeDB;
    //public Homes hm;//
    //public Text nameText;
    public SpriteRenderer artworkSprite;
    //public int flag = 0;
    public int selectedOption_home = 0;
    //public GameObject A;

    public void Awake()
    {

        //PlayerPrefs.SetInt("UnlockedHomesss", 0);
        for (int i = 0; i < 7; i++)
        {
            //내 코드 homeDB.home[i].homeFlag = 1;
            Homes home31 = homeDB.GetHomes(i);
            home31.homeFlag = 0;
            Debug.Log("했다.");

        }
        //int unlockedHome = PlayerPrefs.GetInt("UnlockedHomes", 0);
        if (!PlayerPrefs.HasKey("UnlockedHomesss"))
        {
            
            Homes home2 = homeDB.GetHomes(0);
            home2.homeFlag = 1;
            Debug.Log("했다2.");
        }
        else
        {
            int unlockedHome = PlayerPrefs.GetInt("UnlockedHomesss");
            if (unlockedHome == 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    //내 코드 homeDB.home[i].homeFlag = 1;
                    Homes home31 = homeDB.GetHomes(i);
                    home31.homeFlag = 1;
                    Debug.Log("모두클리어!");

                }
            }
            else
            {
                Homes home210 = homeDB.GetHomes(unlockedHome);
                home210.homeFlag = 1;
                Debug.Log(unlockedHome + "했다3.");
            }
        }
        
        
        //home2.homeFlag = 1;
        /*for (int i = 0; i < unlockedHome; i++)
        {
            //내 코드 homeDB.home[i].homeFlag = 1;
            Homes home2 = homeDB.GetHomes(i);
            home2.homeFlag = 1;

        }*/
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption_home"))
        {
            selectedOption_home = 0;
        }
        else
        {
            Load();
        }
        UpdateHome(selectedOption_home);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 왼쪽 마우스 버튼 클릭
        {

            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

            if (hit.collider != null && EventSystem.current.IsPointerOverGameObject() == false)
            {
                // 클릭된 Sprite에 대한 처리를 여기에 작성합니다.
                Homes home3 = homeDB.GetHomes(selectedOption_home);

                Debug.Log("Clicked on Sprite: " + hit.collider.gameObject.name + home3.homeFlag + selectedOption_home);
                if (home3.homeFlag == 0)
                {

                }
                else
                {
                    if (selectedOption_home == 0)
                        SceneManager.LoadScene("Talk_Mieu");

                    else if (selectedOption_home == 1)
                        SceneManager.LoadScene("pic_Storyscene");

                    else if (selectedOption_home == 2)
                        SceneManager.LoadScene("fly_MainScene");

                    else if (selectedOption_home == 3)
                        SceneManager.LoadScene("BaneulTalk");

                    else if (selectedOption_home == 4)
                        SceneManager.LoadScene("dangdang_dialogue");

                    else if(selectedOption_home == 5)
                        SceneManager.LoadScene("tori_Intro");

                    else
                        SceneManager.LoadScene("Seq_Dialog");
                }

            }
        }
    }


    public void NextOption()
    {
        selectedOption_home++;
        if (selectedOption_home >= homeDB.HomesCount)
        {
            selectedOption_home = 0;
        }
        UpdateHome(selectedOption_home);
        Save();
    }

    public void BackOption()
    {
        selectedOption_home--;

        if (selectedOption_home < 0)
        {
            selectedOption_home = homeDB.HomesCount - 1;
        }
        UpdateHome(selectedOption_home);
        Save();
    }
    private void UpdateHome(int selectedOption_home)
    {
        Homes home = homeDB.GetHomes(selectedOption_home);
        artworkSprite.sprite = home.homeSprite;
        /*if (home.homeFlag == 0)
            A.SetActive(true);
        else
            A.SetActive(false);
        */
    }

    private void Load()
    {
        selectedOption_home = PlayerPrefs.GetInt("selectedOption_home");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption_home", selectedOption_home);
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}