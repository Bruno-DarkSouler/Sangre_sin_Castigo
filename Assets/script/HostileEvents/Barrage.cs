using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrage : MonoBehaviour
{
    private PlayerStates playerStates;

    void Start()
    {
        Destroy(gameObject, 1f);    //1f indica el tiempo en segundos
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            playerStates = collision.GetComponent<PlayerStates>();
        }
        playerStates.DecreaseHP(30);
    }
}
