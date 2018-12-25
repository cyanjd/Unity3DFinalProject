using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class promptTextInput : MonoBehaviour {
    // Use this for initialization

    //public InputField mainInputField;
    public GameObject mainInputField;

    void Start()
    {
        mainInputField.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
       Debug.Log("Triggered");
       // Destroy(this.gameObject);
        mainInputField.SetActive(true);
    }
}
