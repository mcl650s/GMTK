using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlatform : MonoBehaviour
{
    public GameObject movingBlock;
    public GameObject pressurePlate = null;
    private float speed;
    public Sprite offSprite;
    public Sprite onSprite;
    private GameManager manager;

    void Awake()
    {
        speed = movingBlock.GetComponent<MovingBlock>().speed;
    }

    void Start()
    {
        movingBlock.GetComponent<MovingBlock>().speed = 0f;
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gameObject.GetComponent<SpriteRenderer>().sprite = offSprite;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Vector2.Distance(transform.position, manager.player.transform.position) < 2)
        {
            movingBlock.GetComponent<MovingBlock>().speed = speed;
            if(pressurePlate != null)
            {
                pressurePlate.GetComponent<PressurePlatform>().active = false;
            }
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
