using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Song : MonoBehaviour
{
    public int num;
    public string title;
    public string artist;
    public string album;
    public string length;
    public TimeSpan songLength;

    public AudioClip song;

    public AudioSource player;

    public TextMeshProUGUI numText;
    public TextMeshProUGUI songText;
    public TextMeshProUGUI artistText;
    public TextMeshProUGUI albumText;
    public TextMeshProUGUI lengthText;

    public TextMeshProUGUI songInfo;
    public TextMeshProUGUI artistInfo;

    private void Awake()
    {
        player = FindObjectOfType<AudioSource>();
        numText.text = num.ToString();
        songText.text = title;
        artistText.text = artist;
        albumText.text = album;
        lengthText.text = length;
    }

    public Song()
    {
        num = 0;
        title = "title";
        artist = "artist";
        album = "album";
        songLength = new TimeSpan(0, 0, 0);
    }

    public void OnClickPlay()
    {
        songInfo.text = title;
        artistInfo.text = artist;
        player.Stop();
        player.clip = song;
        player.Play();
    }
}
