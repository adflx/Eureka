using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class earthmotionmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void emscene()
    {
        //  AutoFade.LoadLevel("EarthMotion", 3, 1, Color.black);
        SceneManager.LoadScene("loading-3");
        
    }

}
