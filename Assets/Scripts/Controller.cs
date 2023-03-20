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

    public GameObject groundRayObject;

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
        RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position, -Vector2.up);
        for (int i = 0; i < points.Count; i++)
        {
            Debug.DrawRay(transform.position + points[i], -transform.up, Color.red);
        }

        
    }
}
