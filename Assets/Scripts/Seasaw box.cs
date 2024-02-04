using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeesawEffect : MonoBehaviour
{
    public Rigidbody2D boxRigidbody;
    public float upwardForce = 500f; 
    public float forwardForce = 200f; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {

            Vector2 forceDirection = new Vector2(forwardForce, upwardForce);


            boxRigidbody.AddForce(forceDirection);
        }
    }
}


