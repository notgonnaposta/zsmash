using UnityEngine;

public class mainmenumusic : MonoBehaviour
{
    public AudioSource audioSource;
    public float logofadein;
    public bool haspeenblayed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (logofadein >= 8.9 && haspeenblayed == false)
        {
            audioSource.Play();
            haspeenblayed = true;
        }
    }
}
