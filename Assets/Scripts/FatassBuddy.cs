using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatassBuddy : BaseBuddy
{
    private GameManager manager;
    private bool isAlone;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        isAlone = true;
    }

    void FixedUpdate()
    {   
        if (isAlone) 
        {
            AloneState();
        }
        else 
        {
            HoldingHandsState();
        }
    }

    public override void AloneState() 
    {
        // not needed?
    }

    public override void HoldingHandsState()
    {
        if (manager.playerPosQ.Count > 10) 
        {
            Vector3 prevPlayerPos = manager.playerPosQ.Dequeue();
            transform.position = prevPlayerPos;
        }
    }
}
