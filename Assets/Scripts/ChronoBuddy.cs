using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoBuddy : BaseBuddy
{
    private GameManager manager;

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
        FollowPlayer();
    }
}
