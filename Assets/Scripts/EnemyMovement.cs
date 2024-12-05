using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   // Start is called before the first frame update2

    Transform ubicacion_jugador;
    Distance_between_objs auxDistancia;

    void Awake(){
        ubicacion_jugador = GameObject.Find("PatoPLAYER").GetComponent<Transform>();
    }//awake se inicializa antes de los objetos
    void Start()
    {
        auxDistancia = GetComponent<Distance_between_objs>();
    }

    // Update is called once per frame
    void Update()
    {   
        float distancia_a_jugador = auxDistancia.distance;
        if(distancia_a_jugador<7.0f && distancia_a_jugador> 1.7f){
        float velocidad = 10f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, ubicacion_jugador.position, velocidad);
        }
    }
}
