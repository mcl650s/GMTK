using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlatform : MonoBehaviour
{
    public GameObject movingBlock;
    private GameManager manager;
    private float speed;
    public bool active = true;

    void Awake()
    {
        speed = movingBlock.GetComponent<MovingBlock>().speed;
    }

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if(active)
        {
            movingBlock.GetComponent<MovingBlock>().speed = speed;
        }
    }

    void OnCollisionExit2D(Collision2D col) 
    {
        if(active)
        {
            movingBlock.GetComponent<MovingBlock>().speed = 0f;
        }
    }
}
