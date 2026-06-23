using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topdownmovent : MonoBehaviour
{
    //Solo con esto tenemos el movimiento del personaje
    //Variables de referencia para la velocidad y direccion
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;
    private Rigidbody2D rb2D;
    //Para la animacion
    [SerializeField] private float movex;
    [SerializeField] private float movey;
    private Animator animation;

    //Funcion para iniciar(siempre en mayuscula, son funciones de unity)
    private void Start()
    {
        animation = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();

    }
    //Funcion para actualizar(siempre en mayuscula)
    private void Update()
    {
        movex = Input.GetAxisRaw("Horizontal");
        movey = Input.GetAxisRaw("Vertical");
        animation.SetFloat("movex", movex);//Animacion en x(izquierda y derecha)
        animation.SetFloat("movey",movey);//Animacion en y(arriba y abajo)
        //Parte del funcionamiento de la animacion idle(para estar quieto)
        if (movex != 0 || movey != 0) {
            animation.SetFloat("finx", movex);
            animation.SetFloat("finy", movey);
        }
        direction = new Vector2(movex, movey).normalized;
    }
    //Otra funcion para actualizar(siempre en mayuscula)
    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direction * speed * Time.fixedDeltaTime);
    }
}
