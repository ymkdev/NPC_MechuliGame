using UnityEngine;
using UnityEngine.SceneManagement;
public class Fly_Movement : MonoBehaviour
{
    public float minX, maxX;
    public float minY, maxY;

    int Xdir = -1;
    int Ydir = -1;

    public float startTime;
    public float moveSpeed;

    public Sprite[] changeSprite;
    public bool isCatch = false;

    private void OnMouseDown()
    {
        if (!isCatch && Time.timeScale != 0)
        {
            Debug.Log("클릭함");
            //SoundManager.instance.PlaySound("CatchFiles_Catch");

            transform.GetComponent<SpriteRenderer>().sprite = changeSprite[0];
            isCatch = true;

            moveSpeed = 0;
            GameObject.Find("GameManager").GetComponent<Fly_GameManager>().score++;
            //Invoke("DestroyFly", 2);
            
        }
    }
    private void Update()
    {
        Debug.Log("Sample_Movements.cs 실행중");
        if(Time.time >= startTime) //게임이 시작하고 startTime 지난 후 실행
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime * Xdir, moveSpeed * Time.deltaTime * Ydir, 0);
       
            if(transform.position.x <= minX ||
                transform.position.x >= maxX)
            {
               Xdir *= -1;
            }

            if(transform.position.y <= minY || 
                transform.position.y >= maxY)
            {
                Ydir *= -1;
            }
        }
    }
    private void DestroyFly()
    {
        Debug.Log("DestoryFly실행");
        Destroy(gameObject);
    }
}
