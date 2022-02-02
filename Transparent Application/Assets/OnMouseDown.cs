using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown : MonoBehaviour
{
    bool go = true;
    void Update()
    {
        if (go)
        {
            transform.position = Vector2.Lerp(transform.position, Input.mousePosition, .05f);

        }

        if (Input.GetKeyDown("`"))
        {
            go = !go;
        }

    }
}
