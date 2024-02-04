using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerWins();
        }
    }

    private void PlayerWins()
    {
        Debug.Log("Player Wins!");

        Time.timeScale = 0;
    }
}
