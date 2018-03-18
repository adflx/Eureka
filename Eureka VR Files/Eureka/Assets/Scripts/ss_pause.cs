using UnityEngine;
using System.Collections;

public class ss_pause : MonoBehaviour {
        public bool paused;
        private Animator na;
	// Use this for initialization
	void Start () {
        na = GameObject.Find("solarsystem").GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
    void Update(){
    
    }
 
    public void plaay()
    {
        na.SetTrigger("IsAnimTrig");
    }
}
