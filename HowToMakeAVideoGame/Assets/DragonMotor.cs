using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMotor : MonoBehaviour {

   
    public Animator animator;
    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 30.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 10.0f;
   

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        
        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }


        //X - Left and Right
        moveVector.x = speed;


        //Y - Up and Down
        moveVector.y = verticalVelocity;
        //Z - Forward and Backward
        moveVector.z = 0.0f;





        controller.Move(moveVector * Time.deltaTime);
        


    }
}
