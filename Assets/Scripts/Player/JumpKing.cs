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
    
    
    [SerializeField]private float jumpForce;
    [SerializeField] private bool canJump = true;
    [SerializeField] private bool jump = false;
    public float jumpValue;
    private float tempxjump;

    public bool ChargingJump { get { return jumpForce > 0.5f; } }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cl = GetComponent<Collider2D>();
        co = GetComponent<Controller>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        tempx = moveInput * speed;

     

        if (Input.GetKey(KeyCode.Space) && co.grounded && canJump)
        {
            jumpForce += jumpValue * Time.deltaTime;
        }
        
       if (Input.GetKeyUp(KeyCode.Space))
       {
            if (co.grounded)
            {
                jump = true;
            }
       }
       
    }

    private void FixedUpdate()
    {
        //move horizontal
        if (!ChargingJump && co.grounded)
        {
            rb.velocity = new Vector2(tempx, rb.velocity.y);
            canJump = true;
        }

        if (jumpForce >= 25f && co.grounded)
        {
            
            Debug.Log(tempx);
            rb.velocity = new Vector2(tempx /** Time.fixedDeltaTime*/, jumpForce);
            ResetJump();
            jump = false;

        }

        if (jump)
        {
            Debug.Log(tempx);
            rb.velocity = new Vector2(tempx  /** Time.fixedDeltaTime*/, jumpForce); 
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
