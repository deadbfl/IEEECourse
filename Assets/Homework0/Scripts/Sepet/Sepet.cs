
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sepet : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(gameObject);
        SepetSpawner.instance.Spawn();
    }
}
