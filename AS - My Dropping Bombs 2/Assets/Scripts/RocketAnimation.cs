using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAnimation : MonoBehaviour
{

    [Header("Animatior")]
    public Animator animatior;

    // Start is called before the first frame update
    void Start()
    {
        animatior = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        animatior.SetFloat("HAxis",horizontal);
    }
}
