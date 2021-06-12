using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    private bool transition = false;

    // Update is called once per frame
    void Update()
    {
        if(transition)
        {
            
        }
    }

    void startGame()
    {
        transition = true;
    }
}
