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
        if (manager.currentBuddy.Equals(name))
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
        if (isSloMo)
        {
            Time.timeScale = 1;
            isSloMo = false;
        }
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
            isSloMo = false;
        }
        else
        {
            Time.timeScale = 0.25f;
            isSloMo = true;
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
