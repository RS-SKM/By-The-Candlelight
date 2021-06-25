using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawn : MonoBehaviour
{
    public float Timer = 0.5f;
    public GameObject windPrefab;

   
    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer <= 0f)
        {
            SpawnWindRight();
            SpawnWindLeft();
            Timer = 0.5f;
        }
    }

    void SpawnWindLeft()
    {
        Vector3 positionLeft = new Vector3(-15.0F, Random.Range(-6f, 6f), Random.Range(-10.0F, 10.0F));
        Instantiate(windPrefab, positionLeft, Quaternion.identity);
    }

    void SpawnWindRight()
    {
        Vector3 positionRight = new Vector3(15.0F, Random.Range(-6f, 6f), Random.Range(-10.0F, 10.0F));
        Instantiate(windPrefab, positionRight, Quaternion.identity);
    }
}
