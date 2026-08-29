using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class script_enemigo2 : MonoBehaviour
// {
//     [SerializeField] private float speed;
//     [SerializeField] private float waitTime;
//     private bool waiting;
//     [SerializeField] private Transform[] waypoints;
//     private int waypointActual;
//     private float distanciaMinima = 0.1f;


    // void Update()
    // {   
    //     float distancia = Vector2.Distance(transform.position, waypoints[waypointActual].position);
    //     if (distancia > distanciaMinima)
    //     {
    //         transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointActual].position, speed * Time.deltaTime);
    //     }
    //     else if (!waiting)
    //     {
    //         StartCoroutine(Wait());
    //     }
    // }

    // IEnumerator Wait() 
    // {
    //     waiting = true;
    //     yield return new WaitForSeconds(waitTime);

    //     waypointActual++;
    //     if (waypointActual == waypoints.Length)
    //     {
    //         waypointActual = 0;
    //     }

    //     waiting = false;
    // }
// }
