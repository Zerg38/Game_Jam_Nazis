using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float moveInput;
    Rigidbody2D rb;
    public List<Vector3> points;
    public bool grounded;
    public bool walled;
    public GameObject groundRayObject;
    public LayerMask groundMask;
    public LayerMask wallMask;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void Update()
    {
        grounded = false;
        for (int i = 0; i < points.Count; i++)
        {
            Debug.DrawRay(groundRayObject.transform.position + points[i], -transform.up ,Color.red);
            RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position + points[i], -transform.up, 1.1f, groundMask);
            grounded |= hitGround.collider != null;

        }
    }
}
