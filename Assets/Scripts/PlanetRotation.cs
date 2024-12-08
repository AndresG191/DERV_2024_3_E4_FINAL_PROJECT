using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    // Velocidad de rotación pública
    public float vel_rot;
    private Rigidbody rig;

    // Método Awake se llama antes de Start
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Start()
    {
        // Desactivar la fricción angular para mantener la velocidad constante
        rig.angularDrag = 0;
        
        // Solo asignamos la velocidad angular en el eje Y
        Vector3 angularVelocity = new Vector3(0, vel_rot, 0);
        rig.angularVelocity = angularVelocity;
    }
}

