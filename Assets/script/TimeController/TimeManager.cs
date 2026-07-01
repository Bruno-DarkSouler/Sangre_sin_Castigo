using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float timeMultiplier;
    public float timePassed;
    
    public int hours;
    public int minutes;
    private float dayPorcentaje;

    public Light2D sunLight;
    public Gradient dayTimeColor;
    // Start is called before the first frame update
    void Start()
    {
        timeMultiplier = 60;
        timePassed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime * timeMultiplier;

        minutes = (int) timePassed / 60 % 60;

        hours = (int) timePassed / 3600 % 24;

        dayPorcentaje = (float) hours / 24;

        sunLight.color = dayTimeColor.Evaluate(dayPorcentaje);

        // Debug.Log(dayPorcentaje);
        // Debug.Log(minutes);
        // Debug.Log(hours);

    }
}
