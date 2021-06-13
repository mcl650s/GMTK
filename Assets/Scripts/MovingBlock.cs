using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// constantly moving block
public class MovingBlock : MonoBehaviour
{
    public Vector3 direction;
    public float distance;
    public float speed;
    private float currentDistance;

    private GameManager manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        currentDistance = 0;
    }

    void FixedUpdate()
    {
        if (currentDistance >= distance)
        {
            direction *= -1;
            currentDistance = 0;
        }

        currentDistance += (direction * speed).magnitude;
        transform.position = transform.position + (direction * speed);
    }
}
