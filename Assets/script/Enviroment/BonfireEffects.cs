using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonfireEffects : MonoBehaviour
{
    private bool isNearBonfire;
    private StateController stateController;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            isNearBonfire = true;
            stateController = collision.GetComponent<StateController>();
        }

        Debug.Log("Entraste de la hoguera");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        isNearBonfire = false;
        stateController = null;
        Debug.Log("Saliste de la hoguera");
    }

    void Update()
    {
        if (isNearBonfire && stateController.coldMultiplier > 0)
        {
            stateController.coldMultiplier *= -1;
        }
    }
}
