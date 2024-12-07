using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;

public class VolumeSettings : MonoBehaviour
{

    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider masterVolSlider;
    [SerializeField] Slider sfxVolSlider;
    [SerializeField] Slider musicVolSlider;

    string masterVol = "MasterVol";
    string sfxVol = "SFXVol";
    string musicVol = "MusicVol";
    void Start() {
        masterVolSlider.value = PlayerPrefs.GetFloat(masterVol, 0.25f);        
        sfxVolSlider.value = PlayerPrefs.GetFloat(sfxVol, 0.25f);
        musicVolSlider.value = PlayerPrefs.GetFloat(musicVol, 0.25f);
        setMasterVol();
        setSFXVol();
        setMusicVol();

    }
    public void setMasterVol() {
        SetVolume(masterVol, masterVolSlider.value);
        PlayerPrefs.SetFloat(masterVol, masterVolSlider.value);
    }
    public void setSFXVol() {
        SetVolume(sfxVol, sfxVolSlider.value);
        PlayerPrefs.SetFloat(sfxVol, sfxVolSlider.value);

    }
    public void setMusicVol() {
        SetVolume(musicVol, musicVolSlider.value);
        PlayerPrefs.SetFloat(musicVol, musicVolSlider.value);

    }
    
    void SetVolume(string groupName, float value) {
        float adjVol = Mathf.Log10(value) * 20;

        if (value == 0) {
            adjVol = -80;
        }
        audioMixer.SetFloat(groupName, adjVol);   
    }
}