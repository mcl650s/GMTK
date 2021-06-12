using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    private GameObject buddy;
    public bool areHoldingHands;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        GameObject[] buddies = GameObject.FindGameObjectsWithTag("Buddy");
        if (buddies != null) 
        {
            buddy = buddies[0];
        }

        areHoldingHands = false;
    }

    void Update() 
    {
    }

    public void TryHoldHands() 
    {
        if (areHoldingHands) 
        {
            areHoldingHands = false;
        }
        else if (Vector2.Distance(player.transform.position, buddy.transform.position) < 2)
        {
            Debug.Log(Vector2.Distance(player.transform.position, buddy.transform.position));

            areHoldingHands = true;
        }
    }
}
