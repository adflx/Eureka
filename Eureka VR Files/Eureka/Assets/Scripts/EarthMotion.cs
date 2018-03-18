using UnityEngine;
using System.Collections;

public class EarthMotion : MonoBehaviour {

	// Use this for initialization
    private Animator anim1, anim2;
	void Start () {
        anim1 = GameObject.Find("layers-se").GetComponent<Animator>();
       
	}
	
	// Update is called once per frame
	void Update () {
        

	}

    public void plaay()
    {
        anim1.SetTrigger("IsAnimTrig");
    }
}
