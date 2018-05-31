using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Collide : MonoBehaviour
{
    public Text uiText;
    public int Lives = 3;

    private void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            print("hit");
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        Lives--;
        UpdateUI();
        if (Lives <= 0){
            print("Game over");
        }
    }

    private void UpdateUI()
    {
        uiText.text = "Lives: " + Lives.ToString();
    }


}