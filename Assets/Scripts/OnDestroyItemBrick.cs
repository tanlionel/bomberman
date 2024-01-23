using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class OnDestroyItemBrick : MonoBehaviour
{
    public GameObject[] PowerUp; 

    //private bool isDestroyed = false;

    private Vector3 objectPosition;

    void Start()
    {
        //Debug.Log("Object X: " + transform.position.x);
        //Debug.Log("Object Y: " + transform.position.y);
        objectPosition = transform.position;
    }

    /*void OnDestroy()
    {
        //Debug.Log("Object destroy!");
        if (!isDestroyed)
        {
            SpawnRandomItem();
        }
    }*/

    public void SpawnRandomItem(Vector3 objectPosition)
    {
        //isDestroyed = true;

        if (PowerUp != null)
        {
            //Debug.Log("Object X: " + objectPosition.x);
            //Debug.Log("Object Y: " + objectPosition.y);
            
            /*objectPosition.x = -2.5;
            objectPosition.y = 3.5;
            */
            System.Random random = new System.Random();

            int randomNumber = random.Next(0, 20);
            //Debug.Log(randomNumber);

            if (randomNumber < PowerUp.Length)
                Instantiate(PowerUp[randomNumber], objectPosition, Quaternion.identity);
        }
        else
        {
            //Debug.LogError("Item prefab is not set!");
        }
    }
}
