using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    private GameObject buddy;
    private GameObject buddy2;

    // public bool areHoldingHands;
    public string currentBuddy;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        GameObject[] buddies = GameObject.FindGameObjectsWithTag("Buddy");
        if (buddies.Length != 0)
        {
            buddy = buddies[0];
            buddy2 = buddies[1];
        }

        // areHoldingHands = false;
        currentBuddy = string.Empty;
    }

    void Update()
    {
    }

    public void TryHoldHands(GameObject buddy)
    {
        switch (buddy.name)
        {
            case "Fatass":
                AssignBuddy(buddy);
                break;
            case "Chrono":
                AssignBuddy(buddy);
                break;
            default:
                break;
        }
    }

    private void AssignBuddy(GameObject buddy)
    {
        if (!string.IsNullOrEmpty(currentBuddy))
        {
            currentBuddy = string.Empty;
        }
        else if (Vector2.Distance(player.transform.position, buddy.transform.position) < 2)
        {
            currentBuddy = buddy.name;
        }
    }
}
