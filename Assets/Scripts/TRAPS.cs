using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRAPS : MonoBehaviour
{
    public GameObject player;
    public Vector3 a;
    public AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            player.transform.position = a;
            AudioSource.Play();

        }
    }


}
