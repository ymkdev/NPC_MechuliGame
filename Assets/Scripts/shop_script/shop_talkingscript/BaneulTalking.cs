using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[System.Serializable]
public class BaneulDialogue
{
    [TextArea]
    public string dialogue;
    public string name;
    public Sprite cg;
}

public class BaneulTalking : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private SpriteRenderer sprite_NameTag;
    [SerializeField] private Text txt_Dialogue;
    [SerializeField] private Text txt_Name;
    [SerializeField] private BoxCollider2D dialogueBarCollider; // 대화창을 클릭할 BoxCollider2D 컴포넌트를 여기에 할당

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private BaneulDialogue[] dialogue;

    private void Awake()
    {
        Main_SoundManager.instance.PlayBGMForMiniGame(4);
    }

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        NextDialogue();
    }

    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        sprite_NameTag.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        txt_Name.gameObject.SetActive(_flag);

        isDialogue = _flag;
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        txt_Name.text = dialogue[count].name;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++;
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (!isDialogue)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
                if (hit.collider != null && hit.collider.gameObject == dialogueBarCollider.gameObject)
                {
                    if (scene.name == "BaneulTalk" && count == 3)
                    {
                        GameObject.Find("button").transform.Find("buttonCanvas").gameObject.SetActive(true);
                    }
                    else if (count < dialogue.Length)
                        NextDialogue();
                    else
                    {
                        OnOff(false);
                        GameObject.Find("BG").transform.Find("BG2").gameObject.SetActive(true); // BG2 활성화
                    }
                }
            }
        }
    }
}
