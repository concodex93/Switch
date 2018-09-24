using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 cameraDelta;

	// Use this for initialization
	void Start () {

        cameraDelta = transform.position - player.transform.position;
	}

	
	// LateUpdate is called once per frame AFTER Update has been executed
	void LateUpdate () {

        transform.position = player.transform.position + cameraDelta;
	}
}
