using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatassBuddy : BaseBuddy
{
    void Start()
    {
        base.manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        base.player = GameObject.FindGameObjectWithTag("Player");
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
        base.FollowPlayer();
    }
}
