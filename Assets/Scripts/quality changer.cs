using UnityEngine;
using UnityEngine.UI;

public class qualitychanger : MonoBehaviour
{
    public Dropdown qualityDropdown;
    private const string PREF_KEY = "QualitySetting";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        qualityDropdown.ClearOptions();

        string[] names = QualitySettings.names;
        qualityDropdown.AddOptions(new System.Collections.Generic.List<string>(names));

        int savedIndex = PlayerPrefs.GetInt(PREF_KEY, QualitySettings.GetQualityLevel());
        qualityDropdown.value = savedIndex;
        qualityDropdown.RefreshShownValue();
        
        ApplyQuality(savedIndex);

        qualityDropdown.onValueChanged.AddListener(delegate { OnDropdownChanged(qualityDropdown.value); });
    }
    void OnDropdownChanged(int index)
    {
ApplyQuality(index);
PlayerPrefs.SetInt(PREF_KEY, index);
PlayerPrefs.Save();
    }
    void ApplyQuality(int index)
    {
        QualitySettings.SetQualityLevel(index, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
