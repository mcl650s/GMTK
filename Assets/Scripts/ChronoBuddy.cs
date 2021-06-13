using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoBuddy : BaseBuddy
{
    public float intervalTime;
    private bool adjustTime;
    private bool isSloMo;
    private bool canSloMo = false;

    public GameObject movingPlatforms;
    public GameObject blinkingPlatforms;


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
            canSloMo = false;
        }
    }

    public override void HoldingHandsState()
    {
        base.FollowPlayer();
        
        canSloMo = true;

        // if (adjustTime)
        // {
        //     StartCoroutine(TimeInterval());
        // }
    }

    public void sloMo()
    {
        if(!canSloMo)
        {
            return;
        }

        if (isSloMo)
        {
            foreach (MovingBlock platform in movingPlatforms.GetComponentsInChildren<MovingBlock>())
            {
                platform.speed = 0.5f;
            }
            foreach (blinkingPlatform platform1 in blinkingPlatforms.GetComponentsInChildren<blinkingPlatform>())
            {
                platform1.rate = 4;
            }
            Debug.Log("tick");
            isSloMo = false;
        }
        else
        {
            foreach (MovingBlock platform in movingPlatforms.GetComponentsInChildren<MovingBlock>())
            {
                platform.speed = 0.1f;
            }
            foreach (blinkingPlatform platform1 in blinkingPlatforms.GetComponentsInChildren<blinkingPlatform>())
            {
                platform1.rate = 0.5f;
            }
            Debug.Log("tock");
            isSloMo = true;
        }
    }

    // private IEnumerator TimeInterval() 
    // {
    //     adjustTime = false;        

    //     if (isSloMo)
    //     {

    //         //Time.timeScale = 1;
    //         Debug.Log("tick");
    //         isSloMo = false;
    //     }
    //     else
    //     {
    //         //Time.timeScale = 0.25f;
    //         Debug.Log("tock");
    //         isSloMo = true;
    //     }

    //     float elapsedTime = 0;
    //     while (elapsedTime < intervalTime)
    //     {
    //         elapsedTime += Time.fixedDeltaTime;
    //         yield return null;
    //     }

    //     adjustTime = true;
    // }
}
