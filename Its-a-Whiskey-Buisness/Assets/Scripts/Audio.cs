using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour
{
    public AudioClip audioClip; // The audio clip that will play when the GameObject is clicked
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    void OnMouseDown()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}