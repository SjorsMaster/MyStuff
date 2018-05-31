using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class CollideProperty : MonoBehaviour
{

    public string LevelName;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Property")
        {
            print("Removing " + other.gameObject + "..");
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "DeadPlayer")
        {
            print("Restarting level");
            SceneManager.LoadScene(name);
            Destroy(other.gameObject);
        }
    }

}