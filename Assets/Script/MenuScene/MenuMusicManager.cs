using System.Collections;
using System.Collections.Generic;
using Script.System;
using UnityEngine;
using UnityEngine.UI;

public class MenuMusicManager : MonoBehaviour
{
    public GameObject musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        musicSlider.GetComponent<Slider>().value = GameObject.Find("GameData").GetComponent<GamaData>().MusicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = musicSlider.GetComponent<Slider>().value;
    }
}
