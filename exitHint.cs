using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitHint : MonoBehaviour {

    public GameObject hintStuff;

    // Use this for initialization
    void Start () {
		
	}

    bool isClicked = false;

    private void OnMouseDown()
    {
        isClicked = true;
    }

    // Update is called once per frame
    void Update () {
        if (isClicked){
            hintStuff.SetActive(false);
            this.gameObject.SetActive(false);
            isClicked = false;
        }
	}
}
