using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidAnimation : MonoBehaviour
{
    // Declare a private Animator component to control animations.
    private Animator animator;

    // Declare a public Vector3 variable to reset position for the GameObject.
    public Vector3 newPosition;

    private void Start()
    {
        // Get the Animator component attached to the GameObject and store it in the animator variable.
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the GameObject entering the trigger has the tag "Player".
        if (other.CompareTag("Player"))
        {
            // Set the "isPointing" boolean parameter in the Animator to true, triggering an animation.
            animator.SetBool("isPointing", true);

            // Reset GameObject newPosition specified.
            transform.position = newPosition;

            
            Debug.Log("Player enter collider");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the GameObject exiting the trigger has the tag "Player".
        if (other.CompareTag("Player"))
        {
            // Set the "isPointing" boolean parameter in the Animator to false, stopping or changing the animation.
            animator.SetBool("isPointing", false);

            // Reset GameObject newPosition specified.
            transform.position = newPosition;

            
            Debug.Log("Player exit collider");
        }
    }
}
