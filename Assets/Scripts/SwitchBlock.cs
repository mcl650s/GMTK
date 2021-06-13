using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// triggered moving block
public class SwitchBlock : MonoBehaviour
{
    public Vector3 offset;
    public float slideTime;

    private bool isMoved;
    private Vector3 startPos;
    private Vector3 endPos;

    void Start()
    {
        isMoved = false;
        startPos = transform.position;
        endPos = transform.position + offset;
    }

    public void Slide()
    {
        StopAllCoroutines();

        if (isMoved)
        {
            float duration = (transform.position - startPos).magnitude / (endPos - startPos).magnitude; 

            StartCoroutine(LerpPosition(startPos, duration));
        }
        else
        {
            float duration = (transform.position - endPos).magnitude / (startPos - endPos).magnitude; 

            StartCoroutine(LerpPosition(endPos, duration));
        }

        isMoved = !isMoved;
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
