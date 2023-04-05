using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        // Show the game over screen
        gameOverScreen.SetActive(true);

        // Pause the game
        Time.timeScale = 0;

    }
    public void PlayAgainPressed()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverScreen.SetActive(false);
        Time.timeScale = 1;
    }

 
}
