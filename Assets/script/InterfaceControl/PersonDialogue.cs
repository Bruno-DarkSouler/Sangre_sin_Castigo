using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PersonDialogue
{
    [Header("Horario del Diálogo")]
    public int minute;

    [Header("Contenido")]
    public Interactions speaker; // Nombre o ID del soldado que habla
    [TextArea(2, 4)] public string message;
    public float displayDuration = 4f;

    [HideInInspector] 
    public bool wasDisplayed = false; // Bandera individual para no repetir

    // Convierte hora y minutos a un valor único para comparar fácilmente
    public int GetTotalMinutes()
    {
        return minute;
    }
}
