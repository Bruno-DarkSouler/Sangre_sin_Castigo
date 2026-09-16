using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScreen : MonoBehaviour
{
    public GameObject victoryScreen;
    public TimeManager timeManager;
    private bool playerInside = false;
    private bool alreadyWon = false;
    public int minuteOfWinning;

    void Start()
    {
        victoryScreen.SetActive(false);
    }

    void Update()
    {
        if(alreadyWon) return;

        if(!playerInside) return;

        if(timeManager.timePassed * 60 > 370) //instead of 60 it should be timeManager.timeMultiplier
        {
            alreadyWon = true;
            victoryScreen.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInside = true;
        }
        Debug.Log("Final 1");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInside = false;
        }
        Debug.Log("Final 1");
    }
}
