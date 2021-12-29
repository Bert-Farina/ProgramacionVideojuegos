using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    private float startTime;
    private float spawnTime;
    private float spawnOffset = 2.0f;
    GameObject cameraComp;
    private float cameraXNow, cameraXBefore;

    private void Start()
    {
        cameraComp = GameObject.Find("RogueCam");
        cameraXBefore = cameraComp.transform.position.x;
        objectPooler = ObjectPooler.SharedInstance;
        startTime = Time.time;
        spawnTime = Random.Range(1.0f, 5.0f);
    }

    private void Update()
    {
        if ((Time.time - startTime) > spawnTime)
        {
            float offset = Random.Range(-spawnOffset, spawnOffset);
            Vector3 offsetVector = new Vector3(0.0f, offset, 0.0f);

            if ((Random.Range(1, 10) % 2) == 0)
            {
                ObjectPooler.SharedInstance.SpawnFromPool("Chair", transform.position + offsetVector);
            }
            else
            {
                ObjectPooler.SharedInstance.SpawnFromPool("Table", transform.position + offsetVector);
            }
            startTime = Time.time;
            spawnTime = Random.Range(1.0f, 5.0f);
        }

        cameraXNow = cameraComp.transform.position.x;
        if (cameraXNow != cameraXBefore)
        {
            Vector3 offset = new Vector3((cameraXNow - cameraXBefore), 0.0f, 0.0f);
            this.transform.position += offset;
            cameraXBefore = cameraXNow;
        }
    }
}
