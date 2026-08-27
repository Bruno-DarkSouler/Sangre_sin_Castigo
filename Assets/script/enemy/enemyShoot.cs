using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{//Variables de la bala enemiga
    [SerializeField] private float speedBullet;
    private Transform player;
    private Rigidbody2D rb;

    void Start()
    {
        player = GameObject.Find("player").transform;//Traemos el Transform del jugador
        rb = GetComponent<Rigidbody2D>();
        EnemyShoot();
    }

    void EnemyShoot()//Funcion de disparo
    {
        Vector2 shoot = (player.position - transform.position).normalized;//Le indicamos a donde se mueve la bala
        rb.velocity = shoot * speedBullet;//Le damos una velocidad a la bala
        StartCoroutine(DestroyBullet());
    }

    IEnumerator DestroyBullet()//Corrutina para destruir las balas
    {
        float destroyTime = 1f;
        yield return new WaitForSeconds(destroyTime);//Espera y ejecuta la destruccion
        Destroy(gameObject);//Destruye la bala
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
}


