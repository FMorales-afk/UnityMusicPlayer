using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBackManager : MonoBehaviour
{
    public AudioSource audio;

    public void PlayPause()
    {
        if (audio.isPlaying)
        {
            audio.Pause();
        }

        else
        {
            audio.Play();
        }
    }
}
