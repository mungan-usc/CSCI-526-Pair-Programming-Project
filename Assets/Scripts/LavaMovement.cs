using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaMovement : MonoBehaviour
{
    private float speed = 1f; // Adjust speed as needed
    public int Respawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        // Move the lava horizontally from left to right
        transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            SceneManager.LoadScene(Respawn);
        }
    }
}
