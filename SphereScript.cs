using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]

public class SphereScript : MonoBehaviour
{
    private Renderer r;
    private ParticleSystem psystem;
    public int frameCounter;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        
        psystem = GetComponent<ParticleSystem>();
        psystem.Stop();

        frameCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ThirdPersonController")
        {
            col.gameObject.transform.position = new Vector3 (0, -0.787f, -5.89f);
            r.material.color = Color.red;
            psystem.Play();
        }       
    }
}
