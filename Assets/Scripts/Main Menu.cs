using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void jimme()
    {
        StartCoroutine(Resettime());

    }
    private IEnumerator Resettime()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        yield return new WaitForSecondsRealtime(0.1f);

         SceneManager.LoadScene("MainMenu");
}
}
