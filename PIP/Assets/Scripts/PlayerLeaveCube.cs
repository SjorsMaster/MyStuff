using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerLeaveCube : MonoBehaviour
{
    public float Speed = -3;
    public float tSpeed = 1;
    public bool Triggered = false;
    public float lifetime = 10;
    public GameObject cubePrefab;
    public int Spawner = 0;

    private void Start()
    {
        Debug.Log("'PlayerLeaveCube' is active.");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Triggered = true;
            Spawn();
        }        
    }

    private void Update()
    {
        if (Triggered)
        {
            Speed++;
            transform.position += Vector3.down * Speed / tSpeed * Time.deltaTime;
            Destroy(gameObject, lifetime);
        }
    }
    private void Spawn()
    {
        Spawner++;
        if (Spawner == 1)
        {
            Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        }
    }
}