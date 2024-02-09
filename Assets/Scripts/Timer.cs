using UnityEngine;
using TMPro; // Import the TextMeshPro namespace
using UnityEngine.SceneManagement; // Import the SceneManagement namespace

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60; // Set your countdown time in seconds here
    public bool timerIsRunning = false;
    public TextMeshProUGUI timerText; // Assign your TextMeshProUGUI component here

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

                // Reload the current scene when the timer ends
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{01:00}", minutes, seconds);
    }
}
