using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Objective : MonoBehaviour {
    public Text textOB1;
    public Text textOB2;
    public Image back1;
    public Image back2;
    float restartTimer;
    public float restartDelay;
    
    // Use this for initialization
    void Start () {
        
        textOB1.color = Color.yellow;
        textOB2.color = Color.yellow;
        back1.color = Color.black; 
        back2.color = Color.black;

    }
	
	// Update is called once per frame
	void Update () {




        restartTimer += Time.deltaTime;
        if (restartTimer >= restartDelay)
        {
            back1.color = Color.clear;
            back2.color = Color.clear;
            textOB1.color = Color.clear;
            textOB2.color = Color.clear;
            
            restartTimer = 0;
            this.GetComponent<Objective>().enabled = false;
        }


    }
}
