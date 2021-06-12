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
        buddy = GameObject.FindGameObjectsWithTag("Buddy")[0];

        areHoldingHands = false;
    }

    void Update() 
    {
    }
}
