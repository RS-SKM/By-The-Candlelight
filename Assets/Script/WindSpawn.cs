using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawn : MonoBehaviour
{
    void Start()
    {
        SpawnWind();
    }

    public GameObject wind;
    void SpawnWind()
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        Instantiate(wind, position, Quaternion.identity);
    }
}
