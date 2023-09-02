using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag =="Player" || collision.gameObject.tag =="Attacker" || collision.gameObject.tag =="Defender" || collision.gameObject.tag =="Companion" || collision.gameObject.tag =="Sides"){
            audioSource.Play();
        }
    }
}
