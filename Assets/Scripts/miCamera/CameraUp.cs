using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUp : MonoBehaviour
{
    private Collider2D cl;
    public Transform camera;
    public Vector3 position;
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
        if (collision.tag == "Player")
        {

            camera.transform.position = position;

        }
    }
}
