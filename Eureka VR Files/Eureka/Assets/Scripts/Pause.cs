using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    public bool paused;
    public Image back1;
    public Image back2;
    public Text text1;
    public Text text2;

    public Text textOB11;
    public Text textOB22;
    public Image back11;
    public Image back22;




    // Use this for initialization
    void Start () {
        paused = false;

	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.JoystickButton3) || Input.GetKeyDown(KeyCode.Space))
        {
            
            paused = !paused;
        }
        if (paused)
        {
           
            Time.timeScale = 0;
            back1.color = Color.black;
            back2.color = Color.black;
            text1.color = Color.white;
            text2.color = Color.white;
            textOB11.text = "Do you want to Exit the Game" + "\n" + "Press A Button to continue playing\n" + "Press B Button to Exit";
            textOB22.text = "Do you want to Exit the Game" + "\n" + "Press A Button to continue playing\n" + "Press B Button to Exit";
            textOB11.color = Color.yellow;
            textOB22.color = Color.yellow;
            back11.color = Color.black;
            back22.color = Color.black;

            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("GameOver2");
            }


        }
        else if (!paused)
        {
            
            Time.timeScale = 1;
            back1.color = Color.clear;
            back2.color = Color.clear;
            text1.color = Color.clear;
            text2.color = Color.clear;
          
            textOB11.color = Color.clear;
            textOB22.color = Color.clear;
            back11.color = Color.clear;
            back22.color = Color.clear;
        } 
	}
}
