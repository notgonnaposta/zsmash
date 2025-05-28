using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class logofadein : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float updatejimmy;
    public float fadeinstart;
    public float fadeinend;
    public float fadeoutstart;
    public float fadeoutend;
    public bool soundonce = false;
    public AudioSource audioSource;
    public GameObject blackscreen;
    public GameObject menu;
    public static bool hasbeenplayed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (soundonce == false)
        {
            audioSource.Play();
            soundonce = true;
    
        }

        {
            Color color = spriteRenderer.color;
            color.a = 0f;
            spriteRenderer.color = color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        updatejimmy = updatejimmy + Time.deltaTime;
        if (updatejimmy >= fadeinstart && updatejimmy <= fadeinend)
        {
            float t = (updatejimmy - fadeinstart) / (fadeinend - fadeinstart);
            Color color = spriteRenderer.color;
            color.a = Mathf.SmoothStep(0f, 1f, t);
            spriteRenderer.color = color;



        }
        else if (updatejimmy >= fadeoutstart && updatejimmy <= fadeoutend)
        {
            float t = (updatejimmy - fadeoutstart) / (fadeoutend - fadeoutstart);
            Color color = spriteRenderer.color;
            color.a = Mathf.SmoothStep(1f, 0f, t);
            spriteRenderer.color = color;

        }
        if (updatejimmy > 19)
        {
            blackscreen.SetActive(false);
        }
        if (updatejimmy > 29)
        {
            menu.SetActive(true);
        }

        if (updatejimmy > 32)
        {
            hasbeenplayed = true;
            Destroy(gameObject);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            updatejimmy = 32;
            audioSource.Stop();
        }
        if (hasbeenplayed == true)
        {
            updatejimmy = 32;
            audioSource.Stop();
    }
}
}
