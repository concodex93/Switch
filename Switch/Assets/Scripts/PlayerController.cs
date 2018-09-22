using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D playerRigidBody;
    public float playerSpeed;
    public float playerJumpHieght;

	// Use this for initialization
	void Start () {
        
        playerRigidBody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        playerRigidBody.velocity = new Vector2(playerSpeed, playerRigidBody.position.y);

	}
}
