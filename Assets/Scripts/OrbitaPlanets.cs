using UnityEngine;

public class OrbitaPlanets : MonoBehaviour
{
    public Transform sun; // Referencia al objeto Sol
    public float orbitSpeed = 1.0f; // Velocidad de órbita

    void Start()
    {
        // Encuentra el objeto con la etiqueta "Sun"
        sun = GameObject.FindGameObjectWithTag("Sun").transform;
    }

    void Update()
    {
        // Rotar alrededor del Sol
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
