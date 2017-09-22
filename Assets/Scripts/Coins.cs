using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {

    private int count;
    public Text countText;

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
        }
    }

    void SetCount()
    {
        countText.text = "Count: " + count.ToString();
    }
}
