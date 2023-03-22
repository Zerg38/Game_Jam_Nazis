using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCondition : MonoBehaviour
{
    public AudioSource Audio;
    public GameObject canvas;
    public AudioSource Audio_enter;
    // Start is called before the first frame update
    void Start()
    {
 
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Audio.Play();
        canvas.SetActive(true);
        Audio_enter.Pause();
    }
}
