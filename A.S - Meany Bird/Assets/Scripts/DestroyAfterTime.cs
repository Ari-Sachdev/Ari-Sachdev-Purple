using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Default Destruction Time")]
    public float timetoDestruction;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", timetoDestruction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}

