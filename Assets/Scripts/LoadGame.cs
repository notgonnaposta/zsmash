using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource musicsource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void jimmy()
    {
        musicsource.Stop();
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
