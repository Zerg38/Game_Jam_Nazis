using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRender : MonoBehaviour
{
    SpriteRenderer sp;
    [SerializeField] private ParticleSystem praticulas;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Horizontal");

        if (a < 0)
        {
            sp.flipX = true;
      
        }
        else
        {
            sp.flipX = false;
            
        }
    }
}
