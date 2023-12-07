
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HWHealthManager : MonoBehaviour
{
    public static HWHealthManager instance;

    [SerializeField] private TMP_Text healthText;

    [SerializeField] private int health;

    private void Awake()
    {
        instance = this;

        healthText.SetText(health.ToString());
    }

    public void DecreaseHealth()
    {
        health--;

        healthText.SetText(health.ToString());

        if(health <= 0)
        {
            print("Yandin");
        }
    }
}
