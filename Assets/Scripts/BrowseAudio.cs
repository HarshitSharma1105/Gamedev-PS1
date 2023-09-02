using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrowseAudio : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayThis(){
        audioSource.Play();
    }
}
