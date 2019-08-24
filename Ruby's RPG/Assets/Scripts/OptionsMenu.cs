﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    private AudioSource music;
    private Slider slider;
    public RubyController Ruby;


    private void OnEnable() {
        music = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();

        Debug.Log("enabled slider");
        slider = GameObject.Find("VolumeSlider").GetComponent<Slider>();
        slider.value = music.volume;
    }

    public void SetVolume(float volume) {
        music.volume = volume;
    }

    public void DeleteData() {
        PlayerData data = Ruby.NewRuby();
        SaveSystem.SavePlayer(data);
    }
}   
