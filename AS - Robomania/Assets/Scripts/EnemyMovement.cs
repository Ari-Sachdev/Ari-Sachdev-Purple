using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float yForce;
    public float xForce1;
    public float xForce2;
    public float xForce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;
    
    void EnemySpeed()
    {
        xForce = xForce2;
        xForce *= 1.5f;
        if (xForce > 1000)
        {
            xForce = xForce1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        xForce1 = xForce;
        xForce2 = xForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);

        }       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            xForce2 = xForce;
            xForce = 0;
            Invoke("EnemySpeed", 0.2f);
        }
    }


    // Update is called once per frame
    private void FixedUpdate()
    {

        if (transform.position.x <= -8)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * xForce);
        }
        if (transform.position.x >= 8)
        {
            xDirection = -1;
            enemyRigidBody.AddForce(Vector2.left * xForce);
        }
    }
}
