using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class ScreenSettings : MonoBehaviour
{
    [SerializeField] TMP_Dropdown resolutionsDropDown;

    Resolution[] resolutions;

    void Start() {
        resolutions = Screen.resolutions;
        Resolution currentResolution = Screen.currentResolution;
        int curRes = PlayerPrefs.GetInt("ResolutionIndex", resolutions.Length-1);
        for (int i = 0; i < resolutions.Length; i++) {
            string resolutionString = resolutions[i].width.ToString() + "x" + resolutions[i].height.ToString();
            resolutionsDropDown.options.Add(new TMP_Dropdown.OptionData(resolutionString));

        }

        curRes = Math.Min(curRes, resolutions.Length-1);
        resolutionsDropDown.value = curRes;
        SetResolution();
    }

    public void SetResolution() {
        int resIndex = resolutionsDropDown.value;
        Screen.SetResolution(resolutions[resIndex].width, resolutions[resIndex].height, false);
        PlayerPrefs.SetInt("ResolutionIndex", resolutionsDropDown.value);
    }
}
