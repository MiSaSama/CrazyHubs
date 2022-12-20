using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundMenager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
       void Start()
    {
            if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
    }
    public void ChangeVolume() {
    
     AudioListener.volume=volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("MusicVolume",volumeSlider.value);
    }

}

