using System;
using NUnit.Framework;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package"))
        {
            Debug.Log("Picked up a package");
            hasPackage = true;
        }
        if(collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered a package");
            hasPackage = false;
        }
    }
}
