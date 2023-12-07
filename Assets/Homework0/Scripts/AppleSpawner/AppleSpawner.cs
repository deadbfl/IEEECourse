using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;

    [SerializeField] private GameObject appleGameObject;

    private bool canSpawn = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canSpawn)
        {
            Instantiate(applePrefab, transform.position, Quaternion.identity);

            StartCoroutine(AppleSet(1));
        }
    }

    private IEnumerator AppleSet(float delay)
    {
        appleGameObject.SetActive(false);
        canSpawn = false;

        yield return new WaitForSeconds(delay);

        canSpawn = true;
        appleGameObject.SetActive(true);
    }
}
