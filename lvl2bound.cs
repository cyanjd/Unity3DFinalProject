using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class lvl2bound : MonoBehaviour {

    public bool gameDone = false;

    GUIStyle guiStyleButton;
    GUIStyle guiStyleBox;
    bool guiStyleSetup = false;
    public InputField input;
    public string message;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        gameDone = true;
    }


    void OnGUI()
    {
        if (guiStyleSetup == false)
        {
            guiStyleButton = new GUIStyle(GUI.skin.button);
            guiStyleButton.fontSize = 30;
            guiStyleSetup = true;
        }

        if (gameDone && !(string.Equals(input.text, message)))
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 300, 100), "Incorrect", guiStyleButton);

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 100), "Click Here to Restart", guiStyleButton))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

}
