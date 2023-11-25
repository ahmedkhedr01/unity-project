using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyMove : MonoBehaviour
{
    public Transform target; // Assign the target character in the Inspector
    public float moveSpeed = 1f; // Adjust movement speed as needed
    public float stoppingDistance = 1.0f; // Distance to stop and play idle animation
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Calculate the direction towards the target
        Vector3 direction = (target.position - transform.position).normalized;

        // Calculate the distance to the target
        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > stoppingDistance)
        {
            // Move towards the target
            transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);

            // Set the "Speed" parameter in the animator for walking animation
            animator.SetFloat("Speed", direction.magnitude);

            // Rotate the character towards the target
            transform.LookAt(target);
        }
        else
        {
            // Stop the character and play the idle animation
            animator.SetFloat("Speed", 0f);
            animator.SetBool("idle", true);
        }
    }
}
