using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUp : MonoBehaviour
{
<<<<<<< HEAD:Assets/Scripts/miCamera/CameraUp.cs
    private Collider2D cl;
    public Transform camera;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
=======
    public Camera cam;
    public float _y;
    // Start is called before the first frame update
    void Start()
    {

>>>>>>> ed56bd794b0e6d1426951b95b912c55e65925c9b:Assets/Scripts/CameraMovement.cs
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
<<<<<<< HEAD:Assets/Scripts/miCamera/CameraUp.cs

            camera.transform.position = position;

=======
            cam.transform.position = new Vector3(0, _y, -10);
>>>>>>> ed56bd794b0e6d1426951b95b912c55e65925c9b:Assets/Scripts/CameraMovement.cs
        }
    }
}
