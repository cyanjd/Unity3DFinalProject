using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block1lvl6 : MonoBehaviour {

    public AudioSource punch;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        level6.userOrder.Add(1);
        punch.Play();
    }
}
