using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Song : MonoBehaviour
{
    public int num;
    public string title;
    public string artist;
    public string album;
    public TimeSpan songLength;

    public Song()
    {
        num = 0;
        title = "title";
        artist = "artist";
        album = "album";
        songLength = new TimeSpan(0, 0, 0);
    }
}
