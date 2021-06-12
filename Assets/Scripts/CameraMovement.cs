using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 cameraOffset;
    public float cameraSpeed = 0.1f;
    private Transform playerTrans;

    void Start()
    {
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = playerTrans.position + cameraOffset;
    }

    void FixedUpdate()
    {
        Vector3 finalPosition = playerTrans.position + cameraOffset;
        Vector3 lerpPosition = Vector3.Lerp(transform.position, finalPosition, cameraSpeed);
        transform.position = lerpPosition;
    }
}
