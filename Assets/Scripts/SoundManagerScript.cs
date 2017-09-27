using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public AudioSource audioSource;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(audioSource.isPlaying == false && Time.time >0.5f)
        {
            audioSource.Play();
            audioSource.time = 8.0f;
        }
	}
}
