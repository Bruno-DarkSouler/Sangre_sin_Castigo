using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> Backpack = new List<GameObject>();
    [SerializeField] private GameObject inventory;
    public bool lifeInv = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("newObject"))
        {
            for (int i = 0; i < Backpack.Count; i++)
            {
                if (Backpack[i].GetComponent<Image>().enabled == false)
                {
                    Backpack[i].GetComponent<Image>().enabled = true;
                    Backpack[i].GetComponent<Image>().sprite = collider.GetComponent<SpriteRenderer>().sprite;
                    break;
                }
            }
        }
    }

    void Start()
    {
        inventory.SetActive(false);
        lifeInv = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("APRETE I");

            lifeInv = !lifeInv;

            Debug.Log("lifeInv = " + lifeInv);

            inventory.SetActive(lifeInv);
        }
    }
}