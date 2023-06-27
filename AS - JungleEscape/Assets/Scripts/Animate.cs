using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{

    Animator our_Animator;
    Jump our_Jump;

    // Start is called before the first frame update
    void Start()
    {
        our_Animator = GetComponent<Animator>();
        our_Jump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!our_Jump.isGrounded)
        {
            our_Animator.SetBool("isJumping", true);
            our_Animator.SetBool("isIdle", false);
            our_Animator.SetBool("isWalking", false);
            our_Animator.SetBool("isWalkingBackwards", false);
        }
        if (our_Jump.isGrounded)
        {
            our_Animator.SetBool("isJumping", false);
            our_Animator.SetBool("isIdle", true);
            our_Animator.SetBool("isWalking", false);
            our_Animator.SetBool("isWalkingBackwards", false);

            if (Input.GetAxisRaw("Vertical") == 1)
            {
                our_Animator.SetBool("isJumping", false);
                our_Animator.SetBool("isIdle", false);
                our_Animator.SetBool("isWalking", true);
                our_Animator.SetBool("isWalkingBackwards", false);
            }

            if (Input.GetAxisRaw("Vertical") == -1)
            {
                our_Animator.SetBool("isJumping", false);
                our_Animator.SetBool("isIdle", false);
                our_Animator.SetBool("isWalking", false);
                our_Animator.SetBool("isWalkingBackwards", true);
            }
        }
    }
}
