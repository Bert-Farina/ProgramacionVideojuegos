using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed;
    private Renderer _renderer;
    private Vector2 savedOffset;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, 0);
        _renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
