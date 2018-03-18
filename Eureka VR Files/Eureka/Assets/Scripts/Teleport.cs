using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
    public Transform[] teleportpoints;
    int currentpoints;
    public AudioClip soundeffect;
	// Use this for initialization
	void Start () {
        currentpoints = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.JoystickButton1) || Input.GetKeyDown(KeyCode.L))
        {
            currentpoints++;
            currentpoints %= teleportpoints.Length;
            transform.position = teleportpoints[currentpoints].position;
            AudioSource.PlayClipAtPoint(soundeffect, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton2) || Input.GetKeyDown(KeyCode.J))
        {
            if(currentpoints == 0){
                currentpoints = teleportpoints.Length - 1;
            }
            else
            {
                currentpoints--;
            }
            
            currentpoints %= teleportpoints.Length;
            transform.position = teleportpoints[currentpoints].transform.position;
            AudioSource.PlayClipAtPoint(soundeffect, transform.position);
        }
	}
}
