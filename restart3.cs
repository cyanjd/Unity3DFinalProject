using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart3 : MonoBehaviour {

    public bool isClicked;

    // Use this for initialization
    void Start () {
        isClicked = false;
	}

    void OnMouseDown()
    {
        isClicked = true;
    }

    // Update is called once per frame
    void Update () {
        if (isClicked == true){
            Debug.Log("yes");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
