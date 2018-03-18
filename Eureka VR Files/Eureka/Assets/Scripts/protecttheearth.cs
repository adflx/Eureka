using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class protecttheearth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    public void newscene()
    {

        SceneManager.LoadScene("loading-4");
    }
}
