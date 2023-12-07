using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectApple : MonoBehaviour
{
    [SerializeField] private TMP_Text appleCountText;
    private int appleCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            //print("Elma girdi");
            appleCount++;
            appleCountText.SetText("Elma Sayisi : " + appleCount);
            Destroy(other.gameObject);
            //print("Elma Sayisi : " + appleCount);
        }
    }
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Apple"))
    //    {
    //        print("Elma temas halinde");
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Apple"))
    //    {
    //        print("Elmaya cikti");
    //    }
    //}
}
