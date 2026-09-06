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
    private float movexE;
    private float moveyE;
    private Animator animator;
    public PlayerStates control;


    void Start()
    {
        control = FindObjectOfType<PlayerStates>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
            Follow();
    }

    void Follow()
    {
        if (Vector2.Distance(transform.position, player.position) > distance)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                direction = new Vector2(Mathf.Sign(direction.x), 0);
            }
            else
            {
                direction = new Vector2(0, Mathf.Sign(direction.y));
            }
            transform.position = Vector2.MoveTowards(transform.position, player.position, enemySpeed * Time.deltaTime);
            animator.SetFloat("movexE", direction.x);
            animator.SetFloat("moveyE", direction.y);
            animator.SetBool("IsMoving", true);
            Debug.Log("X: " + direction.x + " Y: " + direction.y);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
    }
}

