using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingObjectPooler : MonoBehaviour
{
    
    public GameObject pooledObject;
    public int pooledAmount;

    private List<GameObject> pooledObjects;

    // Use this for initialization
    void Start()
    {

        pooledObjects = new List<GameObject>();
        PopulatePooledObjects();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PopulatePooledObjects()
    {

        for (int i = 0; i < pooledAmount; i++)
        {

            CreateAndAddPooledObjectToList();

        }
    }

    public GameObject GetPooledObject()
    {

        for (int i = 0; i < pooledObjects.Count; i++)
        {

            if (pooledObjects[i].activeInHierarchy == false)
            {

                Debug.Log("Found inactive platform");

                return pooledObjects[i];
            }

        }

        // Create new object and add to list

        return CreateAndAddPooledObjectToList();
    }


    private GameObject CreateAndAddPooledObjectToList()
    {

        GameObject mGameObject = Instantiate(pooledObject);
        mGameObject.SetActive(false);
        pooledObjects.Add(mGameObject);

        Debug.Log("Create inactive platform");

        return mGameObject;
    }

}
