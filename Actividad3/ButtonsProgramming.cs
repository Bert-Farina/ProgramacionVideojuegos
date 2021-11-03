using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsProgramming : MonoBehaviour
{
    //Variables para almacenar las clases de los jugadores
    private ThirdPersonMoveWithWASD wasdComponent;
    private ThirdPersonMoveWithArrows arrowsComponent;

    //Variables para mostrar las vidas por pantalla
    public Text wasdLifesText;
    public Text arrowLifesText;


    // Start is called before the first frame update
    void Start()
    {
        wasdComponent = GameObject.Find("CapsuleWASDMoved").gameObject.GetComponent<ThirdPersonMoveWithWASD>();
        arrowsComponent = GameObject.Find("CapsuleArrowMoved").gameObject.GetComponent<ThirdPersonMoveWithArrows>();

        wasdLifesText = GameObject.Find("WASDLifes").GetComponent<Text>();
        arrowLifesText = GameObject.Find("ArrowLifes").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Función para el botón que activa el fast mode
    public void FastModeButton()
    {
        //Si ya está activado el fast mode muestra un mensaje por consola
        if(wasdComponent.fastModeActivated && arrowsComponent.fastModeActivated)
        {
            Debug.Log("Fast Mode already activated;");
        }
        else
        {
            //Comprueba que tenga todas las vidas para pasar a fast mode, 
            //porque si ya ha perdido una vida el juego se considera empezado y no puede cambiar de modo
            if(wasdComponent.lifes == 3 && arrowsComponent.lifes == 3)
            {
                wasdComponent.lifes = 2;
                wasdComponent.speed = 8;
                arrowsComponent.lifes = 2;
                arrowsComponent.speed = 8;

                //Se cambia el booleano de fast mode a true
                arrowsComponent.fastModeActivated = true;
                wasdComponent.fastModeActivated = true;
                
                //Se actualizan las vidas en la interfaz
                wasdLifesText.text = wasdComponent.lifes.ToString();
                arrowLifesText.text = arrowsComponent.lifes.ToString();
            }
            else
            {
                //En caso de que haya perdido una vida ya, se muestra un mensaje por consola
                Debug.Log("You already lost at least a life, try activating Fast Mode when having 3 lifes.");
            }
        }
    }

    //Función para activar el modo normal
    public void NormalModeButton()
    {
        //Si ya está activado el normal mode muestra un mensaje por consola
        if(!wasdComponent.fastModeActivated && !arrowsComponent.fastModeActivated)
        {
            Debug.Log("Normal Mode already activated;");
        }
        else
        {
            //Comprueba que tenga todas las vidas para pasar a normal mode, 
            //porque si ya ha perdido una vida el juego se considera empezado y no puede cambiar de modo
            if(wasdComponent.lifes == 2 && arrowsComponent.lifes == 2)
            {
                wasdComponent.lifes = 3;
                wasdComponent.speed = 5;
                arrowsComponent.lifes = 3;
                arrowsComponent.speed = 5;

                //Se cambia el booleano de fast mode a true
                arrowsComponent.fastModeActivated = false;
                wasdComponent.fastModeActivated = false;

                //Se actualizan las vidas en la interfaz
                wasdLifesText.text = wasdComponent.lifes.ToString();
                arrowLifesText.text = arrowsComponent.lifes.ToString();
            }
            else
            {
                //En caso de que haya perdido una vida ya, se muestra un mensaje por consola
                Debug.Log("You already lost at least a life, try activating Normal Mode when having 2 lifes.");
            }
        }
    }
}
