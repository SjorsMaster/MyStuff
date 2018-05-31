using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Destroy(gameObject);
        }
    }
}