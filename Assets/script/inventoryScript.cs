using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryScript : MonoBehaviour
{
    public GameObject[] slots;//Defino slots(espacios del inventario)
    Text text;//Texto
    [SerializeField] private int maxSlots;//Cantidad maxima de slots

    void Start()
    {
        slots = new GameObject(maxSlots);
    }

    void Update()
    {

    }

    public GameObject[] getSlots()
    {
        return this.slots;
    }      

    public bool remove(Component[] inventory)
    {
        return true;
    }

    public void setSlots()
    {
        Component[] inventory = GameObject.FindGameObjectsWithTag("Inv-intermedio").GetComponentsInChildren<Transform>();//Toma el inventario revisa su contenido
        bool usedSlot = false;//Se fija si un espacio esta ocupado
        if (remove(inventory))
        {
            for (int i = 0; i < slots.Length; i++) 
            {
                if (slots[i] != null)
                { 
                    usedSlot = false;
                    for(int d = 0; d < inventory.Length; d++)
                    {
                        GameObject child = inventory[d].gameObject;
                        if(child.tag == "slot" && child.transform.childCount <= 1 && !usedSlot)
                        {
                            GameObject item = Instantiate(slots[i], child.position, Quaternion.identity);//Insatanciar un item
                            item.transform.SetParent(child.transform, false);
                            item.name = item.name.Replace("Clone", "");
                            text = item.GetComponentInChildren<Text>();
                            int cant = 1;
                            text.text = cant + "";
                            usedSlot = true;
                        }
                    }                
                }
            }
        }
    }
}