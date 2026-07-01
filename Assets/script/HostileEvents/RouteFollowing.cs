using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RouteFollowing : MonoBehaviour
{
    public Transform[] routePoints;
    [SerializeField] private float planeSpeed;
    private int currentPoint;
    public GameObject explosion;
    
    void Start()
    {
        planeSpeed = 10;
        currentPoint = 0;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, routePoints[currentPoint].position, planeSpeed * Time.deltaTime);
        

        if(Vector3.Distance(transform.position, routePoints[currentPoint].position) < 0.1f)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);

            currentPoint++;

            if(currentPoint >= routePoints.Length)
            {
                currentPoint = 0;
            }
        }
    }
}
