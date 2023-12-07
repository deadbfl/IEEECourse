using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        float tempSpeed = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, tempSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -tempSpeed);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(tempSpeed, 0, 0);
        }
        else if(Input.GetKey(KeyCode.A)) 
        {
            transform.position += new Vector3(-tempSpeed, 0, 0);
        }
    }
}
