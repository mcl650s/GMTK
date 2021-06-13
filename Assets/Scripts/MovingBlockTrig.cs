using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlockTrig : MonoBehaviour
{
    private Vector3 direction;
    private float speed;

    private GameManager manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        direction = GetComponentInParent<MovingBlock>().direction;
        speed = GetComponentInParent<MovingBlock>().speed;
    }

    void FixedUpdate()
    {
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // only update player position manually if block moving on x-axis
        if (col.gameObject.name.Equals("PlayerTrig"))
        {
            GameObject emptyObject = new GameObject();
            emptyObject.transform.parent = transform;
            manager.player.transform.SetParent(emptyObject.transform);
        }
    }

    // stop updating player position
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("PlayerTrig"))
        {
            manager.player.transform.SetParent(null);
        }
    }
}
