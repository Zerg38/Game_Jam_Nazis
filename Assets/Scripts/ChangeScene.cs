using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public AudioSource AudioSource;
    // Start is called before the first frame update
    public void Game(int sceneID)
    {
        AudioSource.Play();
        SceneManager.LoadScene(sceneID);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
