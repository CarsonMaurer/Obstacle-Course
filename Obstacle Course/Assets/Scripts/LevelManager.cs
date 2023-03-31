using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject StartScreen;
    
    void Start()
    {
         StartScreen.SetActive(true);
         Time.timeScale = 0;
    }

     public void GameOver()
    {
      
       
    }
    public void PlayAgainPressed()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         Time.timeScale = 1;
    }

     public void PlayButton()
    {

         StartScreen.SetActive(false);
         Time.timeScale = 1;
         
    }


    
}
