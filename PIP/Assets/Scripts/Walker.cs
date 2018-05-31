using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour {

    public float speed = 0f;
    
    void Update () {
        transform.Rotate(Vector3.down, speed * Time.deltaTime);
     }
}
