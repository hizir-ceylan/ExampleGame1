using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    //code to make the car move and steer

    [SerializeField]float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;

    void Update()
    {
       float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
       float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
       transform.Rotate(0, 0, -steerAmount);
       transform.Translate(0, moveAmount, 0);

    }

    //when the car hits a onject, it slows down

    private void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;    
    }
    
    //when the car hits a boost, it speeds up

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }    
    }
}
