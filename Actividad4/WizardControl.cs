using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardControl : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    GameObject rogue;
    Animator rogueAnimator;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        rend.flipX = true;

        rogue = GameObject.Find("Rogue");
        rogueAnimator = GameObject.Find("Rogue").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(rogue.transform.position, transform.position);

        if (Input.GetKeyDown(KeyCode.X) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Wizard-Attack"))
        {
            anim.SetTrigger("wizardAttack");
        }

        if (distance < 1.5f && !anim.GetCurrentAnimatorStateInfo(0).IsName("Wizard-Death") && rogueAnimator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetTrigger("death");
        }
    }
}
