using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class trafficLight : MonoBehaviour {
    // Use this for initialization

    //public InputField mainInputField;
    public GameObject greenLight;
    public GameObject speechBubble;
    public InputField input;
    public GameObject mainInputField;
    public string message;
    public bool canGo;
    public static bool destroyy;

    public GameObject arrow;
    public GameObject character;

    void Start()
    {
        greenLight.SetActive(false);
        arrow.SetActive(false);
        canGo = false;
        destroyy = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (string.Equals(input.text, message))
        {
            greenLight.SetActive(true);
            destroyy = true;
            canGo = true;
        }
        if (destroyy == true){
            Destroy(speechBubble);
            Destroy(mainInputField);
        }
        if (character.transform.position.x >= 2.3 && canGo){
            arrow.SetActive(true);
        }
        if (character.transform.position.x >= 2.3 && !canGo)
        {
            //ScoreDisplayer.health -= 5;

        }
    }

}
