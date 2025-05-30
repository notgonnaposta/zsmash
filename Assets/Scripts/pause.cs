using UnityEngine;
using UnityEngine.Audio;

public class pause : MonoBehaviour
{
    public GameObject Pausescreen;
    public GameObject numberui;
    public AudioSource IGmusic;
    public AudioSource PSmusic;
    public AudioMixer SFX;
    public float dB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Pause()
    {
        float savedNormalized = PlayerPrefs.GetFloat("Volume_SFXvolume", 1f);


         dB = (savedNormalized > 0.0001f) ? Mathf.Log10(savedNormalized) * 20f : -80f;
        IGmusic.Pause();
        PSmusic.Play();
        SFX.SetFloat("SFXvolume", -80f);

        Time.timeScale = 0;
        numberui.SetActive(false);
        Pausescreen.SetActive(true);
    } 
    public void unpause()
    {
        IGmusic.UnPause();
        PSmusic.time = 0f;
        PSmusic.Pause();
       SFX.SetFloat("SFXvolume", dB);

        Time.timeScale = 1;
        AudioListener.pause = false;
        numberui.SetActive(true);
        Pausescreen.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
