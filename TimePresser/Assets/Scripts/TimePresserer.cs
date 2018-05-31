using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePresserer : MonoBehaviour
{
    bool CanIPressIt;
    bool Failed;
    int Score = 0;
    bool Pressed;
    public GameObject prefab;
    public Text ScoreText;
    public Text DeathText;
    public bool Remove;
    public Text Failer;
    public Text Scorer;
    public Text Timing;
    public Text Position;
    public Text Logs;
    public Text highScore;
    public Text congrats;
    public bool DebugMenu;
    public AudioSource Time;
    public AudioSource NoTime;
    public AudioSource Die;
    public AudioSource Point;
    public AudioSource HighScorere;
    public bool GotScore;
    public GameObject Fireworks;

    void Start()
    {
        highScore.text = "HighScore: " +PlayerPrefs.GetInt("HighScore", 0).ToString();
        ScoreText.text = "" + Score;
        DeathText.text = "";
        if (DebugMenu)
        {
            Position.text = "Position: " + new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Failer.text = "Failed: " + Failed;
            Scorer.text = "Score: " + Score;
            Logs.text = "Logs: None";
            Timing.text = "Timing: " + CanIPressIt;

        }
    }

    void Update()
    {
        if (DebugMenu)
        {
            Position.text = "Position: " + new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown("`"))
        {
            Failer.text = "Failed: " + Failed;
            congrats.text = "Cleared highscores";
            highScore.text = "Cleared highscores";
            PlayerPrefs.DeleteKey("HighScore");
            DebugMenu = true;
        }
        if (!Failed)
        {
            if (Input.anyKeyDown && CanIPressIt)
            {
                if (DebugMenu)
                {
                    Logs.text = "Logs: Button pressed";
                }
                Pressed = true;
            }
            if (Input.anyKeyDown && !CanIPressIt)
            {
                if (DebugMenu)
                {
                    Logs.text = "Logs: Button pressed";
                }
                LatePress();
            }
        }
    }

    void LatePress()
    {
        
        Failed = true;
        if (DebugMenu)
        {
            Logs.text = "Logs: Player died";
            Failer.text = "Failed: " + Failed;
        }
        Die.Play();
        DeathText.text = "You Died, Press R to restart.";
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TimeToPress")
        {
            
            CanIPressIt = true;
            Time.Play();
            if (DebugMenu)
            {
                Logs.text = "Logs: Collision found with " + other.gameObject.tag;
                Timing.text = "Timing: " + CanIPressIt;
            }
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TimeToPress")
        {
            
            CanIPressIt = false;
            if (DebugMenu)
            {
                NoTime.Play();
                Logs.text = "Logs: Collision lost with " + other.gameObject.tag;
                Timing.text = "Timing: " + CanIPressIt;
            }
        }
        if (Pressed)
        {
            if (Remove)
            {
                Destroy(other.gameObject);
            }
            
            Point.Play();
            Score++;
            if (Score > PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", Score);
                highScore.text = "HighScore: " + Score;
                if (!GotScore)
                {
                    GotScore = true;
                    congrats.text = "Cool! A new HighScore! Congratulations!";
                    HighScorere.Play();
                    Instantiate(Fireworks, new Vector3(0, 0, 0), Quaternion.identity);
                }

            }
            ScoreText.text = "" + Score;
            if (DebugMenu)
            {
                Scorer.text = "Score: " + Score;
                Logs.text = "Logs: Adding score";
            }
            Pressed = false;
        }
    }
}