﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip tuyuldead;
    public AudioClip tuyulspawn;
    public AudioClip tuyulattack;

    private AudioSource audio;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        audio = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    public void TuyulSpawn()
    {
        audio.PlayOneShot(tuyulspawn);
    }

    public void TuyulDead()
    {
        audio.PlayOneShot(tuyuldead);
    }


}
