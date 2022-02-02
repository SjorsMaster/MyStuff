using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
