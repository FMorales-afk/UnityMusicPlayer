using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Author: Pavel Delev
/// 
/// Holds properties related to playlists (playlist name and playlist songs)
/// </summary>
public class Playlist : MonoBehaviour
{
    public string title;
    public List<Song> songs;

    public Playlist()
    {
        title = "Playlist title";
        songs = new List<Song>();
    }
}
