using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRepeat : MonoBehaviour
{
    // AudioClip for playing a voice sound.
    public AudioClip voice;

    // AudioClip for playing an explosion sound.
    public AudioClip explosions;

    // Interval in seconds at which the voice sound should be repeated.
    public float repeatIntervalVoice;

    // Interval in seconds at which the explosion sound should be repeated.
    public float repeatIntervalExplosion;

    // Reference to the AudioSource component used to play the audio clips.
    private AudioSource source;

    // Start is called before the first frame update.
    void Start()
    {
        // Get the AudioSource component attached to this GameObject.
        source = GetComponent<AudioSource>();

        // Schedule the PlaySoundVoice method to be called repeatedly after an initial delay of 5 seconds.
        InvokeRepeating("PlaySoundVoice", 5f, repeatIntervalVoice);

        // Schedule the PlaySoundExplosions method to be called repeatedly starting immediately.
        InvokeRepeating("PlaySoundExplosions", 0f, repeatIntervalExplosion);
    }

    // Method to play the voice sound once.
    void PlaySoundVoice()
    {
        source.PlayOneShot(voice);
    }

    // Method to play the explosion sound once.
    void PlaySoundExplosions()
    {
        source.PlayOneShot(explosions);
    }
}
