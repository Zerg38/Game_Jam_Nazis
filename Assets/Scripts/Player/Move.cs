using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector3 Pinput;
    private Vector2 minput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Pinput = new Vector3(horizontal, 0, 0) * speed;
    }

    private void FixedUpdate()
    {

        transform.position += Pinput * Time.fixedDeltaTime;
    }
}