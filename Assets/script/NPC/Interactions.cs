using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [Header("Configuración del NPC")]
    [TextArea(3, 5)] public string mensajeDialogo;
    public float tiempoDisplay = 3f;

    [Header("Referencias UI")]
    public GameObject canvasGlobo;
    public TextMeshProUGUI textoDialogo;

    private bool jugadorCerca = false;
    private Coroutine rutinaOcultar;

    void Start()
    {
        // Nos aseguramos de que empiece oculto
        if (canvasGlobo != null) canvasGlobo.SetActive(false);
    }

    void Update()
    {
        // Si el jugador está cerca y presiona la E
        if (jugadorCerca && Input.GetKeyDown(KeyCode.E))
        {
            Hablar(mensajeDialogo);
        }
    }

    public void Hablar(string dialogueMessage)
    {
        canvasGlobo.SetActive(true);
        textoDialogo.text = dialogueMessage;

        // Si ya había una cuenta atrás corriendo, la reiniciamos
        if (rutinaOcultar != null) StopCoroutine(rutinaOcultar);
        
        rutinaOcultar = StartCoroutine(OcultarGloboDespuesDeTiempo());
    }

    IEnumerator OcultarGloboDespuesDeTiempo()
    {
        yield return new WaitForSeconds(tiempoDisplay);
        canvasGlobo.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) jugadorCerca = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            jugadorCerca = false;
            canvasGlobo.SetActive(false); // Si se aleja, cerramos el globo
        }
    }
}
