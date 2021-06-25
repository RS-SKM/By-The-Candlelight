using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Candle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Candle blow out");
        SceneManager.LoadScene(2);
    }
}
