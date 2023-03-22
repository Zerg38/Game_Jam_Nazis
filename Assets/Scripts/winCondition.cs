using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCondition : MonoBehaviour
{
    public AudioSource Audio;
    public Canvas canvas;
    public AudioSource Audio_enter;
    // Start is called before the first frame update
    void Start()
    {
 
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Audio.Play();
        canvas.enabled = true;
        Audio_enter.Pause();
    }
}
