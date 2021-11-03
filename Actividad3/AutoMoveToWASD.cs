using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Gestionar el movimiento del objecto que se mueve hacia el jugador controlado por WASD
public class AutoMoveToWASD : MonoBehaviour
{
    //Referencia al objetivo
    GameObject objective;

    //Variables para movimiento
    float speed;
    float step;

    //Variables para mostrar las vidas por pantalla
    private Text wasdLifesText;
    private Text arrowLifesText;

    // Start is called before the first frame update
    void Start()
    {
        //Se inicializa al objetivo
        objective = GameObject.Find("CapsuleWASDMoved");

        speed = 3;
        step = 0;

        //Se buscan los objetos de texto en el canvas para relacionarlos con las variables de texto.
        wasdLifesText = GameObject.Find("WASDLifes").GetComponent<Text>();
        arrowLifesText = GameObject.Find("ArrowLifes").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gestión de la distancia para que no se solape y provoque jittering
        float distance = Vector3.Distance(transform.position, objective.transform.position);

        if (distance < 1.0f)
        {
            step = 0;
        }
        else 
        {
            step = speed * Time.deltaTime;
        }
        transform.position = Vector3.MoveTowards(transform.position, objective.transform.position, step);
    }

    void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.name == "CapsuleWASDMoved")
        {
            //Si colisiona se resta una vida, se actualiza la UI y si se llega a 0 vidas se cierra la aplicación.
            --col.gameObject.GetComponent<ThirdPersonMoveWithWASD>().lifes;
            wasdLifesText.text = col.gameObject.GetComponent<ThirdPersonMoveWithWASD>().lifes.ToString();
            if(col.gameObject.GetComponent<ThirdPersonMoveWithWASD>().lifes == 0)
            {
                Application.Quit();
            }
        }
        if (col.gameObject.name == "CapsuleArrowMoved")
        {
            //Si colisiona se resta una vida, se actualiza la UI y si se llega a 0 vidas se cierra la aplicación.
            --col.gameObject.GetComponent<ThirdPersonMoveWithArrows>().lifes;
            arrowLifesText.text = col.gameObject.GetComponent<ThirdPersonMoveWithArrows>().lifes.ToString();
            if(col.gameObject.GetComponent<ThirdPersonMoveWithArrows>().lifes == 0)
            {
                Application.Quit();
            }
        }
    }
}
