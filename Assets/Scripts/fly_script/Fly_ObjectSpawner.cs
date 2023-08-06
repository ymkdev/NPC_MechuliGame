using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject flyPrefab;
    public int num;
    bool isFirst = true;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        int x, y;
        int n;

        Debug.Log("Spawn()½ÇÇà");

        if (isFirst)
        {
            n = Random.Range(2, 4);
            isFirst = false;
        }
        else
            n = Random.Range(1, 2);

        //Quaternion rotation = Quaternion.Euler(0, 0, 45);

        for (int i = 0; i < n; i++)
        {
            x = Random.Range(-9, 10);
            y = Random.Range(-5, 6);
            GameObject clone = Instantiate(flyPrefab, new Vector3(x, y, 0), Quaternion.identity);
        }
        Invoke("Spawn", 5);
    }
}
