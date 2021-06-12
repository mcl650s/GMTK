using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    public float fallSpeed = 8.0f;

    private void OnCollisionEnter2D(Collision2D col) 
    {
        StartCoroutine(ShakeAndFall());
    }

    private IEnumerator ShakeAndFall() 
    {
        bool shakingDown = true;

        for (int i = 0; i < 100; i++) 
        {
            gameObject.transform.position = shakingDown ? gameObject.transform.position - new Vector3(0, 1, 0) :
                                                          gameObject.transform.position + new Vector3(0, 1, 0);

            if (i % 10 == 0) 
            {
                shakingDown = !shakingDown;
            }

            yield return null;
        }

        for (int i = 0; i < 100; i++)
        {
            transform.Translate(Vector2.down * fallSpeed * Time.fixedDeltaTime, Space.World);
        }

        GameObject.Destroy(this);
    }
}
