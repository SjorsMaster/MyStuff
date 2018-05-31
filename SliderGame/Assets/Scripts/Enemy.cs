using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool TrueIsZFalseIsX;
    public float Speed;
    public bool Logs;

    // Use this for initialization
    void Start()
    {
        
        if (Logs)
        {
            Debug.Log("Enemy script is up and running.");
            if (TrueIsZFalseIsX)
            {
                Debug.Log("X is selected.");
            }
            else
            {
                Debug.Log("Z is selected.");
            }
        }
        if (Speed == 0)
        {
            if (Logs)
            {
                Debug.Log("Speed is equal to 0, Setting speed to 1.");
                if (TrueIsZFalseIsX)
                {
                    Debug.Log("X is selected.");
                }
                else
                {
                    Debug.Log("Z is selected.");
                }
            }
            Speed = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (TrueIsZFalseIsX)
        {
            transform.position += Vector3.forward * Speed * Time.deltaTime;
        }
        if (!TrueIsZFalseIsX)
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (Logs)
            {
                Debug.Log("Collision with: " + other.gameObject.tag + "!\nSwitching from " + Speed + " to " + -Speed + ".");
            }
            Speed = -Speed;
        }
    }
}
