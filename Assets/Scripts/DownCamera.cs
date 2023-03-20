using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCamera : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Level1")
        {
            cam.transform.position = new Vector3(0, 0, -10);
        }

        if (collision.tag == "Level2")
        {
            cam.transform.position = new Vector3(0, 9.7f, -10);

        }

        if (collision.tag == "Level3")
        {
            cam.transform.position = new Vector3(0, 19.4f, -10);

        }
    }
}
