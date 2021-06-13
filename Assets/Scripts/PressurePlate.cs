using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject pressureBlock;
    private GameManager manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void OnCollisionStay2D(Collision2D col)
    {
        // check for specific gameobject?

        pressureBlock.GetComponent<PressureBlock>().Triggered();
    }

    void OnCollisionExit2D(Collision2D col) 
    {
        pressureBlock.GetComponent<PressureBlock>().Untriggered();
    }
}
