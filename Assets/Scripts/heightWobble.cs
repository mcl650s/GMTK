using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heightWobble : MonoBehaviour
{
    private Vector3 newPosition;

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.y += ((Mathf.Sin(Time.time) * Time.deltaTime)/12);
        transform.position = newPosition;
    }
}
