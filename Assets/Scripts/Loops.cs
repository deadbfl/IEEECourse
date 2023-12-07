using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int sayi = 5;
    public int can = 10;

    public int artisMiktari = 2;
    // Start is called before the first frame update
    void Start()
    {
        //if(can != 10)
        //{
        //    print("On'a esit degil");
        //}

        if(can % 10 == 3)
        {
            print("Test");
        }

        for (int i = 0; i < sayi; i += artisMiktari)
        {
            print(i);
        }

        //while (can > 0)
        //{
        //    print("Can Degeri : " + can);
        //    can --;
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
}
