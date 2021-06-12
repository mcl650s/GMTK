using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandelaBuddy : BaseBuddy
{
    void Start()
    {
        base.rb = GetComponent<Rigidbody2D>();
        base.manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        base.player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {   
        if (manager.currentBuddy.Equals(name))
        {
            HoldingHandsState();
        }
        else 
        {
            AloneState();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 3 && manager.currentBuddy.Equals("Candela")) // *ground layer
        {
            Vector3 contactPoint = col.contacts[0].point;
            Vector3 center = transform.position;
            bool bottom = contactPoint.y < center.y;

            if (!bottom) // drop hand
            {
                manager.currentBuddy = string.Empty;
            }
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
