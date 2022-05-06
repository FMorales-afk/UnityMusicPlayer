using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void SetVolume()
    {
        music.volume = volumeSlider.value;
    }
}
