using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inBounds : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered");
        player.transform.position = new Vector3((float)-7.93, player.transform.position.y, player.transform.position.z);
    }
}
