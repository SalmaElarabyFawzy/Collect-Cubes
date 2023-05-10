﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] private float speed = 10;
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * speed *Time.deltaTime);
    }
}
