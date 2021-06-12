using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelTransition : MonoBehaviour
{
    public string sceneName;
    public GameObject loader;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            loader.SetActive(true);
            loader.GetComponent<playTransition>().changeLevel(sceneName);
        }
    }
}
