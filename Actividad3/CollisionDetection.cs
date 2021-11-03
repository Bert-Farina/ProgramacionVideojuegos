using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    Vector3 TPVector; 
    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        //Se configura el punto de teletransporte como el punto de origen
        TPVector = new Vector3(0.0f, 1.0f, -8.0f){};
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detección de colisiones
    void OnCollisionEnter(Collision col)
    {
        //Si colisiona con el cilindro se teletransporta al punto de origen
        if (col.gameObject.name == "TeleportationCabin")
        {
            controller.enabled = false;
            transform.position = TPVector;
            controller.enabled = true;
        }
    }

    //Si colisiona con el trigger de la ficha ejecuta el delegado para abrir la puerta
    void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.name == "Ficha")
        {
            Aperture.doorDelegate();
            Destroy(col.gameObject);
        }    
    }
}
