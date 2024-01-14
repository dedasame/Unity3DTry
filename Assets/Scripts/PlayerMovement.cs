using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] Transform groundCheck; //Player'�n alt�ndaki object-> yerle temas ediyorsa z�plamaya izin vermek i�in
    [SerializeField] LayerMask ground;

    void Start() //1 kere �al���r start da
    {
        rb = GetComponent<Rigidbody>();

    }

    
    void Update() //works 60 times for 1 sec.
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x,jumpForce, rb.velocity.z);
        }

    }

    bool IsGrounded()
    {

        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);


    }



}
