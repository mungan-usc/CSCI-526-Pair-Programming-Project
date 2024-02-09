using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingPlatform : MonoBehaviour
{
    private float speed = 2f;
    private float range = 7.5f; 

    private Vector2 startPosition;
    private float movementFactor;

    void Start()
    {
        startPosition = transform.position; 
    }

    void Update()
    {
        movementFactor = Mathf.Sin(Time.time * speed) * range;
 
        transform.position = new Vector2(startPosition.x, startPosition.y + movementFactor);
    }
}
