using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;
    bool moved = false;

    private void Update()
    {

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        
        if (Input.GetKeyDown("right") && !moved)
        {            
            transform.Translate(new Vector3(x + 1, y, z) * speed * Time.deltaTime);
            moved = true;
        }
        if (Input.GetKeyUp("right"))
        {
            moved = false;
        }
    }
}
