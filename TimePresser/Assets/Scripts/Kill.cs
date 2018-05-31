using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour
{
    public float lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}