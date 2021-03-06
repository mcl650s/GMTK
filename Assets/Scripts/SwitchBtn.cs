using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBtn : MonoBehaviour
{
    public GameObject switchBlock;
    public Sprite offSprite;
    public Sprite onSprite;
    private GameManager manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gameObject.GetComponent<SpriteRenderer>().sprite = offSprite;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Vector2.Distance(transform.position, manager.player.transform.position) < 2)
        {
            switchBlock.GetComponent<SwitchBlock>().Slide();
            if(gameObject.GetComponent<SpriteRenderer>().sprite == offSprite)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = onSprite;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = offSprite;
            }
        }
    }
}
