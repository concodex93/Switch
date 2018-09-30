using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

    private GameObject platformDestructionPoint;

	// Use this for initialization
	void Start () {

        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");
	}
	
	// Update is called once per frame
	void Update () {

        DestroyPlatform();
       
	}

    private void DestroyPlatform(){
        
        if (transform.position.x < platformDestructionPoint.transform.position.x){
            
            gameObject.SetActive(false);

            Debug.Log("Destroy");
        }
    }
}
