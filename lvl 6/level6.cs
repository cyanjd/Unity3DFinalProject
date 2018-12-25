using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class level6 : MonoBehaviour
{

    //public GameObject block1;
    //public GameObject block2;
    //public GameObject block3;

    public int[] order;
    public static ArrayList userOrder;
    public bool goodJob;

    public int amtInArray;

    public GameObject arrow;
    public GameObject correctBox;

    GUIStyle guiStyleButton;
    GUIStyle guiStyleBox;
    bool guiStyleSetup = false;


    // Use this for initialization
    void Start()
    {
        goodJob = true;
        order = new int[] {1,3,3,2,3,4,5};
        userOrder = new ArrayList();
        arrow.SetActive(false);
        correctBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (userOrder.Count > 0)
        {
            amtInArray = userOrder.Count;
            //Debug.Log(amtInArray);
            if ((order[amtInArray - 1] != (int)userOrder[amtInArray - 1]))
            {
                goodJob = false;
            }
            /*if (goodJob == false)
            {
                Debug.Log("bad");
            }*/
            /*if (goodJob){
                 Debug.Log("good");
             }
             foreach (var item in userOrder)
             {
                 Debug.Log(item);
             }
             Debug.Log("stop");*/
            if (goodJob == true && ((int)userOrder.Count == order.Length))
            {
                arrow.SetActive(true);
                correctBox.SetActive(true);
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

        if (goodJob == false && ((int)userOrder.Count == order.Length))
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 300, 100), "Incorrect Answer", guiStyleButton);

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 100), "Click Here to Restart", guiStyleButton))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
