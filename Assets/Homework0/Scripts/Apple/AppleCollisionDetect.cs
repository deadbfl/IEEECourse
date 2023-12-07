using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCollisionDetect : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sepet"))
        {
            ScoreManager.instance.IncreaseScore();
            collision.gameObject.GetComponent<Sepet>().Destroy();   
        }
        else
        {
            HWHealthManager.instance.DecreaseHealth();
        }

        Destroy(gameObject);
    }
}
