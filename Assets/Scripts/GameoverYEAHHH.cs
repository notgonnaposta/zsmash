using UnityEngine;
using UnityEngine.Audio;

public class GameoverYEAHHH : MonoBehaviour
{
    public GameObject Gameoverscreen;
    public Damage damage;
    public pause pause;
    public bool latch = false;
    public GameObject numberui;
    public AudioSource GOmusic;
    public AudioSource IGmusic;
    public float dB;
    public AudioMixer SFX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float savedNormalized = PlayerPrefs.GetFloat("Volume_SFXvolume", 1f);


         dB = (savedNormalized > 0.0001f) ? Mathf.Log10(savedNormalized) * 20f : -80f;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damage.health == 0 && latch == false)
        {

            numberui.SetActive(false);
            Gameoverscreen.SetActive(true);
            Time.timeScale = 0;
            
            latch = true;
            IGmusic.Pause();
        GOmusic.Play();
            SFX.SetFloat("SFXvolume", -80f);
        }
        
    }
}
