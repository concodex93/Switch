using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    

    public GameObject platformGenerationPoint;
    public GameObject platform;

    private float platformWidth;

	// Use this for initialization
	void Start () {

        platformGenerationPoint = GameObject.Find("PlatformGenerationPoint");
		
	}
	
	// Update is called once per frame
	void Update () {


	}

    private void GeneratePlatforms(){

        if (transform.position.x < platformGenerationPoint.transform.position.x){

            transform.position = new Vector3(transform.position.x + GetPlatformWidth(), transform.position.y);
        }
    }

    private float GetPlatformWidth(){

        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;

        return platformWidth;
    } 
   
}
