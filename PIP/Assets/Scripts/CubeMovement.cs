using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float Speed;
    public bool Dead;
    public GameObject cubePrefab;
    public float lifetime = 0;

    private void Start()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        Debug.Log("STARTING POS: X:" + x + " Y:" + y + " Z:" + z);
    }

    private void Update()
    {
        
        if(Input.GetKeyDown("right")){
            transform.Translate(new Vector3(1, 0, 0) * Speed);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Speed);
        }
        if (Input.GetKeyDown("up"))
        {
            transform.Translate(new Vector3(0, 0, 1) * Speed);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.Translate(new Vector3(0, 0, -1) * Speed);
        }
        if (Dead)
        {
            Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
            Destroy(gameObject, lifetime);
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Death")
        {
            Dead = true;
        }
    }

}
