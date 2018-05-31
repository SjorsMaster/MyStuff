using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public Text uiText;
    public int Lives = 3;
    public bool hit;

    private void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !hit)
        {
            print("hit");
            hit = true;
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        Lives--;
        if (Lives <= 0){
            print("Game over");
            Lives = 0;
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        uiText.text = "x " + Lives.ToString();
        hit = false;
    }

}