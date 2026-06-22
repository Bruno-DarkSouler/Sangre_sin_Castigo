using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BonfireLight : MonoBehaviour
{
    public Light2D fireLight;

    void Update()
    {
        fireLight.intensity = Random.Range(0.0f, 1.0f);
    }
}
