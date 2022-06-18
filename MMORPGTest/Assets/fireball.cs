using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {
    float time;

    private void Start()
    {
        transform.rotation = GameObject.Find("player").transform.rotation;
        transform.position = GameObject.Find("player").transform.position;
    }
    void Update () {
        transform.Translate(Vector3.forward *20* Time.deltaTime);

        time += 1 * Time.deltaTime;
        if (time > 10)
        {
            Destroy(gameObject);
        }
	}
}
