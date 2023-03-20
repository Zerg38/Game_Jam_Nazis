using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Move mv;
    private Rigidbody2D rb;
    public float Snormal;
    public float Smediano;
    public float Spotente;
   [SerializeField] private float timer = 4f;
    private float dir;
    [SerializeField] private bool canJump = false;
    Vector3 d;
    private Collider2D cl;
    private Controller co;
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

         d = new Vector3(dir, 5);

        Debug.DrawRay(transform.position,d, Color.red);

        if (!co.grounded)
        {
            mv.enabled = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 0;
            }

            mv.enabled = false;
            canJump = true;
            
        }
        else
        {
            mv.enabled = true;
        }
           
    }
    private void FixedUpdate()
    {
        if (!Input.GetKey(KeyCode.Space) && canJump)
        {

            if (timer >= 3f)
            {
                rb.AddForce(transform.up * Snormal, ForceMode2D.Impulse);
                //if (co.walled)
                //{
                //    Vector2 bound = new Vector2(-rb.velocity.x, rb.velocity.y);
                //    rb.velocity = bound
                //}
                timer = 4f;
            }
            else if(timer >= 2f)
            {
                rb.AddForce(transform.up * Smediano, ForceMode2D.Impulse);
                //if (co.walled)
                //{
                //    Vector2 bound = new Vector2(-rb.velocity.x, rb.velocity.y);
                //    rb.velocity = bound
                //}
                timer = 4f;
            }
            else if (timer >= 0f)
            {
                rb.AddForce(transform.up * Spotente, ForceMode2D.Impulse);
                //if (co.walled)
                //{
                //    Vector2 bound = new Vector2(-rb.velocity.x, rb.velocity.y);
                //    rb.velocity = bound
                //}
                timer = 4f;
            }

            canJump = false;
        }
    }

    //invertir la del rb.velocity x para el rebote
}
