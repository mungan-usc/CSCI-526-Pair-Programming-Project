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

 
    void Update()
    {
        
    }

    void ToggleLaser()
    {
        isLaserOn = !isLaserOn;

        gameObject.SetActive(isLaserOn);

    }
}
