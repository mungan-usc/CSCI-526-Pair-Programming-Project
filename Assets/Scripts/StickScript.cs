using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class StickToPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SPlatform")
        {
            // Disable the Rigidbody2D to stop the box from moving
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.zero; // Stop the box's movement
                rb.isKinematic = false; // Disable physics interactions
            }
        }
    }
}

