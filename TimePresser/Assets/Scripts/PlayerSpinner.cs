using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSpinner : MonoBehaviour {

    public float speed = 10f;
    public float addSpeed = 0.1f;
    private int MOVE;
    public string SceneName;
    public Text Speed;
    public Text Acceleration;
    public Text Logs;
    public bool DebugMenu;

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneName = scene.name;
        if (DebugMenu)
        {
            Logs.text = "Logs: Current scene is: " + scene.name;
            Speed.text = "Speed: " + speed;
            Acceleration.text = "AccelerationSpeed: " + addSpeed;
        }
    }

    void Update ()
    {
        if (Input.GetKeyDown("`"))
        {
            DebugMenu = true;
            Logs.text = "Debug menu is active";
        }
        if (DebugMenu)
        {
            Speed.text = "Speed: " + speed;
            Acceleration.text = "AccelerationSpeed: " + addSpeed;
        }

        if (Input.anyKeyDown && speed >= 0 && MOVE == 0)
        {
            speed = speed + addSpeed;
            speed = -speed;
            if (DebugMenu)
            {
                Logs.text = "Logs: NewSpeed =" + speed;
            }
            MOVE++;
        }
        if (Input.anyKeyDown && speed <= 0 && MOVE == 0)
        {
            speed = speed - addSpeed;
            speed = -speed;
            if (DebugMenu)
            {
                Logs.text = "Logs: NewSpeed =" + speed;
            }
            MOVE++;
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneName);
        }
        MOVE = 0;


        transform.Rotate(Vector3.up, speed * Time.deltaTime);	
	}
}
