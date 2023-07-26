using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public float speed = 5;
    public float attackingDistance = 1;
    public Vector3 direction;

    private Animator animatorEnemy;
    private Rigidbody rigidbodyEnemy;
    private Transform target;
    public bool isFollowingTarget;
    public bool isAttackingTarget;
    public float currentAttackingTime;
    public float maxAttackingTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        isFollowingTarget = true;
        currentAttackingTime = maxAttackingTime;
        rigidbodyEnemy = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void FollowTarget()
    {
        if (!isFollowingTarget)
        {
            return;
        }

        if (Vector3.Distance(transform.position, target.position) >= attackingDistance)
        {
            direction = target.position - transform.position;
            direction.y = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 20);
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        FollowTarget();
    }
}
