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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mv = GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = Input.GetAxis("Horizontal");

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
                timer = 4f;
            }
            else if(timer >= 2)
            {
                rb.AddForce(transform.up * Smediano, ForceMode2D.Impulse);
                timer = 4f;
            }
            else if (timer >= 1)
            {
                rb.AddForce(transform.up * Spotente, ForceMode2D.Impulse);
                timer = 4f;
            }

            canJump = false;
        }
    }
}
