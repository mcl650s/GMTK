using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    public Vector3 direction;
    public float distance;
    public float speed;
    private float currentDistance;
    private bool movePlayer;

    private GameManager manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        currentDistance = 0;
        movePlayer = false;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // only update player position manually if block moving on x-axis
        if (direction.x > 0 && col.gameObject.name.Equals("Player"))
        {
            Vector3 contactPoint = col.contacts[0].point;
            Vector3 center = transform.position;
            bool top = contactPoint.y > center.y;

            if (top)
            {
                col.collider.transform.SetParent(transform);
            }
        }
    }

    // stop updating player position
    private void OnCollisionExit2D(Collision2D col)
    {
        if (direction.x > 0 && col.gameObject.name.Equals("Player"))
        {
            col.collider.transform.SetParent(null);
        }
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
