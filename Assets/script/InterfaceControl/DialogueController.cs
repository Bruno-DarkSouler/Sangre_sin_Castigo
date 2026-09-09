using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public TimeManager timeManager;
    public List<PersonDialogue> soldiersDialogueList;

    void Update()
    {
        if(timeManager == null) return;

        foreach(PersonDialogue dialogue in soldiersDialogueList)
        {
            Debug.Log("-----------Tiempo-------------");
            Debug.Log(dialogue.GetTotalMinutes());
            Debug.Log(timeManager.timePassed);
            Debug.Log("-----------Tiempo-------------");
            if(!dialogue.wasDisplayed && timeManager.timePassed / 60 >= dialogue.GetTotalMinutes())
            {
                dialogue.wasDisplayed = true;

                dialogue.speaker.Hablar(dialogue.message);
            }
        }
    }
}
