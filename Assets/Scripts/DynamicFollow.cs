﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicFollow : MonoBehaviour
{


    public Transform playerCoordinates;
    public Vector3 Offset;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerCoordinates.position + Offset;
    }
}
