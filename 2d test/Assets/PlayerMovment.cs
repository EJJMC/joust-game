using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D rb;

    private float dirX = 0f;
    public float P_MoveSpeed;

    public float P_BigJumpForce;
    public float P_SmallJump;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * P_MoveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, P_BigJumpForce);
        }
        /*
        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, P_SmallJump);
        }
        */
    }
}
