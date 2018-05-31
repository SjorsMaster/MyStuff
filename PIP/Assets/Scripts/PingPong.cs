using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PingPong : MonoBehaviour
    {
        public Vector3 pos1 = new Vector3(-4, 0, 0); //Positie 1 aangeven
        public Vector3 pos2 = new Vector3(4, 0, 0); // Positie 2 aangeven
        public float speed = 1.0f; // Snelheid aangeven

        void Update()
        {
            transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        }
    }
