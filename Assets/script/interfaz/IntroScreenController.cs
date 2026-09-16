using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScreenController : MonoBehaviour
{
    public GameObject introScreen;
    public bool screenActive = true;

    public TimeManager timeManager;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(screenActive && Input.GetKeyDown(KeyCode.E))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        screenActive = false;
        introScreen.SetActive(false);

        if(timeManager != null)
        {
            timeManager.timeIsRunning = true;
        }
    }
}
