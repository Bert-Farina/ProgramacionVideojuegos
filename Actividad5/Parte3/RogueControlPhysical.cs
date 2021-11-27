using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueControlPhysical : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    Rigidbody2D rb2D;
    float moveSpeed, dirX, maxSpeed;
    Vector2 movement;

    private void Start() 
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
        moveSpeed = 3.0f;
        maxSpeed = 20.0f;
        Physics2D.IgnoreLayerCollision(0,3);
    }

    private void Update() 
    {
        dirX = Input.GetAxis("Horizontal");
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
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        //Activar la animación de atacar
        if(Input.GetKeyDown(KeyCode.Space) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("isWalking", false);
            anim.SetTrigger("attack");
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

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Platform")
        {
            Debug.Log("Entrando al Trigger");
            moveSpeed = maxSpeed;
        }
    }
}