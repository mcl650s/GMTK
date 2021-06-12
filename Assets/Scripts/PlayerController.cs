using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController2D controller;
    private GameManager manager;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameObject[] buddies = GameObject.FindGameObjectsWithTag("Buddy");
            float minDist = Vector2.Distance(transform.position, buddies[0].transform.position);
            GameObject closestBuddy = buddies[0];
            foreach (GameObject buddy in buddies) 
            {
                float nextDist = Vector2.Distance(transform.position, buddy.transform.position);
                if (nextDist < minDist)
                {
                    minDist = nextDist;
                    closestBuddy = buddy;
                }
            }

            manager.TryHoldHands(closestBuddy);
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
