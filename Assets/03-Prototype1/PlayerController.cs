
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    

    void Start()
        {
          rb = GetComponent<Rigidbody>();
        }

    void OnMove(InputValue movementValue)
     {
         
         Vector2 movementVector = movementValue.Get<Vector2>();

         movementX = movementVector.x;
        
      }

    void FixedUpdate()
     {
         Vector3 movement = new Vector3(movementX, 0.0f);
         rb.AddForce(movement * speed);
     }

}