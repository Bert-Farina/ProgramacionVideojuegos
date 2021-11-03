using System;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonMoveWithArrows : MonoBehaviour
{
    //Variables para el movimiento
    public float speed = 5;

    CharacterController controller;
    public int lifes;
    public bool fastModeActivated;

    //Variable para mostrar el texto
    private Text arrowLifesText;
     
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        lifes = 3;
        fastModeActivated = false;

        arrowLifesText = GameObject.Find("ArrowLifes").GetComponent<Text>();
        arrowLifesText.text = lifes.ToString();
    }

    //Configuración del movimiento con las flechas del teclado
    private void Update()
    {
        Vector3 temp = Vector3.zero;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            temp += Vector3.right * -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            temp += Vector3.right;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            temp += Vector3.forward * -1;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            temp += Vector3.forward;
        }

        Vector3 velocity = temp * speed;

        controller.Move(velocity * Time.deltaTime);
    }
}
