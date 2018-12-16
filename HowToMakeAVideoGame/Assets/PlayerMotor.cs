using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    public Animator animator;
    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 9.0f;
    private float animationDuration = 3.0f;
    private float border = 20.0f;
    

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Time.time < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }
        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity*Time.deltaTime;
        }

        
        


        //Y - Up and Down
        if (Input.GetKeyDown("space"))
        {

           controller.Move(Vector3.up * 100.0f * Time.deltaTime);
            moveVector.z = speed - 4.0f;
        }
        else
        {
            //X - Left and Right

            moveVector.x = Input.GetAxisRaw("Horizontal") * speed * 2.0f;
            Vector3 currentPosition = transform.position;
            // modify the variable to keep y within minY to maxY
            currentPosition.x =
               Mathf.Clamp(currentPosition.x, -80, -60);
            // and now set the transform position to our modified vector
            transform.position = currentPosition;
            moveVector.y = verticalVelocity;

            //Z - Forward and Backward
            moveVector.z = speed;
        }
       



        controller.Move(moveVector * Time.deltaTime);
        if (Input.GetKey("x"))
        {
            animator.SetTrigger("Attack1Trigger");
        }

        if(moveVector.y < -50f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        


    }

}
