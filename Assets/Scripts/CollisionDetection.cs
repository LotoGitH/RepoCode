using System;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Coin")  
        {
            Destroy(other.gameObject);
        }
    }
}
