using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RadioController : MonoBehaviour
{
    public GameObject messageObject;
    public TextMeshProUGUI textMessage;

    private Coroutine hideRoutine;

    public static RadioController Instance {get; private set;}

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Public function to be called from anywhere in the project
    /// </summary>
    /// <param name="message">Text to show</param>
    /// <param name="duration">Lifetime</param>
    public void ShowMessage(string message, float duration = 3f)
    {
        textMessage.text = message;

        messageObject.SetActive(true);

        if(hideRoutine != null)
        {
            StopCoroutine(hideRoutine);
        }

        hideRoutine = StartCoroutine(HideAfterLifetime(duration));
    }

    private IEnumerator HideAfterLifetime(float lifetime)
    {
        yield return new WaitForSeconds(lifetime);
        messageObject.SetActive(false);
    }
}
