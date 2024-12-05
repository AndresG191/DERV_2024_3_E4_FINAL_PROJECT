using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class LookAt : MonoBehaviour
{
   Transform posicion_obj_a_mirar; // personaje

    private void Awake(){
        posicion_obj_a_mirar = GameObject.Find("PatoPLAYER").GetComponent<Transform>();


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float val_y = posicion_obj_a_mirar.transform.position.y;
        Debug.Log(""+val_y);


        if(val_y>0.5f){
            transform.LookAt(new Vector3(
                posicion_obj_a_mirar.position.x, 0.5f, posicion_obj_a_mirar.position.z
            ));
        }else{
            transform.LookAt(posicion_obj_a_mirar);
        }
        transform.LookAt(posicion_obj_a_mirar);
    }
}
