using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMouse : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivty = 2f;
    float cameraVerticalRotation = 0f;

    bool esconderCursor = true;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;   
    }

    // Update is called once per frame
    void Update()
    {
            //ROTAR DE ARRIBA HACIA ABAJO
        float inputX = Input.GetAxis("Mouse X")*mouseSensitivty;
        float inputY = Input.GetAxis("Mouse Y")*mouseSensitivty;

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation =Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles= Vector3.right*cameraVerticalRotation;

        //ROTAR DE IZQUIERDA A DERECHA
        player.Rotate(Vector3.up* inputX);
    }
}
