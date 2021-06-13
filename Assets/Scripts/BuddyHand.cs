using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyHand : MonoBehaviour
{
    public Vector3 holdingOffset;
    private Vector3 originalOffset;
    public bool holdingHands;

    void Start()
    {
        originalOffset = transform.position;
        holdingHands = false;
    }

    void Update()
    {
        
    }

    void UpdateHand(bool holding)
    {
        if (holding)
        {
            transform.position = holdingOffset;
        }
        else 
        {
            transform.position = originalOffset;
        }
    }
}
