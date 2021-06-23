using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
      
 void OnCollisionEnter2D (Collision2D other)
        {
            Debug.Log("We hit something");
            Destroy(other.gameObject);
        }
    
}
