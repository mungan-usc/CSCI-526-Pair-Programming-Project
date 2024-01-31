using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private Rigidbody2D rb;
    // private float moveSpeed = 5.0f;
    // private float baseJump = 20.0f;
    // private const int sizeChangeUpperLimit = 5;
    // private const int sizeChangeLowerLimit = -5;
    // private int playerSize = 0;
    // private Renderer renderer;
    // //private Vector3 respawnPoint;
    // //public GameObject boxPrefab;

    private Rigidbody2D rb;
    private Renderer renderer;
    
    private float moveSpeed = 5.0f;
    private float baseJump = 20.0f;
    
    private const int sizeChangeUpperLimit = 5;
    private const int sizeChangeLowerLimit = -5;
    
    private int playerSize = 0;

    private readonly float sizeIncreaseFactor = 1.1f;
    private readonly float sizeDecreaseFactor = 0.9f;
    private readonly float moveSpeedIncreaseFactor = 1.2f;
    private readonly float moveSpeedDecreaseFactor = 0.8f;

    private bool canJump = true; // Flag to control jumping

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //For movement
        Color newColor = new Color(0.0f, 1.0f, 0.0f);
        renderer = GetComponent<Renderer>(); //For color
    }

    // Update is called once per frame
    void Update()
    {

        HandleMovementInput();
        UpdatePlayerColor();

    }

    private void HandleMovementInput(){
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (canJump && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, baseJump / moveSpeed); //Division because inversely proportional with size
            canJump = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && playerSize < sizeChangeUpperLimit)
        {
            IncreasePlayerSize();
        }

        if (Input.GetKeyDown(KeyCode.S) && playerSize > sizeChangeLowerLimit)
        {
            DecreasePlayerSize();
        }
    }

    private void IncreasePlayerSize()
    {
        transform.localScale *= sizeIncreaseFactor;
        moveSpeed *= moveSpeedDecreaseFactor;
        playerSize++;
    }

    private void DecreasePlayerSize()
    {
        transform.localScale *= sizeDecreaseFactor;
        moveSpeed *= moveSpeedIncreaseFactor;
        playerSize--;
    }

    private void UpdatePlayerColor()
    {
        Color newColor;
        if (playerSize == 0){
            newColor = new Color(0.0f, 1.0f, 0.0f);
        }
        else if (playerSize == 1){
            newColor = new Color(0.25f, 0.75f, 1.0f);
        }
        else if (playerSize == 2){
            newColor = new Color(0.5f, 0.5f, 1.0f);
        }
        else if (playerSize == 3){
            newColor = new Color(0.75f, 0.25f, 1.0f);
        }
        else if (playerSize == 4){
            newColor = new Color(1.0f, 0.0f, 1.0f);
        }
        else if (playerSize == 5){
            newColor = new Color(0.5f, 0.0f, 0.5f);
        }
        else if (playerSize == -1){
            newColor = new Color(1.0f, 1.0f, 1.0f);
        }
        else if (playerSize == -2){
            newColor = new Color(1.0f, 0.75f, 0.75f);
        }
        else if (playerSize == -3){
            newColor = new Color(1.0f, 0.5f, 0.5f);
        }
        else if (playerSize == -4){
            newColor = new Color(1.0f, 0.25f, 0.25f);
        }
        else if (playerSize == -5){
            newColor = new Color(1.0f, 0.0f, 0.0f);
        }
        else{
            newColor = Color.green;
        }

        renderer.material.color = newColor;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            canJump = true; // Player has touched the ground, so allow jumping again
        }
    }


}

