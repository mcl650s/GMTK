using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBuddy : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rigidbody2D;
    public GameManager manager;


    public abstract void HoldingHandsState();
    public abstract void AloneState();

    public void FollowPlayer()
    {
        transform.localScale = player.transform.localScale;

        Vector3 newPos = transform.position = transform.localScale.x > 0 ? player.transform.position - new Vector3(1.4f, 0, 0) :
                                                                           player.transform.position + new Vector3(1.4f, 0, 0);
        rigidbody2D.MovePosition(newPos);
    }
}
