using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpKing : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D cl;
    private Controller co;

    [SerializeField] private float speed;
    private float moveInput;
    private float tempx;
    public float diagonal;
    
    [SerializeField]private float jumpForce;
    [SerializeField] private bool canJump = true;
    [SerializeField] private bool canMove = true;
    [SerializeField] private bool jump = false;


   
  


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cl = GetComponent<Collider2D>();
        co = GetComponent<Controller>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space) && co.grounded && canJump)
        {
            jumpForce += 0.1f;
            canMove = false;
        }
        
       if (Input.GetKeyUp(KeyCode.Space))
       {
            if (co.grounded)
            {
                jump = true;
            }
            canJump = true;
       }
            tempx = moveInput * speed;
    }

    private void FixedUpdate()
    {
        //move horizontal
        if (jumpForce == 0.0f && co.grounded)
        {
            rb.velocity = new Vector2(tempx, rb.velocity.y);
            canJump = true;
        }
        if (canMove == false)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (jumpForce >= 20f && co.grounded)
        {
            float tempxjump = moveInput * speed;
            rb.velocity = new Vector2(tempx, jumpForce);
            ResetJump();
            canMove = true;
        }
        if (jump)
        {
            float tempxjump = moveInput * speed;
            rb.velocity = new Vector2(tempxjump, jumpForce);
            ResetJump();
            canMove = true;
            jump = false;
        }
   
    }
    void ResetJump()
    {
        jumpForce = 0;
        canJump = false;
    }
}
