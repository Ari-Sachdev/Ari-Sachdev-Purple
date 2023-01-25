﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Destruction Timer")]
    public float timetoDestruction;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", timetoDestruction);
    }
    void DestroyObject()
    {
        Destroy(gameObject);
    }
}

