using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatassBuddy : BaseBuddy
{
    private bool isAlone;

    void Start()
    {
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
        //
    }
}
