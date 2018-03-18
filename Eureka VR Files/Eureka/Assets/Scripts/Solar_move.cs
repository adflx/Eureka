using UnityEngine;
using System.Collections;

public class Solar_move : MonoBehaviour {
    private Animator anim1, anim2;
	// Use this for initialization
	void Start () {
        anim1 = GameObject.Find("solarsystem").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void plaay()
    {
        anim1.SetTrigger("IsAnimTrig");
    }

}
