using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour {

    public Text textOB1;
    public Text textOB2;
    public Image back1;
    public Image back2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            Time.timeScale = 0;
            textOB1.text = "Do you want to Exit the Game" + "\n" + "Press B Button to continue playing\n" + "Press A Button to Exit";
            textOB2.text = "Do you want to Exit the Game" + "\n" + "Press B Button to continue\n" + "Press A Button to Exit";
            textOB1.color = Color.yellow;
            textOB2.color = Color.yellow;
            back1.color = Color.black;
            back2.color = Color.black;
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.JoystickButton3))
            {
                SceneManager.LoadScene("GameOver");
            }
            else if(Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                Time.timeScale = 1;
            }
        }
	}
}
