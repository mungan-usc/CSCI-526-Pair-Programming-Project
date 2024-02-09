using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    public GameObject platformToAppear;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SBOX")) 
        {

            platformToAppear.SetActive(true);
            platformToAppear.GetComponent<SpriteRenderer>().enabled = true;
            platformToAppear.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
