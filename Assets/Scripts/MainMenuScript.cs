using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    private bool transition = false;
    private bool tutorial = false;
    public GameObject menuUI;
    public GameObject tutorialUI;
    public GameObject player;

    private Vector3 menuStart;
    private Vector3 tutorialStart;

    static float t = 0.0f;

    void Start()
    {
        menuStart = menuUI.transform.position;
        tutorialStart = tutorialUI.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transition)
        {
            if(menuUI.transform.position.y < 5.5f)
            {
                menuUI.transform.position = new Vector3(menuUI.transform.position.x, menuUI.transform.position.y + 0.02f, menuUI.transform.position.z);
            }
            else
            {
                menuUI.transform.position = new Vector3(menuUI.transform.position.x + 0.02f, menuUI.transform.position.y + 0.04f, menuUI.transform.position.z);
            }
        }
        if(menuUI.transform.position.x >= 3.01f && !tutorial)
        {
            transition = false;
            tutorial = true;
        }
        if(tutorial && tutorialUI.transform.position.y < 0)
        {
            tutorialUI.transform.position = new Vector3(tutorialUI.transform.position.x, tutorialUI.transform.position.y + 0.01f, tutorialUI.transform.position.z);
        }
        else if(tutorial)
        {
            tutorial = false;
            player.SetActive(true);
        }
    }

    public void startGame()
    {
        transition = true;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
