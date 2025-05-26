using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject Pausescreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Pause()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        Pausescreen.SetActive(true);
    } 
    public void unpause()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        Pausescreen.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
