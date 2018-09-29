using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {
    

    public GameObject platformGenerationPoint;
    public GameObject platform;
    public ObjectPooler objectPool;

    private float platformWidth;

	// Use this for initialization
	void Start () {

        platformGenerationPoint = GameObject.Find("PlatformGenerationPoint");
		
	}
	
	// Update is called once per frame
	void Update () {

        GeneratePlatforms();

	}

    private void GeneratePlatforms(){

        if (transform.position.x < platformGenerationPoint.transform.position.x){

            transform.position = new Vector3(transform.position.x + GetPlatformWidth(), transform.position.y, transform.position.z);

            GameObject newPlatform = objectPool.GetPooledObject();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);
        }
    }

    private float GetPlatformWidth(){

        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;

        return platformWidth;
    } 
   
}
