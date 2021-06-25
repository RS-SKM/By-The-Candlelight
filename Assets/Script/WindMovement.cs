using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 10;
    public Transform candle;
    private Vector2 movement;

    void Start()
    {
        rb= this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
      Vector3 direction = candle.position - transform.position;
      
      float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
      rb.rotation = angle;
      direction.Normalize();
      movement = direction;

    }

    private void FixedUpdate(){
        moveWind(movement);
    }

    void moveWind(Vector2 direction)
    {
        //Take current position & move in directionb spcified - which is the candle * by 5
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}