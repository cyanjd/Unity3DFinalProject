using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinScore : MonoBehaviour {


    public static int score;
    public bool gameDone = false;
  
    GUIStyle guiStyleButton;
    GUIStyle guiStyleBox;
    bool guiStyleSetup = false;

    // Use this for initialization
    void Start()
    {
        score = 0;
    }

    void OnGUI()
    {
        if (guiStyleSetup == false)
        {
            guiStyleButton = new GUIStyle(GUI.skin.button);
            guiStyleButton.fontSize = 30;
            guiStyleSetup = true;
        }

        GUILayout.BeginHorizontal("box");
        GUILayout.Button("Coin Count: " + score, guiStyleButton);
        GUILayout.EndHorizontal();

        if (gameDone)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 300, 100), "Incorrect Answer", guiStyleButton);

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 100), "Click Here to Restart", guiStyleButton))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
