using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D playerRigidBody;
    private float currentSpeed = 2f;
    private float targetSpeed = 35f;
    private float rotationSpeed;
    private float rotationCompensationValue = 5f;
    public float playerJumpHieght;

	// Use this for initialization
	void Start () {
        
        playerRigidBody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        Run();
        Rotate();
        AdjustPlayerRotation();
        Jump();

	}

    private void Run(){

        if (currentSpeed < targetSpeed){

            currentSpeed += Time.deltaTime/2;
            playerRigidBody.velocity = new Vector2(currentSpeed, playerRigidBody.velocity.y);

        }
    }

    private void Jump(){

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, playerJumpHieght);

        }
    }

    private void Rotate(){
        
        rotationSpeed = currentSpeed / 2;
        transform.Rotate(0, 0, -rotationSpeed);

    }

    private void AdjustPlayerRotation(){
        
        if (Input.GetKey(KeyCode.RightArrow) == true){

            transform.Rotate(0, 0, -rotationCompensationValue);

        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            
            transform.Rotate(0, 0, rotationCompensationValue);

        }
    
    }

}
