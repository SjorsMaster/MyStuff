using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public Rigidbody Shot;
    public float Speed;
    public float LiveTimer;

    void Update () {
        Shot.velocity = transform.forward * Speed;
        StartCoroutine(DeathSoon());
    }

    IEnumerator DeathSoon()
    {
        yield return new WaitForSeconds(LiveTimer);
        Destroy(this.gameObject);
    }
}
