using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance_between_objs : MonoBehaviour
{
   
    Transform obj_a_calc_distance;
    public float distance;
    

    private void Awake(){
        obj_a_calc_distance = GameObject.Find("PatoPLAYER").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
     Distance_between_objs auxDistancia = GetComponent<Distance_between_objs>();   
    }

    // Update is called once per frame
    void Update()
    {
        
        distance = Vector3.Distance(obj_a_calc_distance.position,
        transform.position);
        Debug.Log("Distancia: "+distance);
    }
}