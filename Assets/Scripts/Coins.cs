using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {

    private int count;
    public Text countText;
    public AudioSource audioSource;
    public AudioClip coinSound;

    // Use this for initialization
    void Start () {

        count = 0;
        SetCount();

    }
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCount();
            playSound(coinSound);
        }
    }

    public void playSound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    void SetCount()
    {
        countText.text = "Count: " + count.ToString();
    }
}
