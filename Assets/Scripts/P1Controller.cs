using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Controller : MonoBehaviour
{
    float speed = 2f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    void Update()
    {
        //Player 1 Keyboard
        movement.x = Input.GetAxis("P1_Horizontal");
        movement.y = Input.GetAxis("P1_Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);


        //animator.SetFloat("Horizontal", P1_horizontalInput);
        //animator.SetFloat("Vertical", P1_verticalInput);

        //if ((kbMovement.x < 0.01) || (kbMovement.x > 0.01))
        //{

        //}
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}