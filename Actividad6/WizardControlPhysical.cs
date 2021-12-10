using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WizardControlPhysical : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    Rigidbody2D rb2D;
    float moveSpeed, dirX, maxSpeed;
    Vector2 movement;
    public CinemachineImpulseSource impulseSource;

    private void Start() 
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
        moveSpeed = 3.0f;
        maxSpeed = 20.0f;
        Physics2D.IgnoreLayerCollision(6,3);
    }

    private void Update() 
    {
        //Movimiento según las flechas de dirección
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dirX = -1.0f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                dirX = 1.0f;
            }
            else
            {
                dirX = 0.0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dirX = 1.0f;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                dirX = -1.0f;
            }
            else
            {
                dirX = 0.0f;
            }
        }

        //dirX = Input.GetAxis("Horizontal");
        movement = new Vector2(dirX, 0.0f);

        //Comprobar en que dirección se mueve para hacer un flip del sprite
        if(dirX > 0)
        {
            rend.flipX = false;
        }
        else if (dirX < 0)
        {
            rend.flipX = true;
        }

        //Activar o desactivar la animación de caminar
        if((dirX != 0) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("isWizardWalking", true);
        }
        else
        {
            anim.SetBool("isWizardWalking", false);
        }

        //Activar la animación de atacar
        if(Input.GetKeyDown(KeyCode.G) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("isWizardWalking", false);
            anim.SetTrigger("WizardAttack");
            impulseSource.GenerateImpulse();
        }
    }

    private void FixedUpdate() 
    {
        if(moveSpeed <= 3.0f)
        {
            rb2D.MovePosition(rb2D.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else if(moveSpeed > 3.0 && moveSpeed <= maxSpeed)
        {
            moveSpeed = 0.9f * moveSpeed;
            rb2D.MovePosition(rb2D.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
