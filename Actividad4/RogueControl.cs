using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueControl : MonoBehaviour
{
    float dirX, moveSpeed;
    Animator anim;
    SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + dirX, transform.position.y);

        //Activar o desactivar la animación de caminar
        if(dirX != 0 && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
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

        if(Input.GetKeyDown(KeyCode.Space) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("isWalking", false);
            anim.SetTrigger("attack");
        }
    }
}
