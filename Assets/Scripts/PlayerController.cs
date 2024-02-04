using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float smallSpeed = 25f; 
    public float bigSpeed = 1f;
    public float jumpForce = 10f;

    public float bigMass = 30f;
    private Rigidbody2D rb;
    private bool isGrounded = true;
    private float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = normalSpeed; 
    }

    void Update()
    {

        float move = Input.GetAxis("Horizontal");

        if (Input.GetMouseButtonDown(0)) { 
            ChangeSize(1.5f);
            GetComponent<SpriteRenderer>().color = Color.red;
            rb.mass = bigMass;
            speed = bigSpeed;
        } else if (Input.GetMouseButtonDown(1)) {
            ChangeSize(0.5f);
            GetComponent<SpriteRenderer>().color = Color.yellow;
            speed = smallSpeed;
        } else if (Input.GetKeyDown(KeyCode.LeftShift)) {
            ChangeSize(1f);
            GetComponent<SpriteRenderer>().color = Color.green;
            speed = normalSpeed;
        }

        Debug.Log("Current Speed: " + speed); 

 
        transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;


        if (Mathf.Approximately(transform.localScale.x, 1f) && isGrounded && Input.GetButtonDown("Jump")) {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    private void ChangeSize(float scaleFactor)
    {
        transform.localScale = new Vector3(scaleFactor, scaleFactor, 1);
        rb.mass = scaleFactor; 
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Plank") || collision.gameObject.CompareTag("SBOX") || collision.gameObject.CompareTag("SPlatform")) 
        {
            isGrounded = true;
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
