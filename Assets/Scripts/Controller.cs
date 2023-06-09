using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float moveInput;
    Rigidbody2D rb;
    public List<Vector3> points;
    public bool grounded;
    public bool deslizar;
    public bool walled;
    public GameObject groundRayObject;
    public LayerMask groundMask;
    public LayerMask rampaMask;
    public float disatance;

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
            Debug.DrawRay(groundRayObject.transform.position + points[i], -transform.up * disatance, Color.red);
            RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position + points[i], -transform.up, disatance, groundMask);
            grounded |= hitGround.collider != null;

        }


        deslizar = false;
        for (int i = 0; i < points.Count; i++)
        {
            Debug.DrawRay(groundRayObject.transform.position + points[i], -transform.up * 1.1f, Color.red);
            RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position + points[i], -transform.up, 1.1f, rampaMask);
            deslizar |= hitGround.collider != null;
        }
    }
}
