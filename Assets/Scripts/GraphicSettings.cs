using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GraphicSettings : MonoBehaviour
{
    public Dropdown dropdown;
    private Resolution[] resolutions;
    private const string PREF_KEY = "ResolutionIndex";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resolutions = Screen.resolutions;
        List<string> options = new List<string>();
        int currentResIndex = 0;
        for (int i = 0; i< resolutions.Length; i++)
        
        {
            string resOption = resolutions[i].width + " X " + resolutions[i].height;
            if (!options.Contains(resOption))
            options.Add(resOption);
            if (resolutions[i].width == Screen.currentResolution.width &&
            resolutions[i].height == Screen.currentResolution.height)
            {
             currentResIndex = i;
            }
        }
        dropdown.AddOptions(options);
        int savedIndex = PlayerPrefs.GetInt(PREF_KEY, currentResIndex);
        dropdown.value = savedIndex;
        dropdown.RefreshShownValue();
        
        ApplyResolution(savedIndex);


        dropdown.onValueChanged.AddListener(delegate { OnDropdownChanged(dropdown.value); });


    }
    void OnDropdownChanged(int index)
    {
        ApplyResolution(index);
        PlayerPrefs.SetInt(PREF_KEY, index);
        PlayerPrefs.Save();
    }

    void ApplyResolution(int index)
    {
Resolution res = resolutions[index];
Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
