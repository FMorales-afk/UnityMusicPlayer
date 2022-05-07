using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Author: Pavel Delev
/// 
/// Handles setting the volume level based off the slider value.
/// </summary>
public class VolumeManager : MonoBehaviour
{
    [SerializeField]
    private GameObject musicPlayer;
    private AudioSource music;
    [SerializeField]
    private Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        music = musicPlayer.GetComponent<AudioSource>();
    }

    /// <summary>
    /// Sets the audio source's volume based on the value of the volume slider.
    /// </summary>
    public void SetVolume()
    {
        music.volume = volumeSlider.value;
    }
}
