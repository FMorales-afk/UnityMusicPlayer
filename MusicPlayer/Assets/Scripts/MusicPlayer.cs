using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    
    //Created list to hold audio clips
    public List<AudioClip> musicClips = new List<AudioClip>();

    //Audio source to take in mp3 files
    private AudioSource musicSource;

    //checks which track is currently playing
    AudioClip currentTrack; 

    private float length;

    //loop to allow music to continue playing
    private Coroutine musicLoop;
    //queue that plays music in order 
    private MusicQueue musicQueue;

    
    
    

    // Start is called before the first frame update
    void Start()
    {
        musicQueue = new MusicQueue(musicClips);

        musicSource = GetComponent<AudioSource>();

        //StartMusic();
    }

    
    //plays music once track has ended
    public void PlayMusicClip(AudioClip music)
    {
        musicSource.Stop();
        musicSource.clip = music;
        musicSource.Play();
    }


    //if not null music loop halts
    public void StopMusic()
    {
        if(musicLoop != null)
        {
            StopCoroutine(musicLoop);
        }
    }

    //begins beginning track of playlist
    public void StartMusic()
    {
        musicLoop = StartCoroutine(musicQueue.LoopMusic(this, 0, PlayMusicClip));
    }
   

    

   
}

//queue 
public class MusicQueue
{
   private List<AudioClip> clips;

    public MusicQueue(List<AudioClip> clips)
    {
        this.clips = clips;
    }
    public IEnumerator LoopMusic(MonoBehaviour player, float delay, System.Action<AudioClip> playFunction)
    {
        while(true)
        {
            yield return player.StartCoroutine(Run(RandomizeList(clips), delay, playFunction));
        }
    }
    public IEnumerator Run(List<AudioClip> tracks, float delay, System.Action<AudioClip> playFunction)
    {
        foreach(AudioClip clip in tracks)
        {
            playFunction(clip);

            yield return new WaitForSeconds(clip.length + delay);
        }
    }
    //feautrue to randomize play order 
    public List<AudioClip> RandomizeList(List<AudioClip> list)
    {
        List<AudioClip> copy = new List<AudioClip>(list);

        int n = copy.Count;

        while(n > 1)
        {
            n--;

            int k = Random.Range(0, n + 1);

            AudioClip value = copy[k];

            copy[k] = copy[n];
            copy[n] = value;
        }

        return copy;
    }
}
