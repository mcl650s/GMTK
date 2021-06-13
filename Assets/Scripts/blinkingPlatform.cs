using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class blinkingPlatform : MonoBehaviour
{
    public float rate;
    private float counter;
    private BoxCollider2D hitbox;
    private SpriteRenderer spriteRenderer;
    private ShadowCaster2D caster2D;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        hitbox = gameObject.GetComponent<BoxCollider2D>();
        caster2D = gameObject.GetComponent<ShadowCaster2D>();
    }

    void FixedUpdate()
    {
        counter++;
        if(counter >= (rate * 50))
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            hitbox.enabled = !hitbox.enabled;
            caster2D.enabled = !caster2D.enabled;
            counter = 0;
        }
    }
}
