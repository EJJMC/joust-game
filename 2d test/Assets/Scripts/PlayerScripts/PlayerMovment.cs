using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer P_Sprite;

    private float dirX = 0f;
    public float P_MoveSpeed;

    public float P_BigJumpForce;
    public float P_SmallJump;

    private Animator P_Anim; 

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        P_Anim = GetComponent<Animator>();
        P_Sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * P_MoveSpeed, rb.velocity.y);

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, P_BigJumpForce);

            P_Anim.SetBool("IsGrounded", false);
        }

        if(rb.velocity.x > 0f)
        {
            P_Sprite.flipX = true;
        }
        if (rb.velocity.x < 0f)
        {
            P_Sprite.flipX = false;
        }

        /*
        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, P_SmallJump);
        }
        */
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            P_Anim.SetBool("IsGrounded", true);
            Debug.Log("Grounded");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            P_Anim.SetBool("IsGrounded", false);
            Debug.Log("In Air");
        }
    }
}
