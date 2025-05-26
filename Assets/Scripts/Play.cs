using UnityEngine;

public class Play : MonoBehaviour

{
    public Grabby grabby;
    public Mover mover;
    public AudioSource audioSource;
    public bool hasplayed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mover.zdead == true){
        if (audioSource.isPlaying == false && hasplayed == false)
         {
audioSource.Play();
hasplayed = true;
        }
        }
       
    }
}
