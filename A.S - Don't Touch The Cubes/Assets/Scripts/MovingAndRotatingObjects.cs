﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAndRotatingObjects : MonoBehaviour
{
    [Header("Default Movement Speed")]
    public float moveSpeed = 10f;
    [Header("Default Rotation Speed")]
    public float rotateSpeed = 50f;
 
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime /2, 0);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime /2);
    }
}