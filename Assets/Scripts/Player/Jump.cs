using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Move mv;
    private Rigidbody2D rb;
    private Collider2D cl;
    private Controller co;
    private float dir;

    [Header("Jump Force")]
    public float S1;
    public float S2;
    public float S3;
    public float S4;

    [Header("Bounce Force")]
    public float bouce1;
    public float bouce2;
    public float bouce3;
    public float bouce4;

    [Header("Timers")]
    public float jumpChargeTimer;
   [SerializeField] private float timer = 4f;

    [Header("Booleans")]
    [SerializeField] private bool canJump = false;
    private bool autoJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mv = GetComponent<Move>();
        cl = GetComponent<Collider2D>();
        co = GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = Input.GetAxis("Horizontal");

        if (co.grounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                timer -= Time.deltaTime;

                if (timer <= 0)
                {
                    timer = 0;
                }

                if (timer == 0)
                {
                    autoJump = true;
                }
                else
                {
                    autoJump = false;
                }


                mv.enabled = false;
                canJump = true;
            }
    
        }
        else
        {
            mv.enabled = true;
        }
        
           
    }
    private void FixedUpdate()
    {

        if (co.walled)
        {
            Vector2 bound = new Vector2(-rb.velocity.x, rb.velocity.y);
            rb.velocity = bound;
        }

        if (autoJump && co.grounded)
        {
            rb.AddForce(transform.up * S4 + transform.right * dir * bouce4, ForceMode2D.Impulse);
            timer = jumpChargeTimer;
        }

        if (!Input.GetKey(KeyCode.Space) && canJump)
        {
            if (timer >= 1.5f)
            {
                rb.AddForce(transform.up * S1 + transform.right * dir * bouce1, ForceMode2D.Impulse);
                timer = jumpChargeTimer;
            }
            else if(timer >= 0.5f)
            {
                rb.AddForce(transform.up * S2 + transform.right * dir * bouce2, ForceMode2D.Impulse);
                timer = jumpChargeTimer;
            }
            canJump = false;
        }
    }
}
