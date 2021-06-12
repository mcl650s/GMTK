using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWobble : MonoBehaviour
{
    private float t;
    public float Radius;
    public float Speed;

    private Vector3 originalPos;

    void Start()
    {
        originalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        float radiusY = Radius * (0.5f + 0.5f * (Mathf.Sin(t * 0.3f) + 0.3f * Mathf.Sin(2 * t + 0.8f) + 0.26f * Mathf.Sin(3 * t + 0.8f)));
        transform.position = new Vector3(Radius*Mathf.Cos(t*Speed), radiusY*Mathf.Sin(t*Speed), 0) + originalPos;
    }
}
