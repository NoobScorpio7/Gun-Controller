using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiohandlers : MonoBehaviour
{
    public AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
