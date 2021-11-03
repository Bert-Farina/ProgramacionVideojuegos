using System;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonMoveWithWASD : MonoBehaviour
{
    //Variables de movimiento
    public float speed = 5;

    CharacterController controller;
    public int lifes;
    public bool fastModeActivated;

    //Variable para mostrar el texto
    private Text wasdLifesText;
      
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        lifes = 3;
        fastModeActivated = false;

        wasdLifesText = GameObject.Find("WASDLifes").GetComponent<Text>();
        wasdLifesText.text = "3";
    }

    //Configuración del movimiento con las teclas WASD
    private void Update()
    {
        Vector3 temp = Vector3.zero;

        if(Input.GetKey(KeyCode.A))
        {
            temp += Vector3.right * -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            temp += Vector3.right;
        }

        if(Input.GetKey(KeyCode.S))
        {
            temp += Vector3.forward * -1;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            temp += Vector3.forward;
        }

        Vector3 velocity = temp * speed;

        controller.Move(velocity * Time.deltaTime);
    }

}
