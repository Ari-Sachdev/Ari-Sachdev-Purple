﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rigidbody;

    float jumpForce = 5.7f;

    public bool isGrounded;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast();

        if(Input.GetButtonDown("Jump")){
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

