using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTheme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Stop("Lose");
        FindObjectOfType<AudioManager>().Play("Theme");
    }
}
