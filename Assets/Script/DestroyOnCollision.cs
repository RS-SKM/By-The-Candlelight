using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
     /*   void OnCollisionEnter()
        {
            Debug.Log("We hit something");
        }


        private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("WindEnemy"))
        Destroy(collision.gameObject);
    } 

*/
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("WindEnemy"))
        {
            Destroy(other.gameObject);
        }
    }
    
}
