using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    private float Speed = 0;
    public float AccelerationSpeed = 0.5f;
    private bool Moved;
    private bool Up;
    private bool Down;
    private bool Left;
    private bool Right;
    public string SceneName;
    public string NextLevel;
    public bool Logs;


    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneName = scene.name;
        Moved = false;
        if (Logs)
        {
            Debug.Log("The current scene is: " + scene.name);
            Debug.Log("Moved has been set to " + Moved);
        }
    }

    void Update ()
    {
        if (Input.GetKeyDown("r"))
        {
            if (Logs)
            {
                Debug.Log("Restarting..");
            }
            OutOfBounds();
        }
        if (!Moved)
        {
            if (Input.GetKeyDown("up"))
            {
                Up = true;
                Moved = true;
            }
            if (Input.GetKeyDown("down"))
            {
                Down = true;
                Moved = true;
            }
            if (Input.GetKeyDown("left"))
            {
                Left = true;
                Moved = true;
            }
            if (Input.GetKeyDown("right"))
            {
                Right = true;
                Moved = true;
            }
        }
        if (Up && Moved)
        {
            if (Logs)
            {
                Debug.Log("Up has been pressed.");
            }
            Speed = Speed + AccelerationSpeed;
            transform.position += Vector3.forward * Speed * Time.deltaTime;
        }
        if (Down && Moved)
        {
            if (Logs)
            {
                Debug.Log("Down has been pressed.");
            }
            Speed = Speed + AccelerationSpeed;
            transform.position += Vector3.back * Speed * Time.deltaTime;
        }
        if (Left && Moved)
        {
            if (Logs)
            {
                Debug.Log("Left has been pressed.");
            }
            Speed = Speed + AccelerationSpeed;
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }
        if (Right && Moved)
        {
            if (Logs)
            {
                Debug.Log("Right has been pressed.");
            }
            Speed = Speed + AccelerationSpeed;
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (Logs)
            {
                Debug.Log("Collision with " + other.gameObject.tag);
            }
            StopAll();
        }
        if (other.gameObject.tag == "OutOfBounds")
        {
            OutOfBounds();
        }
        if (other.gameObject.tag == "Finish")
        {
            if (Logs)
            {
                Debug.Log("Player wins! Up to level: " + NextLevel);
            }
            SceneManager.LoadScene(NextLevel);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "OutOfBounds")
        {
            OutOfBounds();
        }
    }

    void OutOfBounds()
    {
        if (Logs)
        {
            Debug.Log("Out of bounds function triggered. \n RESTARTING LEVEL: " + SceneName);
        }
        SceneManager.LoadScene(SceneName);
    }

    void StopAll()
    {
        Speed = 0;
        Moved = false;
        Up = false;
        Down = false;
        Left = false;
        Right = false;
        if (Logs)
        {
            Debug.Log("Directions, Moved, And Speed have been reset.");
        }
    }
}
