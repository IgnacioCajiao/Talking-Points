using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Get input from arrow keys or WASD
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Handle animations
        if (movement != Vector2.zero)
        {
            anim.SetBool("moving", true);
        }
        else
        {
            anim.SetBool("moving", false);
        }
    }

    void FixedUpdate()
    {
        // Move the player
        rb.velocity = movement * moveSpeed;
    }
}