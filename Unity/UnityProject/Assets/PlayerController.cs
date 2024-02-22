using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f; // speed is 12
    public float gravity = -9.81f; // variable for gravity
    public float jumpHeight = 3f; // jumping variable
    public Transform groundCheck; // ground check, to make sure you dont fall through
    public float groundDistance = 0.4f; // where the ground is
    public LayerMask groundMask; // variable for ground 
    Vector3 velocity;
    bool isGrounded; // Checks if the Player is Grounded
   

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0) // if statement controlling player velocity
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal"); // movement for x axis
        float z = Input.GetAxis("Vertical"); // movement for y axis


        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); // controls jumping
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
