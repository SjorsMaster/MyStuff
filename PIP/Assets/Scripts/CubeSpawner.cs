using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnThreshold = 0;

    //Variable posities
    public int var1;
    public int var2;

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
        Vector3 spawnPosition = new Vector3(Random.Range(var1, var2), 0, 0);
                         /*Object, positie, Rotatie*/
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);

        spawnTimer = 0;
    }
}
