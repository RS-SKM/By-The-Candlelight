using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void GoToMainMenu()
    {
    	Debug.Log("Pressed main menu");
    	SceneManager.LoadScene("MainMenu");
        SceneManager.LoadScene(1);
    }


    public void RestartGame()
    {
    	Debug.Log("Restart TIME");
        SceneManager.LoadScene(2);
    }

}
