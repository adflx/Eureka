using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonUI : MonoBehaviour {
    public Image b1;
    public Image a1;
    public Image c1;
    public Image d1;

    public Image a2;
    public Image b2;
    public Image c2;
    public Image d2;

  
    // Use this for initialization
    void Start () {
        a1.color = new Color(255, 255, 255, .2f);
        b1.color = new Color(255, 255, 255, .2f);
        c1.color = new Color(255, 255, 255, .2f);
        d1.color = new Color(255, 255, 255, .2f);

        a2.color = new Color(255, 255, 255, .2f);
        b2.color = new Color(255, 255, 255, .2f);
        c2.color = new Color(255, 255, 255, .2f);
        d2.color = new Color(255, 255, 255, .2f);
    }
	
	// Update is called once per frame
	void Update () {

        //button0
        if (Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.A))
        {
            a1.color = new Color(255, 255, 255, 1f);
            a2.color = new Color(255, 255, 255, 1f);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton0) || Input.GetKeyUp(KeyCode.A))
        {
            a1.color = new Color(255, 255, 255, .2f);
            a2.color = new Color(255, 255, 255, .2f);
        }

        //button1

        if (Input.GetKeyDown(KeyCode.JoystickButton1) || Input.GetKeyDown(KeyCode.C))
        {
            c1.color = new Color(255, 255, 255, 1f);
            c2.color = new Color(255, 255, 255, 1f);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton1) || Input.GetKeyUp(KeyCode.C))
        {
            c1.color = new Color(255, 255, 255, .2f);
            c2.color = new Color(255, 255, 255, .2f);
        }

        //button2

        if (Input.GetKeyDown(KeyCode.JoystickButton2) || Input.GetKeyDown(KeyCode.D))
        {
            d1.color = new Color(255, 255, 255, 1f);
            d2.color = new Color(255, 255, 255, 1f);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton2) || Input.GetKeyUp(KeyCode.D))
        {
            d1.color = new Color(255, 255, 255, .2f);
            d2.color = new Color(255, 255, 255, .2f);
        }

        //button3

        if (Input.GetKeyDown(KeyCode.JoystickButton3) || Input.GetKeyDown(KeyCode.B))
        {
            b1.color = new Color(255, 255, 255, 1f);
            b2.color = new Color(255, 255, 255, 1f);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton3) || Input.GetKeyUp(KeyCode.B))
        {
            b1.color = new Color(255, 255, 255, .2f);
            b2.color = new Color(255, 255, 255, .2f);
        }







    }
}
