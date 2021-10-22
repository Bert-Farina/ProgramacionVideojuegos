using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Declaración de variables
    private float m_speed;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        m_speed = 2;
        scaleChange = new Vector3(0.0f, 0.25f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Si se acerca a alguno de los dos limites del plano cambia de dirección
        if (transform.position.x < -12)
        {
            m_speed = -m_speed;
        } 
        else if (transform.position.x > 13.5)
        {
            m_speed = -m_speed;
        }

        //Función de movimiento
        transform.Translate(Vector3.right * Time.deltaTime * m_speed);
    }

    private void OnCollisionEnter(Collision col) 
    {
        //Si se choca con Ethan
        if (col.gameObject.name == "Ethan")
        {
            //Se obtiene el valor power de Ethan
            EthanScript ethanScript = col.gameObject.GetComponent<EthanScript>();  

            //Se cambia la dirección y se aumenta su velocidad el poder de Ethan
            if (m_speed < 0)
            {
                m_speed = m_speed - ethanScript.power;
                m_speed = -m_speed;
            }
            else if (m_speed > 0)
            {
                m_speed = m_speed + ethanScript.power;
                m_speed = -m_speed;
            }

            //Se aumenta el poder de Ethan
            ethanScript.power++;

            //Si el objeto tiene 0.25 o menos en su escala "y" se elimina, y si no, se restan 0.25f
            if (transform.localScale.y <= 0.25f)
            {
                Destroy(gameObject);
            }
            else
            {
                transform.localScale -= scaleChange;
            }        
        }
    }
}
