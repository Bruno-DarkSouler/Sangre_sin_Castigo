using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectController : MonoBehaviour
{
    public GameObject object2d;
    public int cant = 1;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject[] inventario = GameObject.FindGameObjectWithTag("GenerarObjeto").GetComponet<inventoryScript>().getSlots();
            for (int i = 0; i < inventario.Length; i++)
            { 
                if (!inventario[i])
                {
                    GameObject.FindGameObjectWithTag("GenerarObjeto").setSlots(object2d, cant);
                    Destroy(gameObject);
                    break;
                }
            }    
        }
    } 


}
