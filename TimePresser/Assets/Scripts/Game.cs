using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    private int Time;
    public int Score;
    public bool Caught;
    private int Seconds;
    public int MaxTime;
    public bool Debugger;
    private bool StillCounting = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Caught)
        {
            Score++;
            Caught = false;
            if (Debugger)
            {
                Debug.Log("Score!");
            }
        }
        Time++;

        if (StillCounting)
        {
            if (Seconds >= MaxTime)
            {
                if (Debugger)
                {
                    Debug.Log("We have reached our time.");
                }
                StillCounting = false;
            }
            if (Time >= 60)
            {
                Time = 0;
                Seconds++;
            }
        }
	}
}
