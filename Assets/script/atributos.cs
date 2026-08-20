using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atributos : MonoBehaviour
{
    public int cantidad;

    public void setCant(int cantidad)
    {
        this.cantidad = cantidad;
    }
  
    public int getCant()
    {
        return this.cantidad;
    }

}
