using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float parallaxEffect;
    GameObject cameraComp;
    SpriteRenderer sr;
    private float length, startpos;

    void Start()
    {
        startpos = transform.position.x;
        sr = GetComponent<SpriteRenderer>();
        length = sr.bounds.size.x;
        cameraComp = GameObject.Find("RogueCam");
    }

    void Update()
    {
        float temp = cameraComp.transform.position.x * (1 - parallaxEffect);
        float dist = cameraComp.transform.position.x * parallaxEffect;

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if(temp > (startpos + length))
        {
            startpos += length;
        }
        else if(temp < (startpos - length))
        {
            startpos -= length;
        }
    }
}
