using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnThreshold = 1f;
    

    private float spawnTimer = 0;

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();
        }
    }

    private void SpawnCube()
    {                                        //Random range berekenen tussen variabelen
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                         /*Object, positie, Rotatie*/
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);

        spawnTimer = 0;
    }
}
