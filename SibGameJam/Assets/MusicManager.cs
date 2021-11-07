using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    public static bool initDone = false;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        
        if(initDone == false)
        {
            initDone = true;
            _audioSource.Play();
        }
    }
}
