using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{

    [SerializeField] private int _maxHits = 5;
    [SerializeField] private int _hits = 5;
    private bool _gameOver = false;
    public GameObject GameOverScreen;

    public TextMeshProUGUI healthText;
   

     private void OnCollisionEnter(Collision other)
    {
         if(other.gameObject.tag != "Hit")
        {
            _hits--;
            UpdateHealthText();
            if (_hits <= 0 && !_gameOver)
            {
                EndGame();
            }
        }
    }
    private void Start()
    {
        _hits = _maxHits; // set initial health to max hits
        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = $"Health: {_hits}"; // update the health text with the current hits
        }
    }
    private void EndGame()
    {
        _gameOver = true;
        Debug.Log("Game Over!");
        GameOver();
    }

    public void GameOver()
    {
      Time.timeScale = 0;
      GameOverScreen.SetActive(true);
       
    }
}
