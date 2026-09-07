using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("Configuracion del movimiento")]
    public float speed = 10.5f;

    [Header("Configuracion del movimiento")]
    [Tooltip("Camino inicial para llegar al lugar del evento")]
    public Transform[] onceWaypoints;

    private int currentOnceIndex = 0;
    private bool finishedPath = false;


    // Update is called once per frame
    void Update()
    {
        if (!finishedPath)
        {
            FollowPath(onceWaypoints, currentOnceIndex);
        }
    }

    private void FollowPath(Transform[] waypointsPath, int index)
    {
        if(index >= waypointsPath.Length)
            {
                finishedPath = true;
                return;
            }

        Transform targetWaypoint = waypointsPath[index];

        transform.position = Vector2.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        Debug.Log("-----------------------------");
        Debug.Log(index);
        Debug.Log(Vector2.Distance(transform.position, targetWaypoint.position) < 1f);
        Debug.Log("-----------------------------");

        if(Vector2.Distance(transform.position, targetWaypoint.position) < 1f)
        {
            currentOnceIndex++;
        }
    }
}
