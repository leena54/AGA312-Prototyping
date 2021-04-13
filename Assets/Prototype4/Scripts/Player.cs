using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public float mSpeed, defaultSpeed;
    //private Rigidbody rb;
    public float speed = 10.0F;
   // public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 2.0F;
    private Vector3 moveDirection = Vector3.zero;


    void Start()
    {

        //rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //rb.MovePosition(transform.position + new Vector3(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime));

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            //if (Input.GetButton("Jump"))
                //moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
    }
}
