using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiggleScript : MonoBehaviour
{
    [SerializeField] bool wiggle, rotate;
    Vector2 startpos;
    private void Start()
    {
        startpos = transform.position;
    }
    void Update()
    {
        if (rotate)
            transform.Rotate(new Vector3(0, 0, Mathf.Sin(Time.time)));
        if (wiggle)
            transform.position = new Vector2(startpos.x + Random.Range(-1, 1), startpos.y + Random.Range(-1, 1));
    }
}
