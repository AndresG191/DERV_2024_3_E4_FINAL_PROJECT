using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float velocidad_rotacion;
    [SerializeField] float velocidad_movimiento;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Calcular la velocidad de movimiento
        float velocidad = 0f;

        // Arriba - Abajo
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
            velocidad = velocidad_movimiento; // El jugador se mueve hacia adelante
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.forward;
            velocidad = velocidad_movimiento; // El jugador se mueve hacia atrás
        }

        // Izquierda - Derecha
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.right;
            velocidad = velocidad_movimiento; // El jugador se mueve hacia la izquierda
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += velocidad_movimiento * Time.deltaTime * transform.right;
            velocidad = velocidad_movimiento; // El jugador se mueve hacia la derecha
        }

        // Rotar izquierda - Rotar derecha
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, velocidad_rotacion * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -1 * velocidad_rotacion * Time.deltaTime, 0);
        }

        // Animaciones
        if (velocidad == 0)
        {
            // Idle cuando la velocidad es 0
            animator.SetFloat("Speed", 0);
        }
        else
        {
            // Run cuando la velocidad es mayor que 0
            animator.SetFloat("Speed", velocidad);
        }
    }
}
