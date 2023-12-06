using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;
    void Start()
{
    if (Input.GetKeyDown(KeyCode.X))
    {
        audioSource.PlayOneShot(clip, volume);
    }
}
}