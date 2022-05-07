using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Author: Hadriel Saldua
/// </summary>
public class PlayBackManager : MonoBehaviour
{
    // Public audio source to interat with
    public AudioSource audio;

    // Function to call on pause/play button clicked
    public void PlayPause()
    {
        // if currently playing, pause
        if (audio.isPlaying)
        {
            audio.Pause();
        }

        // else play the song
        else
        {
            audio.Play();
        }
    }
}
