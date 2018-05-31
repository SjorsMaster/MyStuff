using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionScript : MonoBehaviour
{

    public float x;
    public float y;
    public float z;

    public float Speed;

    void Update()
    {

            transform.Translate(new Vector3(x, y, z) * Speed * Time.deltaTime);

    }
}
