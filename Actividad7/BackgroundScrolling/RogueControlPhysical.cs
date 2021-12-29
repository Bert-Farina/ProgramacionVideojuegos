using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueControlPhysical : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    Rigidbody2D rb2D;
    float moveSpeed, dirX, dirY = 0.0f, maxSpeed;
    Vector2 movement;
    
    //Variables para control de tiempo de salto
    private float startTime;
    private float jumpTime = 0.7f;

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
        //Movimiento según las teclas WASD
        if (Input.GetKeyDown(KeyCode.A))
        {
            dirX = -3.5f;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.D))
            {
                dirX = 3.5f;
            }
            else
            {
                dirX = 0.0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            dirX = 3.5f;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.A))
            {
                dirX = -3.5f;
            }
            else
            {
                dirX = 0.0f;
            }
        }

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
        /*if((dirX != 0) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }*/

        //Activar la animación de atacar
        /*if(Input.GetKeyDown(KeyCode.F) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("isWalking", false);
            anim.SetTrigger("attack");
        }*/

        if(Input.GetKeyDown(KeyCode.Space))
        {
            dirY = 2.5f;
            startTime = Time.time;
            anim.SetBool("isWalking", false);
        }
        else if(Input.GetKeyUp(KeyCode.Space) || (Time.time - startTime) > jumpTime)
        {
            dirY = -1.5f;
            anim.SetBool("isWalking", true);
        }
    
        //dirX = Input.GetAxis("Horizontal");
        movement = new Vector2(dirX, dirY);
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
