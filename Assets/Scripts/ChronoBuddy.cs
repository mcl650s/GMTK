using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoBuddy : BaseBuddy
{
    public float intervalTime;
    private bool adjustTime;
    private bool isSloMo;

    void Start()
    {
        base.rb = GetComponent<Rigidbody2D>();
        base.manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        base.player = GameObject.FindGameObjectWithTag("Player");

        adjustTime = true;
        isSloMo = false;
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

        if (adjustTime)
        {
            StartCoroutine(TimeInterval());
        }
    }

    private IEnumerator TimeInterval() 
    {
        adjustTime = false;        

        if (isSloMo)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0.5f;
        }

        float elapsedTime = 0;
        while (elapsedTime < intervalTime)
        {
            elapsedTime += Time.fixedDeltaTime;
            yield return null;
        }

        adjustTime = true;
    }
}
