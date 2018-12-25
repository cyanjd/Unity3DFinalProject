using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class successfulPrint : MonoBehaviour {

    // Use this for initialization
    public InputField input;
    public string message;
    public GameObject nextLevel; 

	void Start () {
        input = GameObject.Find("InputField").GetComponent<InputField>();
        nextLevel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(input.text);
        if (string.Equals(input.text, message)){
            Debug.Log("Success!");
            nextLevel.SetActive(true);
        }
    }
}
