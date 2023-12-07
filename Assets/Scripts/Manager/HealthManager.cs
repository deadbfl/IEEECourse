using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;

    [SerializeField] private int health;

    private void Awake()
    {
        instance = this;
    }

    public void DecreaseHealth()
    {
        if (health > 0)
        {
            health--;
        }
        else
        {
            print("Yandin");
        }
            print("Can : " + health);
    }
}
