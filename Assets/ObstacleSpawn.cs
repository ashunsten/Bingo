using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ObstacleSpawn : MonoBehaviour
{
    public bool isSpawned = false;
    public Transform playerCoordinates;
    public Vector3 Offset;
    public System.Random rnd = new System.Random();

    void Update()
    {
        if(!isSpawned)
        {
            Offset.y = rnd.Next(3, 4);
            Offset.x = rnd.Next(-5, 5);
            Offset.z = rnd.Next(50, 70);
            transform.position = playerCoordinates.position + Offset;
            isSpawned = true;
        }
        else
        {
            if (transform.position.z < playerCoordinates.position.z)
                isSpawned = false;
        }
        
    }
}
