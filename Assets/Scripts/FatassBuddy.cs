using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatassBuddy : BaseBuddy
{
    private GameManager manager;
    private GameObject player;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {   
        if (manager.areHoldingHands)
        {
            HoldingHandsState();
        }
    }

    public override void AloneState() 
    {
    }

    public override void HoldingHandsState()
    {
        transform.localScale = player.transform.localScale;

        transform.position = transform.localScale.x > 0 ? player.transform.position - new Vector3(0.5f, 0, 0) :
                                                          player.transform.position + new Vector3(0.5f, 0, 0);
    }
}
