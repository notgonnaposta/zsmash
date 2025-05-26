using System.Collections;
using UnityEngine;

public class piperscript : MonoBehaviour
{
    public GameObject pipes;
    public bigbertha bigbertha;
    public GameObject image;
    public bool johnson;
    public bool jimshin = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void piper()
    {
        Debug.Log("you fucked.");
        Instantiate(pipes, new Vector2(-0, 15), Quaternion.identity);
        johnson = true;
        bigbertha.hasbeendone = false;
        jimshin = true;
    }

    void Start()
    {
        image.SetActive(false);
        jimshin = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (johnson == true)
        {
        StartCoroutine(jimhidey());
            johnson = false;
            

        }
    }

    IEnumerator jimhidey()
    {
        image.SetActive(true);
        yield return null;
        gameObject.SetActive(false);
        jimshin = false;
    }
}
