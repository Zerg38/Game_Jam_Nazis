using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    private GameObject level1;
    private GameObject level2;
    private GameObject level3;
    // Start is called before the first frame update
    void Start()
    {
        level1 = GameObject.Find("Level1(jungle)");
        level2 = GameObject.Find("Level2(transition)");
        level3 = GameObject.Find("Level3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if(collision.gameObject.name == "Level1(junle)")
        {
            Camera.main.transform.SetParent(level1.transform);
            Camera.main.transform.localPosition = level1.transform.localPosition;   
        }

        if(collision.gameObject.name == "Level2(transition)")
        {
            Camera.main.transform.SetParent(level2.transform);
            Camera.main.transform.localPosition = level2.transform.localPosition;

        }

        if (collision.tag == "Level3")
        {
            Camera.main.transform.SetParent(level3.transform);
            Camera.main.transform.localPosition = level3.transform.localPosition;

        }
        */
    }
}
