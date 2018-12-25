using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoin : MonoBehaviour {

    public AudioSource coinNoise;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        Destroy(this.gameObject);
        coinNoise.Play();
        coinScore.score += 1;
    }
}
