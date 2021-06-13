using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public string currentBuddy;

    public bool canJump;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        currentBuddy = string.Empty;

        canJump = true;
    }

    void Update()
    {
    }

    public void TryHoldHands(GameObject buddy)
    {
        switch (buddy.name)
        {
            case "Fatass":
                if(AssignBuddy(buddy))
                {
                    canJump = !canJump;
                }
                break;
            case "Chrono":
                AssignBuddy(buddy);
                break;
            case "Candela":
                AssignBuddy(buddy);
                break;
            default:
                break;
        }
    }

    private bool AssignBuddy(GameObject buddy)
    {
        if (!string.IsNullOrEmpty(currentBuddy))
        {
            currentBuddy = string.Empty;
            player.GetComponentInChildren<PlayerHand>().UpdateOffset(string.Empty);
            return true;
        }
        else if (Vector2.Distance(player.transform.position, buddy.transform.position) < 2)
        {
            currentBuddy = buddy.name;
            player.GetComponentInChildren<PlayerHand>().UpdateOffset(buddy.name);
            return true;
        }
        return false;
    }
}
