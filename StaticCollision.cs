using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCollision : MonoBehaviour
{

    Vector3 positionChangeLeftToCenter;
    Vector3 positionChangeCenterToRight;
    Vector3 positionChangeRightToLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        positionChangeLeftToCenter = new Vector3(9.5f, 0.0f, 0.0f);
        positionChangeCenterToRight = new Vector3(8.5f, 0.0f, 0.0f);
        positionChangeRightToLeft = new Vector3(-18f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.name == "Ethan")
        {
            if (transform.position.x == -8.5f)
            {
                transform.position += positionChangeLeftToCenter;
            }
            else if (transform.position.x == 1f)
            {
                transform.position += positionChangeCenterToRight;
            }
            else if (transform.position.x == 9.5f)
            {
                transform.position += positionChangeRightToLeft;
            }
        }
    }
}
