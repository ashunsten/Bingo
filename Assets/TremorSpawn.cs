using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TremorSpawn : MonoBehaviour
{
    public bool isSpawned = false;
    public Transform playerCoordinates;
    public Vector3 Offset;
    public Quaternion rotationOffset;
    public System.Random rnd = new System.Random();

    void Update()
    {
        if (!isSpawned)
        {
            rotationOffset.y = rnd.Next(0, 360);
            rotationOffset.x = rnd.Next(0, 360);
            rotationOffset.z = rnd.Next(0, 360);

            Offset.y = rnd.Next(3, 4);
            Offset.x = rnd.Next(-5, 5);
            Offset.z = rnd.Next(50, 70);

            transform.position = playerCoordinates.position + Offset;
            transform.rotation = rotationOffset;
            isSpawned = true;
        }
        else
        {
            if (transform.position.z < playerCoordinates.position.z)
                isSpawned = false;
        }

    }
}
