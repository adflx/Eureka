using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Solarsystemmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ssscene()
    {
        SceneManager.LoadScene("loading-2");
    }
}
