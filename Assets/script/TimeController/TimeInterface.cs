using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeInterface : MonoBehaviour
{
    public TextMeshProUGUI clockText;
    public TimeManager timeManager;

    // Update is called once per frame
    void Update()
    {

        // This code right here does the exact same as the onebelow but I think that iti is not neccesary to add a data security validation (idk) because it has to be executed per every frame so it could end up reducing the performance
        // if(timeManager != null && clockText != null)
        // {
        //     clockText.text = string.Format("{0:00}{1:00}", timeManager.hours, timeManager.minutes);
        // }
        clockText.text = string.Format("{0:00}:{1:00}", timeManager.hours, timeManager.minutes);
    }
}
