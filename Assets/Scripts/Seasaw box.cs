using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeesawEffect : MonoBehaviour
{
    public Rigidbody2D boxRigidbody;
    public float upwardForce = 500f; // Force to apply upwards
    public float forwardForce = 200f; // Force to apply forwards

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure your player has a tag "Player"
        {
            // Calculate the direction of the force to achieve a parabolic trajectory
            Vector2 forceDirection = new Vector2(forwardForce, upwardForce);

            // Apply the force to the box Rigidbody
            boxRigidbody.AddForce(forceDirection);
        }
    }
}


