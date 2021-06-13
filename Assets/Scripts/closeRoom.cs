using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeRoom : MonoBehaviour
{
    private bool closed = false;
    public SwitchBlock leftDoor;
    public SwitchBlock rightDoor;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player" && !closed)
        {
            closed = true;
            leftDoor.Slide();
            rightDoor.Slide();
        }
    }
}
