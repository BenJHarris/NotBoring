using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer sr;
    public Vector2 movement = Vector2.zero;
    public float moveSpeed = 5f;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (rb.velocity.x >= 0.01f)
        {
            sr.flipX = true;
        } else if (rb.velocity.x <= -0.01f)
        {
            sr.flipX = false;
        }
    }

    private void FixedUpdate()
    {
        // Movement
        rb.velocity = new Vector2(movement.x, movement.y) * moveSpeed;
    }
}
