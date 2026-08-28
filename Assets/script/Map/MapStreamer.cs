using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapStreamer : MonoBehaviour
{

    public Transform player;
    public Transform mapGrid;
    public GameObject prefabMap;
    private GameObject mapInstance;
    private bool prefabExists;

    void Start()
    {
        prefabExists = false;
        player.position = new Vector3(-400, -100, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.x);
        if(prefabExists == false && player.position.x < -450 && player.position.x > -551)
        {
            mapInstance = Instantiate(prefabMap, mapGrid);
            prefabExists = true;
        }
        else
        {
            if(prefabExists && (player.position.x > -450 || player.position.x < -551))
            {
                Destroy(mapInstance);
                prefabExists = false;
            }
        }
    }
}
