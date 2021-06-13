using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSensor : MonoBehaviour
{
    public GameObject switchBlock;
    public GameObject candela;
    public Vector3 offset;
    private bool triggered = false;

    void Update()
    {
        if (Vector2.Distance(transform.position, candela.transform.position) < 2 &&  !triggered)
        {
            switchBlock.GetComponent<SwitchBlock>().offset = offset;
            switchBlock.GetComponent<SwitchBlock>().Update();
            switchBlock.GetComponent<SwitchBlock>().Slide();
            triggered = true;
        }
    }
}