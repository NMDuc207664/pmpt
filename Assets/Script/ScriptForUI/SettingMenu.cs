using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using TMPro;
=======
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af

public class SettingMenu : MonoBehaviour
{
    public Slider musicSlider, sfxSlider;
<<<<<<< HEAD
    public TMPro.TMP_Dropdown imageQuality;
=======
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af

    public void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("music",10);
        sfxSlider.value = PlayerPrefs.GetFloat("sfx", 10);
<<<<<<< HEAD
        imageQuality.value = PlayerPrefs.GetInt("image", 0);
=======
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
    }

    public void MusicVolume()
    {
        PlayerPrefs.SetFloat("music",musicSlider.value);
        AudioManager.Instance.MusicVolume(musicSlider.value);
    }

    public void SfxVolume()
    {
        PlayerPrefs.SetFloat("sfx", sfxSlider.value);
        AudioManager.Instance.SfxVolume(sfxSlider.value);
    }

    public void SetGraphic(int qualityIndex)
    {
<<<<<<< HEAD
        PlayerPrefs.SetInt("image", qualityIndex);
=======
>>>>>>> 6c8fc666f88b704478b391626bbc739275b3b3af
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
