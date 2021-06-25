using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
      
 void OnCollisionEnter2D (Collision2D other)
        {
            Debug.Log("Wind Blocked");
            Destroy(other.gameObject);
        }
}
