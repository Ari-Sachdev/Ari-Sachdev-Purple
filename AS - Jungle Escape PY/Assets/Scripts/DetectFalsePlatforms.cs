using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;
    public LayerMask eight;
    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, 20f, eight);
        Debug.DrawRay(transform.position, transform.forward * 20f, Color.white);
        if (hit)
        {
            Debug.LogWarning("Be Carful!");
        } else
        {
            Debug.LogWarning("All Clear!");
        }
    }
}
