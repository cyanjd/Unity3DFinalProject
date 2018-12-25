using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHint : MonoBehaviour {

    public GameObject hintStuff;
    public GameObject x;
    bool isClicked;

    // Use this for initialization
    void Start () {
        hintStuff.SetActive(false);
        x.SetActive(false);
        Debug.Log("did it");
        isClicked = false;
	}

    void OnMouseDown()
    {
        isClicked = true;
        Debug.Log("clicked");
    }

    // Update is called once per frame
    void Update () {
        //if (isClicked == false){
          //  Debug.Log("false");
       // }
        if (isClicked == true){
            hintStuff.SetActive(true);
            isClicked = false;
            x.SetActive(true);
        }
	}
}
