using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    private GameObject buddy;
    public Queue<Vector3> playerPosQ;
    public bool areHoldingHands;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        buddy = GameObject.FindGameObjectsWithTag("Buddy")[0];

        playerPosQ = new Queue<Vector3>();
        areHoldingHands = false;
    }

    void Update() 
    {
        if (areHoldingHands)
        {
            playerPosQ.Enqueue(player.transform.position);
        }
        else 
        {
            playerPosQ.Clear();
        }
    }
}
