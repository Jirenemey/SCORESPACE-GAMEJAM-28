using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeController : MonoBehaviour
{

    public Slider _musicSlider, _sfxSlider;
    public TextMeshProUGUI musicPercent, sfxPercent;
    private float percentage1, percentage2;
    

    public void Awake(){
        _musicSlider.value = PlayerPrefs.GetFloat("Music");
        _sfxSlider.value = PlayerPrefs.GetFloat("SFX");
    }

    public void Update(){
        PlayerPrefs.SetFloat("Music", _musicSlider.value);
        PlayerPrefs.SetFloat("SFX", _sfxSlider.value);
        percentage1 = _musicSlider.value * 100;
        percentage2 = _sfxSlider.value * 100;
        musicPercent.text = percentage1.ToString("F0") + "%";
        sfxPercent.text = percentage2.ToString("F0") + "%";
        MusicVolume();
        SFXVolume();
    }

    public void MusicVolume(){
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }
    
    public void SFXVolume(){
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
    }
}
