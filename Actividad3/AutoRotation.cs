using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Auto rotación para la ficha que abre la puerta
public class AutoRotation : MonoBehaviour
{
    float degreesPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        degreesPerSecond = 45.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, degreesPerSecond * Time.deltaTime, Space.World);
    }
}
