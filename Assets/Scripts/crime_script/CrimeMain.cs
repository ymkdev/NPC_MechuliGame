using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrimeMain : MonoBehaviour
{
    public int MgameIndex = 0;
    public int BgameIndex = 0; //부기
    public int DgameIndex = 0; //댕댕
    public int FgameIndex = 0; //fly
    public int PgameIndex = 0; //pic
    public int SgameIndex = 0; //shop
    public int TgameIndex = 0; //tori


    // Update is called once per frame
    void Update()
    {
        //if(MgameIndex == 1){
            //SceneManager.LoadScene("startCrime");
        //}
        if(MgameIndex == 1 && BgameIndex == 1 && DgameIndex == 1 && FgameIndex == 1 && PgameIndex == 1 &&
        SgameIndex == 1 && TgameIndex == 1){
            SceneManager.LoadScene("startCrime");
        }
    }
}
