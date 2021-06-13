using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureBlock : MonoBehaviour
{
    public Vector3 offset;
    public float slideTime;
    private bool isTrig;
    private Vector3 startPos;
    private Vector3 endPos;

    void Start()
    {
        isTrig = false;
        startPos = transform.position;
        endPos = transform.position + offset;
    }

    public void Triggered()
    {
        StopAllCoroutines();

        float duration = (transform.position - endPos).magnitude / (startPos - endPos).magnitude; 

        StartCoroutine(LerpPosition(endPos, duration));
    }

    public void Untriggered()
    {
        StopAllCoroutines();

        float duration = (transform.position - startPos).magnitude / (endPos - startPos).magnitude; 

        StartCoroutine(LerpPosition(startPos, duration));
    }

    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
