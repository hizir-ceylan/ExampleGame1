using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
   
   //This script belongs to car
   
   
    //When a collision happens writing CRASH on the console
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("CRASH!");
    }

    //When entering a trigger its show the message on the console
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("TRIGGERED!") ;   
    }

}
