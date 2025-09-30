using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement movement;
    private Rigidbody rb;
    private AudioSource audioSource;

    public void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Update()
    {
        animator.SetFloat("CharacterSpeed", rb.linearVelocity.magnitude);
        animator.SetBool("IsGrounded", movement.IsGrounded);

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetTrigger("doRoll");
        }

        if (Input.GetButtonUp("Fire2"))
        {
            animator.SetTrigger("doPunch");
        }
    }

    public void PlayPunchSound()
    {
        // Play punch sound when the animation event is triggered
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
