using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject GameOverScreen;
    
    
    void Start()
    {
         StartScreen.SetActive(true);
         Time.timeScale = 0;
    }

     
    public void PlayAgainPressed()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameOverScreen.SetActive(false);
         Time.timeScale = 1;
    }

     public void PlayButton()
    {

         StartScreen.SetActive(false);
         Time.timeScale = 1;
         
    }


    
}
