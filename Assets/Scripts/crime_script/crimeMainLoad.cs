using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crimeMainLoad : MonoBehaviour
{
   public GameObject m;
   
   void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
         if (scene.name == "startCrime")
        {
            Destroy(m);
        }
        else{
            DontDestroyOnLoad(m);
        }
    }
}
