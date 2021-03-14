using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
       [SerializeField] private CharacterController controller;
    private const float gravity = -9.82f;
    //private float speed = 12f;
    private float m_jumpHeight = 5f;
    private Vector3 velocity;


    private void Update()
    {
        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //Vector3 move = transform.right * x + transform.forward * z;

        //controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("jump!");
            if (IsGrounded())
            {
                Debug.Log("grounded");
                velocity.y = Mathf.Sqrt(m_jumpHeight * -2f * gravity);
            }
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private bool IsGrounded() {
        var distToGround = controller.height / 2;
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    } 
}
