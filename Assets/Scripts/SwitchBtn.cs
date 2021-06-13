using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBtn : MonoBehaviour
{
    public GameObject slidingBlock;
    private GameManager manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        // fill in keycode
        if (Input.GetKeyDown(KeyCode.E) && Vector2.Distance(transform.position, manager.player.transform.position) < 2)
        {
            slidingBlock.GetComponent<SlidingBlock>().Slide();
        }
    }
}
