using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownScript : MonoBehaviour {

    public int MoveTime = 0;
    private int Timer = 0;
    public float Speed = 0;
                             
    void Update ()
    {
        Timer++;


        if (Timer <= MoveTime){
            transform.position += Vector3.down * Speed * Time.deltaTime;
        }

        else{
        }

    }
}
