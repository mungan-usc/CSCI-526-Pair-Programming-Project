using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    public float speed = 2f; // Speed of the saw's movement
    public float range = 2f; // Range of vertical movement

    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate vertical movement using a sine wave
        float verticalMovement = Mathf.Sin(Time.time * speed) * range;

        // Set the new position of the saw
        transform.position = initialPosition + new Vector3(0f, verticalMovement, 0f);
    }
}
