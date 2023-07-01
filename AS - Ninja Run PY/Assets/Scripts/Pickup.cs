using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("a");
        if (other.gameObject.CompareTag("coin"))
        {
            Debug.Log("b");
            Destroy(other.gameObject);
            Destroy(Door);
        }
    }
}
