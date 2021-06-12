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
                canJump = !canJump;
                AssignBuddy(buddy);
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
