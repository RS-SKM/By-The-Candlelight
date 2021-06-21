using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

	float currentTime = 0f;
    float startingTime = 10f;
    

    [SerializeField] Text countdownText;
    void Start()

    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <=0) 
        {
            currentTime = 0;
            SceneManager.LoadScene(3);

        }
    }

}
