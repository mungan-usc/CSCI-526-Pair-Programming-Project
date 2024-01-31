using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    // Start is called before the first frame update
    public float onTime = 1f; // Time the laser is on
    public float offTime = 1f; // Time the laser is off

    private bool isLaserOn = false;
    void Start()
    {
        InvokeRepeating("ToggleLaser", 0f, onTime + offTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ToggleLaser()
    {
        isLaserOn = !isLaserOn;

        // Enable/disable laser visuals, collider, etc. based on the state
        // For example:
        gameObject.SetActive(isLaserOn);

        // If using LineRenderer for the laser visuals, you can enable/disable it:
        // GetComponent<LineRenderer>().enabled = isLaserOn;
    }
}
