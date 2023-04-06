using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject StartScreen;

    private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Obstacle"))
    {
        EndGame();
    }
}
    void Start()
    {
         StartScreen.SetActive(true);
         Time.timeScale = 0;
    }
    public void PlayButton()
    {

         StartScreen.SetActive(false);
         Time.timeScale = 1;
         
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
