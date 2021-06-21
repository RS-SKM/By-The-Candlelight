using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCanvasHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
