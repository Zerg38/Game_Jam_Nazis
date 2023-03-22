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
    SpriteRenderer sp;

    public float jumpForce;
    [SerializeField] private bool canJump = true;
    [SerializeField] private bool jump = false;
    public bool ice;
    public float jumpValue;
    private float tempxjump;

    public bool ChargingJump { get { return jumpForce > 0.1f; } }
    public bool canMove = true;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        cl = GetComponent<Collider2D>();
        co = GetComponent<Controller>();
    }

    void Update()
    {
        if (ice)
        {
            rb.gravityScale = 150;
        }
        else
        {
            rb.gravityScale = 4;
        }
        if (co.grounded)
        {
            moveInput = Input.GetAxis("Horizontal");
        }
        tempx = moveInput * speed;

        if (jumpForce == 0)
        {
            sp.color = Color.white;
        }

            if (Input.GetKey(KeyCode.Space) && co.grounded && canJump)
            {
                canMove = false;
                jumpForce += jumpValue * Time.deltaTime;

                if (jumpForce > 0.1)
                {
                sp.color = Color.green;
                }
                if (jumpForce > 10)
                {
                sp.color = Color.yellow;
                }
                if (jumpForce > 20)
                {
                sp.color = Color.red;
                }
            }

        
       if (Input.GetKeyUp(KeyCode.Space))
       {
            sp.color = Color.white;
            canMove = true;
            if (co.grounded)
            {
                jump = true;
            }
       }
       
    }

    private void FixedUpdate()
    {
        //move horizontal
        if (co.grounded && canMove)
        {
            rb.velocity = new Vector2(tempx, rb.velocity.y);
            canJump = true;
        }

        if (jumpForce >= 24f && co.grounded)
        {
            sp.color = Color.white;
            Debug.Log(tempx);
            rb.velocity = new Vector2(tempx * 5  * Time.fixedDeltaTime , jumpForce);
            ResetJump();
            canMove = true;
            jump = false;

        }

        if (jump)
        {
            Debug.Log(tempx);
            rb.velocity = new Vector2(tempx * 5 * Time.fixedDeltaTime, jumpForce); 
            ResetJump();
            jump = false;
        }
   
    }
    void ResetJump()
    {
        jumpForce = 0;
        canJump = false;
    }
}
