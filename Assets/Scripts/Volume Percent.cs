using UnityEngine;
using UnityEngine.UI;

public class VolumePercent : MonoBehaviour
{
    public audiosetting audiosetting;
    public Text text;
    public float volumevalue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        volumevalue = audiosetting.slider.value * 100f;
        text.text = volumevalue.ToString("F0") + "%";
    }
}
