using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public AudioSource musicsource;
   
    public void jimmy()
    {
        musicsource.Stop();
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }



}
