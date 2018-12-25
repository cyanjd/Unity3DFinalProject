using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    GUIStyle ourBoxStyle;

    bool areStylesSetup = false;
    public static float hSliderValue = 50.0f;


    private void OnGUI()
    {
        if (areStylesSetup == false)
        {
            ourBoxStyle = new GUIStyle(GUI.skin.box);
            ourBoxStyle.fontSize = 30;
            areStylesSetup = true;

        }

        GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 150, 450, 450), "Main Menu", ourBoxStyle);
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 250, 25),
        "Level 1"))
        {
            print("Level 1");
            SceneManager.LoadScene(1);

        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 250, 25),
        "Level 2"))
        {
            print("Level 2");
            SceneManager.LoadScene(2);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 0, 250, 25),
        "Level 3"))
        {
            print("Level 3");
            SceneManager.LoadScene(3);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50, 250, 25),
        "Level 4"))
        {
            print("Level 4");
            SceneManager.LoadScene(4);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 100, 250, 25),
        "Level 5"))
        {
            print("Level 5");
            SceneManager.LoadScene(5);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 150, 250, 25),
        "Level 6"))
        {
            print("Level 6");
            SceneManager.LoadScene(6);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 200, 250, 25),
       "Level 7"))
        {
            print("Level 7");
            SceneManager.LoadScene(7);
        }
        // hSliderValue = GUI.HorizontalSlider(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 0, 100, 30), hSliderValue, 0.0f, 100.0f);
        //GUI.Box(new Rect(Screen.width / 2, Screen.height - 0, 50, 30), hSliderValue.ToString());
        // GUI.Label(new Rect(Screen.width / 2 + 10, Screen.height / 2, 100, 20), ((int)hSliderValue).ToString());
    }


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
