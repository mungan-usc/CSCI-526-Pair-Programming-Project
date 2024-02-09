using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class VanishingPlatform : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DisablePlatform());
        }
    }

    System.Collections.IEnumerator DisablePlatform()
    {
        yield return new WaitForSeconds(1f);
        
        gameObject.SetActive(false); // Deactivates the platform entirely
    }
}

