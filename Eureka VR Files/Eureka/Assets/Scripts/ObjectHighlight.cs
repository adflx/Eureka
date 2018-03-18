using UnityEngine;
using System.Collections;

public class ObjectHighlight : MonoBehaviour {
    public GUISkin GamaSkin;
    public string objectname;

    private Color StartColour;
    private bool _displayobjectname = false;

    void OnGUI()
    {
        GUI.skin = GamaSkin;
        DisplayName();
    }


    public void DisplayName()
    {
        if (_displayobjectname == true)
        {
          //  GUI.Box(new Rect(Event.current.))
        }
    }

    void onGaze()
    {
        StartColour = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.blue;
        _displayobjectname = true;
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
