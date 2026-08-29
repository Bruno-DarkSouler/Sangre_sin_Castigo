using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enrmigo : MonoBehaviour
{
    public Transform player;//Jugador
    [SerializeField] private float distance;//Distancia minima
    [SerializeField] private float enemySpeed;//Velocidad(hay que poner valores altos(supongo por el deltatime))
    private Rigidbody2D rb;//Enemigo
    private Vector2 movement;//Movimiento

    void Update()
    {
        Follow(); 
    }

    void Follow()//Funcion para seguir al jugador
    {
        if (Vector2.Distance(transform.position, player.position) > distance)//Medimos la distancia entre el jugador y el enemigo y lo comparamos con la distancia para empezar a dispara
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, enemySpeed * Time.deltaTime);//El movimiento(le pasamos adonde va, desde donde parte y la velovidad)
        }      
    }
}

