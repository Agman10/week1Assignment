using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource source;


    void Start()
    {
        source = GetComponent<AudioSource>();
        //source.Play(0);
        
    }
    void OnTriggerEnter()
    {
        source.Play();
    }
}
