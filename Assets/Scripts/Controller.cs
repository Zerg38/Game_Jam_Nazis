using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float moveInput;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    public List<Vector3> points;
    public bool grounded;
    public bool walled;
    public GameObject groundRayObject;
    public LayerMask groundMask;
    public LayerMask wallMask;
    private Vector3 offset;


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
            RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position + points[i], -transform.up, 1f, groundMask);

            if (hitGround.collider != null)
            {
                grounded = true;
  
            }
        }

        offset = new Vector3(0, 1f, 0);

        Debug.DrawRay(groundRayObject.transform.position + offset, -transform.right, Color.magenta);
        RaycastHit2D hitWall = Physics2D.Raycast(groundRayObject.transform.position + offset, -transform.right, 1f, wallMask);

        Debug.DrawRay(groundRayObject.transform.position + offset, transform.right, Color.magenta);
        RaycastHit2D hitWall_2 = Physics2D.Raycast(groundRayObject.transform.position + offset, transform.right, 1f, wallMask);




        if (hitWall.collider != null)
        {
            walled = true;
        }
        else
        {
            walled = false;
        }

        if (hitWall_2.collider != null)
        {
            walled = true;
        }
        else
        {
            walled = false;
        }




    }
}
