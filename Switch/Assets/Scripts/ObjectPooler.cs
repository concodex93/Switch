using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {


    public GameObject pooledObject;
    public int pooledAmount;

    private List<GameObject> pooledObjects;

	// Use this for initialization
	void Start () {

        pooledObjects = new List<GameObject>();
        PopulatePooledObjects();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PopulatePooledObjects(){

        for (int i = 0; i < pooledAmount; i ++){

            GameObject mGameObject = Instantiate(pooledObject);
            mGameObject.SetActive(false);
            pooledObjects.Add(mGameObject);

        }
    }

    public GameObject GetPooledObject(){

        for (int i = 0; i < pooledObjects.Count; i ++){

            if (!pooledObjects[i].activeInHierarchy){

                return pooledObjects[i];
            }

        }

        GameObject mGameObject = Instantiate(pooledObject);
        mGameObject.SetActive(false);
        pooledObjects.Add(mGameObject);

        return mGameObject;
    }

}
