using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeSwap : MonoBehaviour
{
    public void timeSwapTrigger()
    {
        gameObject.GetComponentInParent<ChronoBuddy>().sloMo();
    }
}
