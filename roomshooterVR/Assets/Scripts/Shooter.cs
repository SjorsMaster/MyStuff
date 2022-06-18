using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public GameObject Bullet;
    void Update() {

        if (Input.GetKeyDown("space"))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            Debug.Log("Shot");
        } }
}
