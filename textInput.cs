using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textInput : MonoBehaviour {

    private InputField input;


    private void Awake()
    {
        input = GameObject.Find("InputField").GetComponent<InputField>();
    }

    public void GetInput(string guess){
        Debug.Log("You Entered +" + guess);
        input.text = "";
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
