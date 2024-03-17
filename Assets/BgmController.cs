using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmController : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        InvokeRepeating("PlayDelayed", 10f, audioClip.length + 10f);
    }

    void PlayDelayed()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
