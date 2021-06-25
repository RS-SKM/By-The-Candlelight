using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Stop("Theme");
        FindObjectOfType<AudioManager>().Play("Lose");
    
    }

    public void GoToMainMenu()
    {
    	Debug.Log("Pressed main menu");
    	SceneManager.LoadScene("MainMenu");
        SceneManager.LoadScene(0);
    }


    public void RestartGame()
    {
    	Debug.Log("Restart TIME");
        SceneManager.LoadScene(1);
    }

}
