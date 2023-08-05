using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D_Miu : MonoBehaviour
{
 private float moveSpeed = 5.0f;
    private Vector3 moveDirection;

    public void SetUp(Vector3 direction)
    {
        moveDirection = direction;
    }

    void Update()
    {
        // ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
