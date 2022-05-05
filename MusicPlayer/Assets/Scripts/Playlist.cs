using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
