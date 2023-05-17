using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D m_rigidbody2D;

    float jumpForce = 15;
    public bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_rigidbody2D.velocity.y > -0.01 && m_rigidbody2D.velocity.y < 0.01)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        if (canJump && Input.GetButtonDown("Jump"))
        {
            m_rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
