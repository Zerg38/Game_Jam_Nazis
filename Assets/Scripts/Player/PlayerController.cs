using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Controller co;
    private JumpKing jp;
    // Start is called before the first frame update
    void Start()
    {
        co = GetComponent<Controller>();
        jp = GetComponent<JumpKing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (co.deslizar)
        {
            jp.enabled = false;
        }
        else
        {
            jp.enabled = true;
        }
    }
}
