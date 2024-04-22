using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassRustle : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip rustle;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            audioSource.PlayOneShot(rustle);
        }
    }
}
