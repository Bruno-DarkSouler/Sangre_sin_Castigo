using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float timeMultiplier;
    public float timePassed;
    
    public int hours;
    // public int trueHours;
    public int minutes;
    // public int trueMinutes;
    public int days = 2;
    private float dayPorcentaje;

    private bool messageSent = false;
    private bool[] isTimeEvent = {false, false};
    private bool[] eventIsDone = {false, false};

    public Light2D sunLight;
    public Gradient dayTimeColor;
    // Start is called before the first frame update
    void Start()
    {
        timeMultiplier = 60;
        timePassed = 10800;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime * timeMultiplier;

        // trueMinutes = (int) timePassed / 60;
        // trueMinutes = (int) timePassed / 3600;

        minutes = (int) timePassed / 60 % 60;
        hours = (int) timePassed / 3600 % 24;
        dayPorcentaje = (float) hours / 24;

        sunLight.color = dayTimeColor.Evaluate(dayPorcentaje);

        if(hours % 24 == 0)
        {
            days++;
        }

        if(timePassed > 3 && !messageSent)
        {
            RadioController.Instance.ShowMessage("Tomori te amo", 3f);
            messageSent = true;
        }
        // Debug.Log("Hola");
        // Debug.Log(minutes);
        // Debug.Log(days);
        // Debug.Log(minutes);
        // Debug.Log(hours);

    }
}
