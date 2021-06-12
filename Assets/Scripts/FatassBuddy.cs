using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatassBuddy : BaseBuddy
{
    public Rigidbody2D rigidbody2D;
    private GameManager manager;
    private GameObject player;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {   
        if (manager.areHoldingHands)
        {
            HoldingHandsState();
        }
        else 
        {
            AloneState();
        }
    }

    public override void AloneState() 
    {
    }

    public override void HoldingHandsState()
    {
        transform.localScale = player.transform.localScale;

        Vector3 newPos = transform.position = transform.localScale.x > 0 ? player.transform.position - new Vector3(1.4f, 0, 0) :
                                                                           player.transform.position + new Vector3(1.4f, 0, 0);
        rigidbody2D.MovePosition(newPos);
    }
}
