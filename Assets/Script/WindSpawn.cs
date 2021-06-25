using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawn : MonoBehaviour
{
    public float Timer = 0.3f;
    public GameObject windPrefab;

    void Start()
    {
        SpawnWind();
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer <= 0f)
        {
            SpawnWind();
            Timer = 0.3f;
        }
    }

    void SpawnWind()
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 6, Random.Range(-10.0F, 10.0F));
        Instantiate(windPrefab, position, Quaternion.identity);
    }
}
