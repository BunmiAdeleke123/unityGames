﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);
    private Vector3 rotateCamera = new Vector3(0, -90, 0);

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(rotateCamera);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
        
    }
}
