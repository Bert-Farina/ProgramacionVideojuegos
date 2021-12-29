using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("El objeto " + gameObject.name + " ha colisionado con " + other.gameObject.name + ".");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("El objeto " + gameObject.name + " ha disparado a " + other.gameObject.name + ".");
    }
}
