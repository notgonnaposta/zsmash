using UnityEngine;
using UnityEngine.Audio;

public class applyaudio : MonoBehaviour
{
    public AudioMixer audioMixer;

    private const string musicKey = "Volume_MUSICvolume";
    private const string sfxKey = "Volume_SFXvolume";
    private const string masterKey = "Volume_MASTERvolume";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ApplyVolume(musicKey, "MUSICvolume");
        ApplyVolume(sfxKey, "SFXvolume");
        ApplyVolume(masterKey, "MASTERvolume");
    }

    // Update is called once per frame
    void ApplyVolume(string playerPrefKey, string exposedParam)
    {
        float sliderValue = PlayerPrefs.GetFloat(playerPrefKey, 1f);
        float dB = (sliderValue > 0.0001f) ? Mathf.Log10(sliderValue) * 20f : -80f;
        audioMixer.SetFloat(exposedParam, dB);
    }
}
