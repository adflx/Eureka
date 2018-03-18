using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainmenuback : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void mmback()
    {
        SceneManager.LoadScene("loading-0");
    }
}
