using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed;
    private Renderer _renderer;
    private Vector2 savedOffset;
    GameObject cameraComp;
    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        cameraComp = GameObject.Find("RogueCam");
        Debug.Log(this.transform.position);
        Debug.Log(cameraComp.transform.position);
    }

    void Update()
    {
        if(cameraComp.transform.position.x > (transform.position.x + sr.bounds.size.x))
        {
            this.transform.position = this.transform.position + new Vector3(sr.bounds.size.x * 2, 0, 0);
        }
        else if(cameraComp.transform.position.x < (transform.position.x - sr.bounds.size.x))
        {
            this.transform.position = this.transform.position - new Vector3(sr.bounds.size.x * 2, 0, 0);
        }
    }
}
