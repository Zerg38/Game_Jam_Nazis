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
    public Vector3 Roffset;
    public Vector3 Loffset;


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
            Debug.DrawRay(groundRayObject.transform.position + points[i], -transform.up, Color.red);
            RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position + points[i], -transform.up, 1.1f, groundMask);
            grounded |= hitGround.collider != null;

        }


        Debug.DrawRay(groundRayObject.transform.position + Roffset, -transform.right, Color.magenta);
        RaycastHit2D hitWall = Physics2D.Raycast(groundRayObject.transform.position + Roffset, -transform.right, 1f, wallMask);

        Debug.DrawRay(groundRayObject.transform.position + Loffset, transform.right, Color.magenta);
        RaycastHit2D hitWall_2 = Physics2D.Raycast(groundRayObject.transform.position + Loffset, transform.right, 1f, wallMask);

        walled = hitWall.collider != null || hitWall_2.collider != null;
    }
}
