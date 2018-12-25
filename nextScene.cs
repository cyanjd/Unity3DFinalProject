using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {

    // Use this for initialization
    public int sceneNum;

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
        if (isClicked == true)
        {
            SceneManager.LoadScene(sceneNum);
        }

    }
}
