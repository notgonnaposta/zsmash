using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class soundoff : MonoBehaviour
{
    public AudioSource audioSource;
    public UnityEvent soundover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Sounder()
    {
        StartCoroutine(soundoffer());
    }

public IEnumerator soundoffer()
{
    audioSource.Play();

    while (audioSource.isPlaying)
    {
        yield return null;
    }


    soundover.Invoke();
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
