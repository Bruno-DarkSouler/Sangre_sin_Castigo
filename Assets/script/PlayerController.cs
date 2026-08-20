using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HP;
    public float hunger;
    public float thirst;
    GameObject inventory;
    private float inventario;
    private bool lifeInventory;

    // Start is called before the first frame update
    void Start()
    {
        HP = 100;
        inventario = Input.GetAxisRaw("inventario");
        inventory = GameObject.FindGameObjectWithTag("inventario");
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inventario)
        {
           lifeInventory = true;
           inventory.SetActive(lifeInventory);
        }
        else
        {
            lifeInventory = false;
            inventory.SetActive(lifeInventory);
        }
    }
}
