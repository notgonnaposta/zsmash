using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class audiosetting : MonoBehaviour
{
    public AudioMixer audioMixer;
    public string SFX;
    public Slider slider;
    public float savedVolume;

    private const string PlayerPrefKeyPrefix = "Volume_";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat(PlayerPrefKeyPrefix + SFX, 1f);
        slider.value = savedVolume;

        SetVolume(savedVolume);

        slider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float sliderValue)
    {
        float dB;
        if (sliderValue > 0.0001f)
            dB = Mathf.Log10(sliderValue) * 20f;
        else
            dB = -80f;

        audioMixer.SetFloat(SFX, dB);


        PlayerPrefs.SetFloat(PlayerPrefKeyPrefix + SFX, sliderValue);
        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
