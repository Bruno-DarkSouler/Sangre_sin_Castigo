using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enrmigo : MonoBehaviour
{
    public Transform player;//Jugador
    [SerializeField] private float detection;//Rango de deteccion
    [SerializeField] private float enemySpeed;//Velocidad(hay que poner valores altos(supongo por el deltatime))
    private Rigidbody2D rb;//Enemigo
    private Vector2 movement;//Movimiento
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);//Calcula la distancia
        if(distance < detection)
        {
            Vector2 direction = (player.position - transform.position).normalized;//si la distancia es correcta le indica donde debe moverse ne base a las posiciones
            movement = new Vector2(direction.x, direction.y); //Le dice que se mueva izquierda, derecha, arriba y abajo.
        }else{
            movement = Vector2.zero;//si sale del rango que no se mueva(aunque funciona ma o meno esto)
        }

        rb.MovePosition(rb.position + movement * enemySpeed * Time.deltaTime);//Lo mueve
    }
}
