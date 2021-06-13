using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    private GameManager manager;

    public Vector3 chronoOffset;
    private Vector3 originalOffset;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        originalOffset = transform.localPosition;
    }

    void FixedUpdate()
    {
        
    }

    public void UpdateOffset(string buddy)
    {
        switch (buddy)
        {
            case "Fatass":
                // transform.position = transform.position + fatassOffset;
                break;
            case "Chrono":
                transform.localPosition = chronoOffset;
                break;
            case "Candela":
                // transform.position = transform.position + candelaOffset;
                break;
            default:
                transform.localPosition = originalOffset;
                break;
        }
    }
}
