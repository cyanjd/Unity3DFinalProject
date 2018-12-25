using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ready2 : MonoBehaviour {
   //public bool startNow;
	// Use this for initialization
	void Start () {
        //startNow = false;
	}
    bool isClicked = false;
    void OnMouseDown()
    {
        isClicked = true;
    }

    // Update is called once per frame
    void Update () {
        if (isClicked){
            Debug.Log("Triggered");
            Destroy(this.gameObject);
            umbrellaMove.startNow = true;
        }
	}

}
