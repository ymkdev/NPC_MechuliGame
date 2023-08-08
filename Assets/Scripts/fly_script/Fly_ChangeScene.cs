﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fly_ChangeScene : MonoBehaviour
{
    public GameObject Hint;
    public void SceneChange()
    {
        SceneManager.LoadScene("fly_MainScene");
    }

    public void Restart()
    {
        SceneManager.LoadScene("fly_GameScene");
    }

}
