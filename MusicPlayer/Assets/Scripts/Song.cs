using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

/// <summary>
/// Authors: Pavel Delev, Hadriel Saldua
/// 
/// Song class, holds properties related to songs.
/// Function OnClickPlay(): When the assigned button is clicked, stop the current song, load in the clicked one, play the song, 
///     and update the UI to reflect the change.
/// </summary>
public class Song : MonoBehaviour
{
    // variables to handle the song data
    public int num;
    public string title;
    public string artist;
    public string album;
    public string length;
    public TimeSpan songLength;

    // holds the song itself
    public AudioClip song;

    // interacts with the player to load song
    public AudioSource player;

    // Used to display data to UI
    public TextMeshProUGUI numText;
    public TextMeshProUGUI songText;
    public TextMeshProUGUI artistText;
    public TextMeshProUGUI albumText;
    public TextMeshProUGUI lengthText;
    public TextMeshProUGUI songInfo;
    public TextMeshProUGUI artistInfo;

    // When the program starts
    private void Awake()
    {
        player = FindObjectOfType<AudioSource>(); // get the audio player
        numText.text = num.ToString(); // write the song number to ui
        songText.text = title; // write the title to the ui
        artistText.text = artist; // write the artist to the ui
        albumText.text = album; // write the album to the ui
        lengthText.text = length; // write teh song length to the ui
    }

    /// <summary>
    /// Default constructor
    /// </summary>
    public Song()
    {
        num = 0;
        title = "title";
        artist = "artist";
        album = "album";
        songLength = new TimeSpan(0, 0, 0);
    }

    // function to be called when song is clicked
    public void OnClickPlay()
    {
        // writes the song and artist to botom left ui
        songInfo.text = title;
        artistInfo.text = artist;

        // stop the current song
        player.Stop();

        // load the clicked song and play
        player.clip = song;
        player.Play();
    }
}
