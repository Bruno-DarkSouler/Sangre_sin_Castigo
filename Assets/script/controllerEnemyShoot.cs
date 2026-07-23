using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerEnemyShoot : MonoBehaviour
{//Variables para controlar el disparo
    [SerializeField] private GameObject prefab;
    [SerializeField] private float delay;
    [SerializeField] private Transform player;
    [SerializeField] private float range;
 
    void Start()
    {
            StartCoroutine(Shoot());
    }

   IEnumerator Shoot()//Corrutina de disparo
    {
        while (true)//Siempre se debe ejecutar
        {
            yield return new WaitForSeconds(delay);//Espera el delay y ejecuta del disparo
            if (Vector2.Distance(transform.position, player.position) <= range)//Se ejecuta el disparo solo si se esta en el rango
            {
                Instantiate(prefab, transform.position, Quaternion.identity);//Instancia las balas para que vayan al enemigo
            }
        }
    }
}
