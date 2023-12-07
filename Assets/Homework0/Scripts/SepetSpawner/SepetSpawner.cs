using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SepetSpawner : MonoBehaviour
{
    public static SepetSpawner instance;

    [SerializeField] private GameObject sepet;

    [SerializeField] private Transform[] spawnPoint;

    private void Awake()
    {
        instance = this;
        Spawn();
    }

    public void Spawn()
    {
        int index = Random.Range(0, spawnPoint.Length);

        Instantiate(sepet, spawnPoint[index].position, Quaternion.identity);
    }
}
