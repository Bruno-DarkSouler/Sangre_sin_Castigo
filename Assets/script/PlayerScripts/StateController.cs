using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public PlayerStates playerStates;
    public TimeManager timeManager;
    public float coldMultiplier;
    public float hungerMultiplier;
    public float thirstMultiplier;

    private int updateStatesTime;

    void Start()
    {
        coldMultiplier = 1;
        hungerMultiplier = 1;
        thirstMultiplier = 1;

        updateStatesTime = timeManager.minutes;
    }

    void Update()
    {
        if(timeManager.minutes - updateStatesTime >= 1)
        {
            updateStatesTime = timeManager.minutes;
            playerStates.increaseThirst(10 * thirstMultiplier);
            playerStates.increaseHunger(10 * hungerMultiplier);
            playerStates.increaseCold(10 * coldMultiplier);
        }

        if(timeManager.hours > 20 || timeManager.hours < 7)
        {
            coldMultiplier = 2;
        }
    }
}
