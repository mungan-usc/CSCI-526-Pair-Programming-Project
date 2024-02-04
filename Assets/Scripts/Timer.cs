using UnityEngine;
using UnityEngine.UI; // Required for manipulating UI elements
using UnityEngine.SceneManagement; // Required for scene management

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60; // Set this to whatever time limit you want
    public bool timerIsRunning = false;
    public Text countdownText; // Assign this in the inspector

    private void Start()
    {
        // Start the timer
        timerIsRunning = true;
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;

                // Here you can add any actions you want to happen when the timer ends
                // For example, restart the game or load a game over scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current scene
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; // Ensure timer displays correctly

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
