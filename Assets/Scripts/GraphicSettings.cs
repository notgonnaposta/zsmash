using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicSettings : MonoBehaviour
{
    public Dropdown dropdown;
    private List<Resolution> uniqueResolutions = new List<Resolution>();
    private const string PREF_KEY = "ResolutionIndex";

    void Start()
    {
        Resolution[] allResolutions = Screen.resolutions;
        List<string> options = new List<string>();
        HashSet<string> seen = new HashSet<string>();
        int currentResIndex = 0;

        for (int i = 0; i < allResolutions.Length; i++)
        {
            string label = allResolutions[i].width + " x " + allResolutions[i].height;

            if (!seen.Contains(label))
            {
                seen.Add(label);
                options.Add(label);
                uniqueResolutions.Add(allResolutions[i]);

                if (allResolutions[i].width == Screen.currentResolution.width &&
                    allResolutions[i].height == Screen.currentResolution.height)
                {
                    currentResIndex = uniqueResolutions.Count - 1;
                }
            }
        }

        dropdown.ClearOptions();
        dropdown.AddOptions(options);

        int savedIndex = PlayerPrefs.GetInt(PREF_KEY, currentResIndex);
        dropdown.value = savedIndex;
        dropdown.RefreshShownValue();

        ApplyResolution(savedIndex);
        dropdown.onValueChanged.AddListener(OnDropdownChanged);
    }

    void OnDropdownChanged(int index)
    {
        ApplyResolution(index);
        PlayerPrefs.SetInt(PREF_KEY, index);
        PlayerPrefs.Save();
    }

    void ApplyResolution(int index)
    {
        if (index < 0 || index >= uniqueResolutions.Count)
        {
            Debug.LogWarning("Resolution index out of bounds!");
            return;
        }

        Resolution res = uniqueResolutions[index];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
}
