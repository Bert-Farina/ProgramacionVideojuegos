using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controla la apertura de la puerta
public class Aperture : MonoBehaviour
{
    //Vector de movimiento para la apertura de la puerta
    Vector3 apertura;

    //Delegado que se encargará de gestionar el evento de llamada desde la ficha que abre la puerta
    public delegate void DoorDelegate();
    public static DoorDelegate doorDelegate;

    // Start is called before the first frame update
    void Start()
    {
        doorDelegate = OpenDoor;
        apertura = new Vector3(0.0f, -3.5f, 0.0f){};
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OpenDoor()
    {
        transform.position += apertura;
    }
}
