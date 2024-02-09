using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    public float speed = 15f; // Speed of the saw's movement
    public float range = 50f; // Range of vertical movement

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float verticalMovement = Mathf.Sin(Time.time * speed) * range;

        transform.position = initialPosition + new Vector3(0f, verticalMovement, 0f);
    }
}
