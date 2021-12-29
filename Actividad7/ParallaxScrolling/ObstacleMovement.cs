using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour, IPooledObject
{
    public float baseSpeed = 5.0f;
    public float speedOffset = 3.0f;
    private float speed;

    public void OnObjectSpawn()
    {
        speed = Random.Range(baseSpeed - speedOffset, baseSpeed + speedOffset);

        this.transform.Translate(new Vector2(-1.0f, 0.0f) * baseSpeed * Time.deltaTime, Space.World);
    }

    private void LateUpdate()
    {
        this.transform.Translate(new Vector2(-1.0f, 0.0f) * speed * Time.deltaTime, Space.World);
    }
}
