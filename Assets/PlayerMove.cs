using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public CharacterController cont;

    public float speed = 12f;
    public float grav = -9.81f;
    Vector3 velocity;


    public Transform groundCheck;
    public float goundDis = 0.4f;
    public LayerMask groundMask;


    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, goundDis, groundMask);

        if(isGrounded == true && velocity.y <= 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        cont.Move(move*speed *Time.deltaTime);

        velocity.y += grav * Time.deltaTime;
        cont.Move(velocity * Time.deltaTime);
    }
}
