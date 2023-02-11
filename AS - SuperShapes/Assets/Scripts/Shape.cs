using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [Header("Rigidbody Object")]
    public Rigidbody2D rb;
    [Header("Default Shrinking Speed")]
    public float shrinkSpeed = 6f;
    public Vector3 Origin;
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        Origin = transform.localScale;
        transform.localScale = Origin * 20f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Origin * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x <= .05f)
        {
            Score.score++;
            Destroy(gameObject);
        }
    }
}
