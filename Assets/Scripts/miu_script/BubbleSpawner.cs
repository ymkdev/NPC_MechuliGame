using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    [SerializeField]
    public int objectSpawnCount = 30;
    [SerializeField]
    public GameObject[] prefabArray;
    [SerializeField]
    private Transform[] spawnPointArray;
    public int currentObjectCount = 0;
    private float objectSpawnTime = 0.0f;
    public List<GameObject> bu = new List<GameObject>();

    public void Update()
    {
        //objectSpawnCount ������ŭ�� �����ϰ� ���̻� �������� �ʵ��� �ϱ� ���� ����
        if(currentObjectCount + 1 > objectSpawnCount)
        {
            return;
        }
        //���ϴ� �ð����� ������Ʈ�� �����ϱ� ���� �ð� ���� ����
        objectSpawnTime += Time.deltaTime;
        
        //0.5�ʿ� �ѹ��� ����
        if(objectSpawnTime >= 1.0f)
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);
            int spawnIndex = Random.Range(0, spawnPointArray.Length);

            Vector3 position = spawnPointArray[spawnIndex].position;
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);
            bu.Add(clone);

            Vector3 moveDirection = Vector3.up;
            clone.GetComponent<Movement2D_Miu>().SetUp(moveDirection);

            currentObjectCount++;
            objectSpawnTime = 0.0f;
        }
    }

    public void DestroyBubble()
    {
        for (int i = 0; i < currentObjectCount; i++)
        {
            bu[i].SetActive(false);
        }
    }

}
