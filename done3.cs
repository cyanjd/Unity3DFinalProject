using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class done3 : MonoBehaviour {

   //public GameObject doneButton;
   // public GameObject restartButton;
    public GameObject correctBox;
   //public GameObject incorrectBox;
    public GameObject arrow;
    public int answer;

    public bool restart;
    //public bool correctNum;
    public bool isClicked;

    GUIStyle guiStyleButton;
    GUIStyle guiStyleBox;
    bool guiStyleSetup = false;

    // Use this for initialization
    void Start () {
        isClicked = false;
       //correctNum = false;
        correctBox.SetActive(false);
        arrow.SetActive(false);
	}

    void OnMouseDown()
    {
        isClicked = true;
        restart = false;
    }


    // Update is called once per frame
    void Update () {
        if (isClicked == true)
        {
            if (coinScore.score == answer)
            {
               // correctNum = true;
                correctBox.SetActive(true);
                arrow.SetActive(true);

            }
            else{
                restart = true;
            }
        }
    }

    void OnGUI()
    {
        if (guiStyleSetup == false)
        {
            guiStyleButton = new GUIStyle(GUI.skin.button);
            guiStyleButton.fontSize = 30;
            guiStyleSetup = true;
        }

        if (restart)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 300, 100), "Incorrect Answer", guiStyleButton);

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 100), "Click Here to Restart", guiStyleButton))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
 }
