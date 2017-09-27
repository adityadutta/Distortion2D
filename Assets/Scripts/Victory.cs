using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour {

    public Text winText;
    public AudioSource audioSource;
    public AudioClip victorySound;
    public AudioSource bgmusic;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            winText.text = "Victory!";
            bgmusic.mute = true;
            playSound(victorySound);
        }
    }

    public void playSound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
