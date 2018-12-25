using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back2Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    bool isClicked = false;
    void OnMouseDown()
    {
        isClicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            SceneManager.LoadScene(0);
        }
    }
}
