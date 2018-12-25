using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class umbrellaMove : MonoBehaviour {

    public AudioSource rainNoise;
    public GameObject rain;
    public GameObject arrow;
    public GameObject correct;
    private int loop1;
    float timeAccumulated = 0f;
    float timeAccumulated2 = 0f;

    bool messedUp;
    public static bool startNow;

    GUIStyle guiStyleButton;
    GUIStyle guiStyleBox;
    bool guiStyleSetup = false;
    bool done;

    //private int loop2;
    // Use this for initialization
    void Start () {
        loop1 = 0;
        Time.timeScale = 1;
        messedUp = false;
        done = false;
        startNow = false;
        //transform.Translate(Vector2.right * Time.deltaTime * 1);
        // loop2 = 0

        arrow.SetActive(false);
        correct.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (startNow){
            timeAccumulated2 += Time.deltaTime;
            if ((transform.position.x >= 6) && timeAccumulated2 > 4)
            {
                transform.Translate(Vector2.left * Time.deltaTime * 1);
                //loop1 += 1;
                Debug.Log("stop");
                timeAccumulated += Time.deltaTime;
                if ((int)timeAccumulated == 4)
                {
                    Destroy(rain);
                    done = true;
                    rainNoise.Stop();
                }
            }
            else if (loop1 == 0 && timeAccumulated2 > 5)
            {
                transform.Translate(Vector2.right * Time.deltaTime * 1);
            }
        }
        /*timeAccumulated2 += Time.deltaTime;
        if ((transform.position.x >= 6) && timeAccumulated2 > 4){
            transform.Translate(Vector2.left * Time.deltaTime * 1);
            //loop1 += 1;
            Debug.Log("stop");
            timeAccumulated += Time.deltaTime;
            if ((int)timeAccumulated == 4){
                Destroy(rain);
                done = true;
            }
        }
        else if (loop1 == 0 && timeAccumulated2 > 30)
        {
            transform.Translate(Vector2.right * Time.deltaTime * 1);
        }*/
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (done == false){
            messedUp = true;
        }
        if (done == true){
            arrow.SetActive(true);
            correct.SetActive(true);
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

        if (messedUp)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 300, 100), "Incorrect", guiStyleButton);

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 100), "Click Here to Restart", guiStyleButton))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
