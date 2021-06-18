using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightFlicker : MonoBehaviour
{
    public float flickerIntensity = 0.2f;
    public float flickerSpeed = 3f;
    public float flickerRandomness = 1f;

    private float time;
    private float startingIntensity;
    private UnityEngine.Experimental.Rendering.Universal.Light2D lights;

    void Start()
    {
        lights = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
        startingIntensity = lights.intensity;
    }

    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-flickerRandomness, flickerRandomness)) * Mathf.PI;
        lights.intensity = startingIntensity + Mathf.Sin(time * flickerSpeed) * flickerIntensity;
    }
}
