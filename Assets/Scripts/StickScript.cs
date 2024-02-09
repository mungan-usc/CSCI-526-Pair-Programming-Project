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

            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.zero; 
                rb.isKinematic = false; 
            }
        }
    }
}

