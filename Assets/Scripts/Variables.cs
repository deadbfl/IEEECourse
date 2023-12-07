using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int age;
    public float chance;
    public string isim;
    public bool isMale;

    // Start is called before the first frame update
    void Start()
    {
        print("YAS : " + age);
        print("Sans : " + chance);
        print("ISIM : " +  isim);

        if(isMale == true)
        {
            print("Erkek");

        }
        else if(isMale == false)
        {
            print("Kadin");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
